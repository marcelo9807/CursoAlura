namespace Oficina.Modelos;

internal class Servico
{
    public Servico(string status)
    {
        Status = status;
        if (status == "ok" || status == "OK")
        {
            Status = "OK";
        }
        else
        {
            Status = "Nao esta pronto";
        }
    }

    public string Status { get; }
    public void Exibirstatus()
    {
        Console.WriteLine($"Status:{Status}");
    }


}
