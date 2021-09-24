using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDasnet.CapaDatos
{
    public abstract class Repositorio
    {
        private readonly string CadenaConexion;
        public Repositorio()
        {
            CadenaConexion = "server = TuServer; database=TuDataBase; integrated security=true";
        }
        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}
