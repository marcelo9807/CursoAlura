

namespace Oficina.Modelos;

internal class Carro
{
    public Carro(string marca, string modelo, string cor, string placa)
    {
        Marca = marca;
        Modelo = modelo;
        Cor = cor;
        Placa = placa;
    }

    public  string Marca { get; }
    public string Modelo { get; }
    public string Cor { get; }
    public string Placa { get;}
    public string Resumo => $"{Modelo}\nMarca: {Marca}\nCor: {Cor}\nPlaca: {Placa}";



}
