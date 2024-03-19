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
                return (int)Health > 0;
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
            Health = (JValue)Data["Stats"]["Health"];
            X = (JValue)Data["Position"]["x"];
            Y = (JValue)Data["Position"]["y"];
            Z = (JValue)Data["Position"]["z"];
        }
    }
}
