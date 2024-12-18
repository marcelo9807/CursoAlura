namespace PetShop.Modelos;

internal class Dono
{
    private List<Pet> Pet = new();
    public Dono(string nome, int idade, long cPF, string endereco)
    {
        Nome = nome;
        Idade = idade;
        CPF = cPF;
        Endereco = endereco;
    }

    public string Nome { get; }
    public int Idade { get; }
    public long CPF { get; }
    public string Endereco { get; }
    public string ResumoDoDono => $"Nome Do dono: {Nome} -- CPF:{CPF} -- Idade: {Idade} -- Endereço: {Endereco}";

    public void AdiconarPet(Pet pet)
    {
        Pet.Add(pet);
    }
    public void ExibirDetalhes()
    {
        foreach (Pet pet in Pet)
        {
            Console.WriteLine($"Informaçoes Do dono:\n{ResumoDoDono}\nInformaçoes do pet:\n{pet.Resumo}");
        }
    }
}
