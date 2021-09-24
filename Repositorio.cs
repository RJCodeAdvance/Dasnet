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
            CadenaConexion = "server = DESKTOP-S6SO1ER\\SQLEXPRESS; database=WppDasnet; integrated security=true";
        }
        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}
