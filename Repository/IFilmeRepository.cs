using ApiNetCoreDapper.Models;
namespace ApiNetCoreDapper.Repository;

public interface IFilmeRepository
{
    Task<IEnumerable<FilmeResponse>> BuscaFilmesAsync();
    Task<FilmeResponse> BuscaFilmeAsync(int id);
    Task<bool> AdicionaAsync(FilmeRequest request);
    Task<bool> AtualizaAsync(FilmeRequest request, int id);
    Task<bool> DeletaAsync(int id);
}
