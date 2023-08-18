using _00_Library;
using Newtonsoft.Json;

var usuario = new Usuario()
{
    Nome = "Camila",
    Cpf = "222.222.222-22",
    Email = "Camila@gmail.com"
};

string json = JsonConvert.SerializeObject(usuario);

var stream = new StreamWriter(@"C:\Trabalho\AdvancedCSharp\00_Serializer\Documentos\serializado.json");

stream.Write(json);
stream.Close();

Console.WriteLine($"{json}");
