using Empreitta.Data;
using Empreitta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class ProfissionaisController : ControllerBase
{
    private readonly EmpreittaDbContext _context;

    public ProfissionaisController(EmpreittaDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> Post(Profissional profissional)
    {
        _context.Profissionais.Add(profissional);
        await _context.SaveChangesAsync();
        return Ok(profissional);
    }

    [HttpGet]
    public async Task<IEnumerable<Profissional>> Get()
    {
        return await _context.Profissionais.ToListAsync();
    }
}
