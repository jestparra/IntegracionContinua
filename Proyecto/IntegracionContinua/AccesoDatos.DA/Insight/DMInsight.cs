using Insight.Database;
using Ninject;
using System;
using System.Data.SqlClient;

namespace AccesoDatos.DA.Insight
{
    class DMInsight
    {
        [Inject]
        public static SqlConnection DefaultCnn()
        {
            SqlInsightDbProvider.RegisterProvider();
            return new SqlConnection(Environment.GetEnvironmentVariable("stringConnectionSQL"));
        }
    }
}
