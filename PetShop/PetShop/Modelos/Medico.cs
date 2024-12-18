using System.Xml;

namespace PetShop.Modelos;

internal class Medico
{
    private List<Dono> Dono = new List<Dono>();


    public Medico(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
    }

    public string Nome { get; }
    public string Especialidade { get; }
    public string ResumoMedico => $"Nome do Medico: {Nome} -- Especialidade: {Especialidade}";
    public void AdicionarMedico(Dono dono)
    {
        Dono.Add(dono);
    }
    public void ExibirDetalhesMedico()
    {
        
        foreach(Dono donos in Dono) 
        {
            donos.ExibirDetalhes();
            Console.WriteLine($"Informaçoes Do Medico:\n{ResumoMedico}");
        }
    }


}
