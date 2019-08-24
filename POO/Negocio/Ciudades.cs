using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    using System.Data.SqlClient;
    using System.Data.Sql;
    using Entidades;
  public  class Ciudades
    {
        public Ciudades()
        {

        }
        public bool Insertar(Ciudad ciudaddb)
        {
            bool result=false;
            using (SqlConnection conn=Conexion.GetConnection())
            {
                conn.Open();
                using (SqlCommand comando=new SqlCommand())
                {
                    //Conexion por la que se interactua a la BD
                    comando.Connection = conn;
                    //Tipo de Accion a Ejecutar
                    //Puede ser StoredProcedure cuando sea uno
                    //OText cuando sea SQL Directo
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    //Codigo SQL a Ejecutar
                    comando.CommandText = "InsertarCiudad";
                    //Pasar Paramentros que Recibe el Procedure InsertarCiudad
                    //@Id INT,@Idpais INT,@ciudad varchar(100)
                    comando.Parameters.AddWithValue("@Id", ciudaddb.Id);
                    comando.Parameters.AddWithValue("@Idpais", ciudaddb.IdPais);
                    comando.Parameters.AddWithValue("@ciudad", ciudaddb.ciudad);
                    //Ejecutamos la Instrucion a la Base de datos 
                    result = comando.ExecuteNonQuery() > 0;

                }
            }
            return result;
        }

    }
}
