using _00_Library;
using _05_Generics;

var carro = new Carro()
{
    Marca = "Fiat",
    Modelo = "Uno"
};

var casa = new Casa()
{
    Cidade = "Alfenas",
    Endereco = "Amélio da Silva Gomes"
};

var usuario = new Usuario()
{
    Nome = "Camila",
    Cpf = "222.222.222-22",
    Email = "Camila@gmail.com"
};

Serializador.Serializar(carro);
Serializador.Serializar(casa);
Serializador.Serializar(usuario);

var carroSerializado = Serializador.Deserializar<Carro>();
var casaSerializado = Serializador.Deserializar<Casa>();
var usuarioSerializado = Serializador.Deserializar<Usuario>();


Console.WriteLine($"{carroSerializado.Marca} {carroSerializado.Modelo}");

Console.WriteLine($"{casaSerializado.Cidade} {casaSerializado.Endereco}");

Console.WriteLine($"{usuarioSerializado.Nome} {usuarioSerializado.Cpf} {usuarioSerializado.Email}");
