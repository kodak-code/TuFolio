using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL.Servicios.Contrato;
using DTO;
using TuFolioAPI.Utilidad;

namespace TuFolioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly IRolService _rolServicio;

        public RolController(IRolService rolServicio)
        {
            _rolServicio = rolServicio;
        }

        [HttpGet]
        [Route("Lista")]
        public async Task<IActionResult> Lista()
        {
            var respuesta = new Response<List<RolDTO>>();

            try
            {
                respuesta.Estado = true;
                respuesta.Valor = await _rolServicio.Lista();
            }
            catch (Exception ex)
            {
                respuesta.Estado = false;
                respuesta.Mensaje = ex.Message;
                throw;
            }

            return Ok(respuesta);
        }
    }
}
