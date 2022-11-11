using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Negocio.BM.Estudiantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transversal.DT.Estudiantes;

namespace Servicios.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        private IBMEstudiantes _IEstudiantes;
        public EstudiantesController(IBMEstudiantes IEstudiantes)
        {
            _IEstudiantes = IEstudiantes;
        }

        [HttpGet]
        public ActionResult<List<DTEstudiante>> ObtenerEstudiantes()
        {
            List<DTEstudiante> response = new List<DTEstudiante>();
            try
            {
                response = _IEstudiantes.ObtenerEstudiantes();
            }
            catch (Exception ex)
            {
                DTEstudiante est = new DTEstudiante()
                {
                    nombre = ex.Message
                };
                response.Add(est);
                return Ok(response);
            }
            return Ok(response);

        }
    }
}
