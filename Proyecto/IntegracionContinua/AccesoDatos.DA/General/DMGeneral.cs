using Insight.Database;
using System;
using System.Collections.Generic;

namespace AccesoDatos.DA.General
{
    public class DMGeneral<T>
    {
        public List<T> GetListSQL(string sp, Object entity)
        {
            List<T> response =  Insight.DMInsight.DefaultCnn().Query<T>(sp, entity, commandTimeout: 3000) as List<T>;
            return response;
        }
    }
}
