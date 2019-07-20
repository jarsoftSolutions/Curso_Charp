using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Negocio
{
   public class MainViewModel
    {
         

        public MainViewModel()
        {
            Conexion.SqlStrConection = "Data source=localhost;Initial Catalog=CursoCsharp;Integrated Security=true";
        }
        public bool AbrirConexion()
        {
             
            var Conn = Conexion.GetConnection();
            Conn.Open();

            return Conn.State == ConnectionState.Open;

        }
    }
}
