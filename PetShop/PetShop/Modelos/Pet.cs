namespace PetShop.Modelos;

internal class Pet
{
    public Pet(string nome, int idade, string raca)
    {
        Nome = nome;
        Idade = idade;
        Raca = raca;
    }

    public string Nome { get;}
    public int Idade { get; }
    public string Raca { get; }
    public string Resumo => $"Nome:{Nome} -- Raça: {Raca} -- Idade: {Idade}";

}
