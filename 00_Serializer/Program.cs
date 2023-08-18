using _00_Library;
using System.Xml.Serialization;


var usuario = new Usuario()
{
    Nome = "Samuel",
    Cpf = "111.111.111-11",
    Email = "Samuel@gmail.com"
};

var serializer = new XmlSerializer(typeof(Usuario));

var stream = new StreamWriter(@"C:\Trabalho\AdvancedCSharp\00_Library\Documentos\serializado.xml");

serializer.Serialize(stream, usuario);
Console.WriteLine("Criado com Sucesso");
