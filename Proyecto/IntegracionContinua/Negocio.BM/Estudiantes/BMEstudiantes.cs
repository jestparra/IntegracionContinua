using AccesoDatos.DA.General;
using System;
using System.Collections.Generic;
using Transversal.DT.Estudiantes;

namespace Negocio.BM.Estudiantes
{
    public class BMEstudiantes : IBMEstudiantes
    {
        public List<DTEstudiante> ObtenerEstudiantes()
        {
            List<DTEstudiante> response = new List<DTEstudiante>();
            try
            {
                response = new DMGeneral<DTEstudiante>().GetListSQL("dbo.sp_ObtenerEstudiantes", null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }
    }
}
