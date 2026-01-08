using BLL.Servicios.Contrato;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TuFolioAPI.Utilidad;

namespace TuFolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioServicio;

        public UsuarioController(IUsuarioService usuarioServicio)
        {
            _usuarioServicio = usuarioServicio;
        }

        [HttpGet]
        [Route("Lista")]
        public async Task<IActionResult> Lista()
        {
            var respuesta = new Response<List<UsuarioDTO>>();

            try
            {
                respuesta.Estado = true;
                respuesta.Valor = await _usuarioServicio.Listar();
            }
            catch (Exception ex)
            {
                respuesta.Estado = false;
                respuesta.Mensaje = ex.Message;
                throw;
            }

            return Ok(respuesta);
        }

        [HttpPost]
        [Route("Crear")]
        public async Task<IActionResult> Crear([FromBody] UsuarioDTO usuario)
        {
            var respuesta = new Response<UsuarioDTO>();

            try
            {
                respuesta.Estado = true;
                respuesta.Valor = await _usuarioServicio.Crear(usuario);
            }
            catch (Exception ex)
            {
                respuesta.Estado = false;
                respuesta.Mensaje = ex.Message;
                throw;
            }

            return Ok(respuesta);
        }

        [HttpPut]
        [Route("Editar")]
        public async Task<IActionResult> Editar([FromBody] UsuarioDTO usuario)
        {
            var respuesta = new Response<bool>();

            try
            {
                respuesta.Estado= true;
                respuesta.Valor = await _usuarioServicio.Editar(usuario);
            }
            catch (Exception ex)
            {
                respuesta.Estado = false;
                respuesta.Mensaje = ex.Message;
                throw;
            }

            return Ok(respuesta);
        }

        [HttpPut]
        [Route("Desactivar/{id:int}")]
        public async Task<IActionResult> Desactivar(int id)
        {
            var respuesta = new Response<bool>();

            try
            {
                respuesta.Estado = true;
                respuesta.Valor = await _usuarioServicio.Desactivar(id);
            }
            catch (Exception ex)
            {
                respuesta.Valor= false;
                respuesta.Mensaje = ex.Message;
                throw;
            }

            return Ok(respuesta);
        }
    }
}
