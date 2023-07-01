namespace ApiNetCoreDapper.Models;

public class FilmeRequest
{
    public required string Nome { get; set; }
    public int Ano { get; set; }
    public required string Produtora { get; set; }
}
