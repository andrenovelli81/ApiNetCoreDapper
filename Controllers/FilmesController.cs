using ApiNetCoreDapper.Repository;
using Microsoft.AspNetCore.Mvc;
namespace ApiNetCoreDapper.Controllers;

[ApiController]
[Route("api/filmes")]
public class FilmesController : ControllerBase
{
    private readonly IFilmeRepository _repository;

    public FilmesController(IFilmeRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var filmes = await _repository.BuscaFilmesAsync();
        return filmes.Any() ? Ok(filmes) : NoContent();
    }

    [HttpGet("id")]
    public async Task<IActionResult> GetById(int id)
    {
        var filme = await _repository.BuscaFilmeAsync(id);
        return filme != null ? Ok(filme) : NotFound("Filme não encontrado!");
    }
}
