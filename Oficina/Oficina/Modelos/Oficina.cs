namespace Oficina.Modelos;

internal class Oficinas
{
    private List<Mecanico> Mecanicos = new();
    private List<Servico> servicos = new();
    private List<Proprietario> proprietarios = new();
    public Oficinas(string nome, long cnpj, string endereco)
    {
        Nome = nome;
        Cnpj = cnpj;
        Endereco = endereco;
    }

    public string Nome { get;}
    public long Cnpj { get; }
    public string Endereco { get; }
    public string ResumoOficina => $"Nome da oficina: {Nome}, Cnpj: {Cnpj}, Endereço: {Endereco}";
    

    public void AdicionarCarro(Proprietario proprietario)
    {
        proprietarios.Add(proprietario);
    }

    public void AdicionarStatus(Servico servico)
    {
        servicos.Add(servico);
    }
    public void AdicionarMecanico(Mecanico mecanico)
    {
        Mecanicos.Add(mecanico);
    }
    private void ExibirDetalhesCarro()
    {
        foreach(Proprietario proprietario in proprietarios)
        {
            proprietario.ExibirDetalhes();
        }
    }
    private void ExibirDetalhesServico()
    {
        foreach (Servico servico in servicos)
        {
            servico.Exibirstatus(); 
        }
    }
    private void ExibirDetalhesMacanico()
    {
        foreach(Mecanico mecanico in Mecanicos)
        {
            mecanico.ExibirDetalhesMecanico();
        }
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"{ResumoOficina}");
        ExibirDetalhesMacanico();
        ExibirDetalhesCarro();
        ExibirDetalhesServico();
    }





}

