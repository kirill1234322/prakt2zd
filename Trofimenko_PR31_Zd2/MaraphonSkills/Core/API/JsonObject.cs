using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace MaraphonSkills.Core.API
{
    public class JsonObject
    {
        public static T Deserialize<T>(string jsonString)
        {
            using (MemoryStream ms = new MemoryStream(Encoding.GetEncoding(1251).GetBytes(jsonString)))
            {
                DataContractJsonSerializerSettings settings = new DataContractJsonSerializerSettings();
                var ser = new DataContractJsonSerializer(typeof(T), settings);
                return (T)ser.ReadObject(ms);
            }
        }
    }
}
