using ControlFinanzasPersonWasmDotNet8.Server.Data;
using ControlFinanzasPersonWasmDotNet8.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControlFinanzasPersonWasmDotNet8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsuarioController(ApplicationDbContext context)
        {

            _context = context;
        }



        [HttpGet("ConexionServidor")]
        public async Task<ActionResult<string>> GetEjemplo()
        {
            return "Conectado con el servidor";
        }

        [HttpGet("ConexionUsuarios")]
        public async Task<ActionResult<string>> GetConexionUsuarios()
        {
            try
            {
                var respuesta = await _context.Usuarios.ToListAsync();
                return "Conectado la base de datos tabla usuarios";
            }
            catch (Exception ex)
            {
                return "Error de conexion con usuarios";
            }
           
        }


        [HttpPost("NuevoUsuario")]
        public async Task<ActionResult<string>> CreateUsuario(Usuario objeto)
        {

            _context.Usuarios.Add(objeto);
            await _context.SaveChangesAsync();
            return "Guardado con Exito";
        }

        [HttpGet("ObtenerUsuarios")]
        public async Task<ActionResult<List<Usuario>>> GetUsuarios()
        {
            var usuarios = await _context.Usuarios.ToListAsync();
            return usuarios;

        }


    }
}
