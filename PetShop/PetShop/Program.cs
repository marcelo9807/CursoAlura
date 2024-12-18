using PetShop.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {
        Pet pet1 = new("Boris", 2, "Chow Chow");
        Dono Dono1 = new("Marcelo", 25, 065454645, "Agenor santos");
        Dono1.AdiconarPet(pet1);
        Medico Medico1 = new("Jose", "Geral");
        Medico1.AdicionarMedico(Dono1);
        Consulta Consulta1 = new("Rua castro alvez", "18:00");
        Consulta1.AdicionarConsulta(Medico1);
        Consulta1.ExibirDetalhesDaConsulta();
    }
}