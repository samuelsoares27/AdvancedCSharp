using _00_Library;
using System.Xml.Serialization;

var stream = new StreamReader(@"C:\Trabalho\AdvancedCSharp\00_Library\Documentos\serializado.xml");
var serializer = new XmlSerializer(typeof(Usuario));

Usuario usuario =  (Usuario)serializer.Deserialize(stream);

Console.WriteLine($" {usuario.Nome} \n {usuario.Cpf} \n {usuario.Email}");
Console.ReadKey();
