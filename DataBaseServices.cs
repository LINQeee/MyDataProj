using System;
using Newtonsoft.Json;
using System.IO;
using System.Data.SqlClient;

namespace DataAppProj
{
    public class DataBaseServices
    {
        public static string connectionString;

            public static void Setup()
            {
                var json = File.ReadAllText("Z:\\test\\MyDataProj\\appData.json");
                ConfigJson myDeserializedClass = JsonConvert.DeserializeObject<ConfigJson>(json);
                connectionString = myDeserializedClass.ConnectionString;   
                
            }


    }
    public struct ConfigJson
    {
        [JsonProperty("connectionString")]
        public string ConnectionString{get; private set;}
    }
}