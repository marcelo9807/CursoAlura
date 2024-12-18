namespace Oficina.Modelos;

internal class Proprietario
{
    private  List<Carro> carros = new ();

    public Proprietario(string nome, int idade, string endereco)
    {
        Nome = nome;
        Idade = idade;
        Endereco = endereco;
    }

    public string Nome { get; }
    public int Idade { get;}
    public string Endereco { get; }
    public string ResumoProprietario => $"{Nome}, Idade: {Idade}, Endereço:{Endereco}";

    public void AdiconarCarros(Carro carro)
    {
        carros.Add(carro);

    }
    public void ExibirDetalhes()
    {
        foreach(var carro in carros)
        {
            {
                Console.WriteLine($"Proprietario: {ResumoProprietario}\nCarro: {carro.Resumo} ");
            }
        }
    }
}
