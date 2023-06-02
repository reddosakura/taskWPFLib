using Newtonsoft.Json;

namespace JsonLib
{
    public class JsonUtils
    {
        private static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static void Deserial<T>(T obj, string file)
        {
            string json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(path + "\\" + file, json);
        }
        public static T Serial<T>(string file)
        {
            if (File.Exists(path + "\\" + file))
            {
                string json = File.ReadAllText(path + "\\" + file);
                T obj = JsonConvert.DeserializeObject<T>(json);
                return obj;
            }
            return default(T);
        }
    }
}