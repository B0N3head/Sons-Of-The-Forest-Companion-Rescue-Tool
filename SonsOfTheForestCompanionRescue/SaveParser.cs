using Newtonsoft.Json.Linq;
using System.IO.Compression;
using System.Collections.ObjectModel;

namespace SonsOfTheForest.Saves
{
    public enum GameSaveType
    {
        /// <summary>
        /// Indicates a multiplayer save. These saves only appear on the host machine and contain server world specific info.
        /// </summary>
        Multiplayer,
        /// <summary>
        /// Indicates a singleplayer save.
        /// </summary>
        Singleplayer,
        /// <summary>
        /// Indicates a multiplayer client save. These saves only appear on a machine that connected to a remotely hosted server, and only contain player specific info.
        /// </summary>
        MultiplayerClient
    }

    public static class SaveManager
    {
        /// <summary>
        /// The root Saves folder where all the saves are located.
        /// %userprofile%\appdata\locallow\Endnight\SonsOfTheForest\Saves\
        /// </summary>
        public static readonly string SavesDirectory = @$"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}Low\Endnight\SonsOfTheForest\Saves";

        /// <summary>
        /// Gets and returns a list of <see cref="GameSaveItem"/>s. Ignores MultiplayerClient saves by default.
        /// </summary>
        /// <param name="includeClientSaves">If set to <see langword="true"/>, the retured list also includes <see cref="GameSaveType.MultiplayerClient"/> saves.</param>
        /// <returns></returns>
        public static List<GameSaveItem> GetSavesList(bool includeClientSaves = false)
        {
            var saveIdPath = Directory.GetDirectories(SavesDirectory)[0];
            List<GameSaveItem> saves = new List<GameSaveItem>();
            
            var types = Enum.GetNames(typeof(GameSaveType));
            if (includeClientSaves == false)
            {
                types[2] = "";
            }
            foreach (var type in types)
            {
                var saveTypeDirPath = Path.Combine(saveIdPath, type);
                if (String.IsNullOrEmpty(type) == false && Directory.Exists(saveTypeDirPath))
                {
                    var items = Directory.GetDirectories(saveTypeDirPath);
                    foreach (var item in items)
                    {
                        // Filter out EA saves
                        if (File.Exists(Path.Combine(item, GameSave.SaveFileName)))
                        {
                            saves.Add(new GameSaveItem(item));
                        }
                    }
                }
            }
            return saves;
        }
    }

    public struct GameSaveItem
    {
        public string ID { get; private set; }
        public string Name { get; private set; }
        public string Location { get; private set; }
        public string ThumbnailPath { get; private set; }
        public GameSaveType Type { 
            get 
            {
                if (Location.Contains("MultiplayerClient"))
                {
                    return GameSaveType.MultiplayerClient;
                }
                else if (Location.Contains("Singleplayer"))
                {
                    return GameSaveType.Singleplayer;
                }
                else
                {
                    return GameSaveType.Multiplayer;
                }
            } 
        }

        public string DisplayName
        {
            get
            {
                return $"[{Type}] {Name}";
            }
        }

        internal GameSaveItem(string path)
        {
            Location = path;
            ID = Path.GetFileName(Location);
            ThumbnailPath = Path.Combine(Location, GameSave.ThumbnailFileName);
            Name = Path.GetFileName(Directory.GetFiles(Location).FirstOrDefault(file => file.EndsWith(".name"), "UnknownGameSave")).Replace(".name", "");
        }
    }

    /// <summary>
    /// Represents a game save and its contents.
    /// </summary>
    public class GameSave
    {
        /// <summary>
        /// The root directory of the save.
        /// </summary>
        public string DirPath { get; private set; }
        public const string ThumbnailFileName = "SaveDataThumbnail.png";
        public const string SaveFileName = "SaveData.zip";
        /// <summary>
        /// The internal ID of the save.
        /// </summary>
        public string ID { get; private set; }
        /// <summary>
        /// The in-game name of the save.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// The host type of the save.
        /// </summary>
        public GameSaveType Type { get; private set; }
        /// <summary>
        /// The time this game was last saved at.
        /// </summary>
        public DateTime SaveTime { get; private set; }
        /// <summary>
        /// Contains the list and contents of the save files within this save, dependent on <seealso cref="SaveParser.ReadMode"/>.
        /// </summary>
        public ReadOnlyDictionary<string, JObject> Contents { get; private set; }

        public GameSave(string savePath)
        {
            DirPath = savePath;
            // Get list of files in the real save directory (not in the zip folder)
            var saveDirFiles = Directory.GetFiles(DirPath);
            if (saveDirFiles.Length > 0 )
            {
                if (File.Exists(Path.Combine(DirPath, SaveFileName)) == false)
                {
                    throw new Exception($"Game save at {DirPath} is missing main save data zip file. Early-access saves are no longer supported by this version.");
                }
            }
            else
            {
                throw new Exception($"Game save folder at {DirPath} exists but has no contents.");
            }
            
            ID = Path.GetFileName(savePath);
            Type = GetSaveType();
            LoadFiles();
            var saveTimeString = Contents["GameStateSaveData.json"].SelectToken("Data.GameState.SaveTime")?.ToString();
            SaveTime = saveTimeString != null ? DateTime.Parse(saveTimeString) : File.GetCreationTime(Path.Combine(DirPath, SaveFileName));
            Name = Path.GetFileName(saveDirFiles.FirstOrDefault(file => file.EndsWith(".name"), "UnknownGameSave")).Replace(".name", "");
        }

        public GameSave(GameSaveItem saveItem) : this(saveItem.Location) { }

        /// <summary>
        /// Saves and overwrites the contents of the approriate savefiles with the data in <see cref="Contents"/>.
        /// </summary>
        public void WriteChanges()
        {
            var backupFilePath = Path.Combine(DirPath, $"{SaveFileName}.backup");
            // Create backup
            if (File.Exists(backupFilePath))
                File.Delete(backupFilePath);
            File.Copy(Path.Combine(DirPath, SaveFileName), backupFilePath);
            //
            using (MemoryStream ms = new MemoryStream())
            {
                using (ZipArchive archive = new ZipArchive(ms, ZipArchiveMode.Create, true))
                {
                    foreach (var item in Contents)
                    {
                        var file = archive.CreateEntry(item.Key);
                        using (var fileStream = file.Open())
                        {
                            using (var writer = new StreamWriter(fileStream))
                            {
                                writer.Write(SerialiseFile(item.Value));
                            }
                        }
                    }
                }
                using (var fileStream = new FileStream(Path.Combine(DirPath, SaveFileName), FileMode.Create))
                {
                    ms.Seek(0, SeekOrigin.Begin);
                    ms.CopyTo(fileStream);
                }
            }
        }

        /// <summary>
        /// Returns the save's thumbnail image.
        /// </summary>
        /// <returns></returns>
        public Image GetThumbnail() 
        {
            return Image.FromFile(Path.Combine(DirPath, ThumbnailFileName));
        }

        private GameSaveType GetSaveType()
        {
            if (DirPath.Contains("MultiplayerClient"))
            {
                return GameSaveType.MultiplayerClient;
            }
            else if (DirPath.Contains("Singleplayer"))
            {
                return GameSaveType.Singleplayer;
            }
            else
            {
                return GameSaveType.Multiplayer;
            }
        }

        /// <summary>
        /// Loads the save's contents into memory.
        /// </summary>
        private void LoadFiles()
        {
            var files = new Dictionary<string, JObject>();   
            using (ZipArchive archive = ZipFile.OpenRead(Path.Combine(DirPath, SaveFileName)))
            {
                var contents = archive.Entries;
                foreach (var file in contents)
                {
                    using (var fileStream = file.Open())
                    {
                        using (var reader = new StreamReader(fileStream))
                        {
                            var content = reader.ReadToEnd();
                            files.Add(file.Name, ParseFile(content));
                        }
                    }
                }
            }
            Contents = new ReadOnlyDictionary<string, JObject>(files);
        }

        private JObject ParseFile(string content)
        {
            JObject json = JObject.Parse(content);
            JObject saveData = (JObject)json["Data"];

            /*
            The Data object's key values are stored as strings, to this loops through all of them
            and explicitly parses them as an object
            */

            foreach (var kvp in saveData)
            {
                string stringEntry = kvp.Value.ToString();
                saveData[kvp.Key] = JObject.Parse(stringEntry);
            }

            return json;
        }

        private string SerialiseFile(JObject contents)
        {
            JObject save = new JObject(contents);
            JObject saveData = (JObject)save["Data"];

            /*
            The Data object's key values are stored as strings, to this loops through all of them
            and converts back to string
            */

            foreach (var kvp in saveData)
            {
                string stringEntry = kvp.Value.ToString(Newtonsoft.Json.Formatting.None);
                saveData[kvp.Key] = stringEntry;
            }

            return save.ToString(Newtonsoft.Json.Formatting.None);
        }
    }
}
