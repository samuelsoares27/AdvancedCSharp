using _00_Library;
using Newtonsoft.Json;

namespace _05_Generics
{
    public class Serializador
    {
        public static void Serializar(object obj)
        {
            string json = JsonConvert.SerializeObject(obj);

            var stream = new StreamWriter(@$"C:\Trabalho\AdvancedCSharp\00_Library\Documentos\{obj.GetType().Name}.json");

            stream.Write(json);
            stream.Close();
        }

        public static T Deserializar<T>()
        {

            var stream = new StreamReader(@$"C:\Trabalho\AdvancedCSharp\00_Library\Documentos\{typeof(T).Name}.json");
            var json = stream.ReadToEnd();

            return JsonConvert.DeserializeObject<T>(json);
             
        }
    }
}
