using ApiNetCoreDapper.Models;
using Dapper;
using Oracle.ManagedDataAccess.Client;
namespace ApiNetCoreDapper.Repository;

public class FilmeRepository : IFilmeRepository
{
    private readonly IConfiguration _configuration;
    private readonly string? connectionString;

    public FilmeRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        connectionString = _configuration.GetConnectionString("OracleConnection");
    }

    public async Task<IEnumerable<FilmeResponse>> BuscaFilmesAsync()
    {
        string sql = @"SELECT A.ID, A.NOME, A.ANO, B.NOME AS PRODUTORA
                        FROM APIFILME A
                        INNER JOIN APIPRODUTORA B
                        ON A.ID_PRODUTORA = B.ID";

        using var con = new OracleConnection(connectionString);
        return await con.QueryAsync<FilmeResponse>(sql);
    }

    public async Task<FilmeResponse> BuscaFilmeAsync(int id)
    {
        string sql = @"SELECT A.ID, A.NOME, A.ANO, B.NOME AS PRODUTORA
                        FROM APIFILME A
                        INNER JOIN APIPRODUTORA B
                        ON A.ID_PRODUTORA = B.ID
                        WHERE A.ID = :Id";

        using var con = new OracleConnection(connectionString);
        return await con.QueryFirstOrDefaultAsync<FilmeResponse>(sql, new { Id = id });
    }

    public Task<bool> AdicionaAsync(FilmeRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AtualizaAsync(FilmeRequest request, int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeletaAsync(int id)
    {
        throw new NotImplementedException();
    }
}
