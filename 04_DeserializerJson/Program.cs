

using _00_Library;
using Newtonsoft.Json;


var stream = new StreamReader(@"C:\Trabalho\AdvancedCSharp\00_Serializer\Documentos\serializado.json");
var json = stream.ReadToEnd();

var usuario = JsonConvert.DeserializeObject<Usuario>(json);

Console.WriteLine($" {usuario.Nome} \n {usuario.Cpf} \n {usuario.Email}");
Console.ReadKey();
