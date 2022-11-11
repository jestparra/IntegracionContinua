using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transversal.DT.Estudiantes;

namespace Negocio.BM.Estudiantes
{
    public interface IBMEstudiantes
    {
        public List<DTEstudiante> ObtenerEstudiantes();
    }
}
