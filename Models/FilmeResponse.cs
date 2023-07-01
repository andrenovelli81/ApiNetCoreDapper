namespace ApiNetCoreDapper.Models;

public class FilmeResponse
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public int Ano { get; set; }
    public required string Produtora { get; set; }
}
