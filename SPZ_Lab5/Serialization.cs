using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.IO;

namespace SPZ_Lab5.Model
{
    static class Serialization
    {
       
        static public void Serialize<T>(string path, List<T> list)//метод сериализации
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<T>));
             using (FileStream file = new FileStream(path, FileMode.Create))
            {
                jsonFormatter.WriteObject(file, list);
            }
        }
        static public List<T> Deserialize<T>(string path, List<T> list) //метод десериализации
            {
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<T>));
            using (FileStream file = new FileStream(path, FileMode.Open))
            {
                return jsonFormatter.ReadObject(file) as List<T>;
            }
        }
    }
}
