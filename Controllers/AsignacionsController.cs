using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ColegioSolution.Models;
using ColegioSolution.Contexts;

[Route("api/[controller]")]
[ApiController]
public class AsignacionsController : ControllerBase
{
    private readonly DbContextApp _context;
    public AsignacionsController(DbContextApp context)
    {
        _context = context;
    }

    // GET: api/Asignacion
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Asignacion>>> GetAsignacion()
    {
        return await _context.Asignaciones.ToListAsync();
    }

    // GET: api/Asignacion/5
    [HttpGet("{asignacionid}")]
    public async Task<ActionResult<Asignacion>> GetAsignacion(int asignacionid)
    {
        var asignacion = await _context.Asignaciones.FindAsync(asignacionid);

        if (asignacion == null)
        {
            return NotFound();
        }

        return asignacion;
    }

    // PUT: api/Asignacion/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{asignacionid}")]
    public async Task<IActionResult> PutAsignacion(int? asignacionid, Asignacion asignacion)
    {
        if (asignacionid != asignacion.AsignacionId)
        {
            return BadRequest();
        }

        _context.Entry(asignacion).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!AsignacionExists(asignacionid))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/Asignacion
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Asignacion>> PostAsignacion(Asignacion asignacion)
    {
        _context.Asignaciones.Add(asignacion);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetAsignacion", new { asignacionid = asignacion.AsignacionId }, asignacion);
    }

    // DELETE: api/Asignacion/5
    [HttpDelete("{asignacionid}")]
    public async Task<IActionResult> DeleteAsignacion(int? asignacionid)
    {
        var asignacion = await _context.Asignaciones.FindAsync(asignacionid);
        if (asignacion == null)
        {
            return NotFound();
        }

        _context.Asignaciones.Remove(asignacion);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool AsignacionExists(int? asignacionid)
    {
        return _context.Asignaciones.Any(e => e.AsignacionId == asignacionid);
    }
}
