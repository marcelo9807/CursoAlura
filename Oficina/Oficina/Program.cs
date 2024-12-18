using Oficina.Modelos;

internal class Program
{
    private static void Main(string[] args)
    {
        Carro carro1 = new("Mit", "Lancer", "Preto", "265205");
        Proprietario dono1 = new("Marcelo", 25, "Travessa angelo golin");
        dono1.AdiconarCarros(carro1);

        Servico servico1 = new("ok");

        Mecanico mecanico1 = new("Joao", 45);

        Oficinas oficina1 = new("Mec", 656565656, "Rua do joao");

        oficina1.AdicionarMecanico(mecanico1);
        oficina1.AdicionarCarro(dono1);
        oficina1.AdicionarStatus(servico1);






        oficina1.ExibirDetalhes();
    }
}