

namespace Oficina.Modelos;

internal class Mecanico
{
    public Mecanico(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public string Nome { get;}
    public int Idade { get; }
    public string ResumoMecanico => $"Nome: {Nome}, Idade:{Idade}";
    public void ExibirDetalhesMecanico()
    {
        
        Console.WriteLine($"Mecanico resposnavel:\n{ResumoMecanico}");
    }
}
