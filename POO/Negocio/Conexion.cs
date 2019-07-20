using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Negocio
{
    public static class Conexion
    {
        private static SqlConnection sqlConnection;

        /// <summary>
        /// String de conexion a la Base de datos
        /// </summary>
        public static string SqlStrConection { get; set; }

        public static SqlConnection GetConnection()
        {
            if (sqlConnection ==null)
            {
                sqlConnection = new SqlConnection(SqlStrConection);            
            }
            return sqlConnection;
        }
    }
}
