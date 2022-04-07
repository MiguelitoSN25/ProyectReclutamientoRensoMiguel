using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiRensoMiguel.Mode;

namespace WebApiRensoMiguel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiciosController : ControllerBase
    {
        private readonly FacturasAppContext _context;

        public ServiciosController(FacturasAppContext context)
        {
            _context = context;
        }

        // GET: api/Servicios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Servicio>>> GetServicios()
        {
            try
            {
                return await _context.Servicios.ToListAsync();
            } 

            catch (Exception ex)
            {

                return BadRequest(ex.Message);
        }
        }

        // GET: api/Servicios/5
        [HttpGet("{id}", Name = "GetServicios")]
        public ActionResult  Get(int id)
        {
            try
            {
                var servicio = _context.Servicios.FirstOrDefault(g => g.IdServicio == id);
                return Ok(servicio);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        // PUT: api/Servicios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public ActionResult PutServicios(int id,[FromBody] Servicio services)
        {
            try
            {
                if (services.IdServicio == id)
                {
                    _context.Entry(services).State = EntityState.Modified;
                    _context.SaveChanges();
                    return CreatedAtRoute("GetServicio", new { id = services.IdServicio }, services);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // POST: api/Servicios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public  ActionResult PostServicios([FromBody]Servicio services)
        {
            
            try
            {
                _context.Servicios.Add(services);
                _context.SaveChanges();
                return CreatedAtRoute("GetServicio", new { id = services.IdServicio }, services);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // DELETE: api/Servicios/5
        [HttpDelete("{id}")]
        public IActionResult DeleteServicios(int id)
        {
            try
            {
                var servicios = _context.Servicios.FirstOrDefault(g => g.IdServicio == id);
                if (servicios != null)
                {
                    _context.Servicios.Remove(servicios);
                    _context.SaveChanges();
                        return Ok(id);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        private bool ServicioExists(int id)
        {
            return _context.Servicios.Any(e => e.IdServicio == id);
        }
    }
}
