using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class FilmeController : ControllerBase
{
    private FilmeContext _context;
    private IMapper _mapper;

    public FilmeController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionaFilme([FromBody] CreateFilmeDto filmeDto)
    {
        Filme filme = _mapper.Map<Filme>(filmeDto);

        _context.Filmes.Add(filme);
        _context.SaveChanges();

        return CreatedAtAction
            (
                nameof(RecuperaFilmePorId), 
                new {id = filme.Id},
                filme
            );
        
    }

    [HttpGet("search")]
    public IEnumerable<ReadFilmeDto> RecuperaFilmes
        (
        [FromQuery] int skip = 0, 
        [FromQuery] int take = 10
        )
    {
        return _mapper.Map<List<ReadFilmeDto>>(_context.Filmes.Skip(skip).Take(take));
    }

    [HttpGet("searchID/{id}")]
    public IActionResult RecuperaFilmePorId(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);

        if (filme == null) return NotFound();

        var filmeDto = _mapper.Map<ReadFilmeDto>(filme);

        return Ok(filmeDto);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDto filmeDto)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);

        if(filme == null)
        {
            return NotFound();
        }

        _mapper.Map(filmeDto, filme);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaFilme(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);

        if (filme == null) return NotFound();

        _context.Remove(filme);
        _context.SaveChanges();

        return NoContent();
    }
}
