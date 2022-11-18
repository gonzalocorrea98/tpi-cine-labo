using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Cine.Acceso
{
    public abstract class Acceso
    {
        private readonly string conexion;

        public Acceso()
        {
            conexion = Properties.Settings.Default.CINE_CORDOBAConnectionString;
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(conexion);
        }


    }
}
