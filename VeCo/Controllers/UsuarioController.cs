using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VeCo.Data;
using VeCo.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VeCo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private VecoContext _dbContext;
        public UsuarioController(VecoContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<UsuarioController>
        [HttpGet("[action]")]
        public async Task<IActionResult> Get()
        {
            var User = await _dbContext.Usuarios.AsNoTracking().ToListAsync();
            return Ok(User);
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var User = await _dbContext.Usuarios.Where(a => a.Id == id).AsNoTracking().ToListAsync();
            return Ok(User);
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Usuarios usuario)
        {
            try
            {
                await _dbContext.Usuarios.AddAsync(usuario);
                await _dbContext.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        //// PUT api/<UsuarioController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<UsuarioController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
