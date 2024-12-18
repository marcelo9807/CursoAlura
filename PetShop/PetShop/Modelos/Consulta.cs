namespace PetShop.Modelos;

internal class Consulta
{
    private List<Medico> Medico = new List<Medico>();
    public Consulta(string endercoDaConsulta, string horario)
    {
        EndercoDaConsulta = endercoDaConsulta;
        Horario = horario;
    }

    public string EndercoDaConsulta { get; }
    public string Horario { get; }
    public string ResumoConsulta => $"Endereço:{EndercoDaConsulta} - Horario:{Horario}";

    public void AdicionarConsulta(Medico medico)
    {
        Medico.Add(medico);
    }
    public void ExibirDetalhesDaConsulta()
    {
        foreach (Medico medico in Medico) 
        {
            medico.ExibirDetalhesMedico();
            Console.WriteLine($"Detalhes da consulta:\n{ResumoConsulta}");
        }
    }

}
