using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using SonsOfTheForest.Saves;

namespace SonsOfTheForestCompanionRescue
{

    public class NPC
    {
        public static readonly Dictionary<int, string> NamedNpcTypeIds = new Dictionary<int, string>()
        {
            { 9, "Kelvin" },
            { 10, "Virginia" },
        };

        public int TypeID { get; private set; }
        public JToken Data { get; private set; }
        public bool Alive
        {
            get
            {
                return (Health?.Value<double?>() ?? 0d) > 0d;
            }
        }
        public JValue Health { get; private set; }

        public JValue X { get; private set; }
        public JValue Y { get; private set; }
        public JValue Z { get; private set; }


        public NPC(int npcTypeId, GameSave gameSaveData)
        {
            TypeID = npcTypeId;
            var actorList = (JArray)(gameSaveData.Contents["SaveData.json"].SelectToken("Data.VailWorldSim.Actors"));
            Data = actorList.FirstOrDefault(obj => (int)obj["TypeId"] == npcTypeId);
            if (Data == null)
            {
                throw new Exception($"No NPC with {npcTypeId} was found.");
            }

            // Some save versions omit certain fields; ensure they're present so the UI can read/edit safely.
            var dataObj = Data as JObject;
            if (dataObj == null)
            {
                throw new Exception($"NPC data for {npcTypeId} was not an object.");
            }

            var statsObj = dataObj["Stats"] as JObject;
            if (statsObj == null)
            {
                statsObj = new JObject();
                dataObj["Stats"] = statsObj;
            }
            if (statsObj["Health"] == null || statsObj["Health"].Type == JTokenType.Null)
            {
                statsObj["Health"] = 0d;
            }
            Health = (JValue)statsObj["Health"];

            var posObj = dataObj["Position"] as JObject;
            if (posObj == null)
            {
                posObj = new JObject();
                dataObj["Position"] = posObj;
            }
            if (posObj["x"] == null || posObj["x"].Type == JTokenType.Null) posObj["x"] = 0d;
            if (posObj["y"] == null || posObj["y"].Type == JTokenType.Null) posObj["y"] = 0d;
            if (posObj["z"] == null || posObj["z"].Type == JTokenType.Null) posObj["z"] = 0d;

            X = (JValue)posObj["x"];
            Y = (JValue)posObj["y"];
            Z = (JValue)posObj["z"];
        }
    }
}
