using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;

namespace Negocio
{
  public  class Paises
    {
        public Paises()
        {
            Conexion.SqlStrConection = "Data source=localhost;Initial Catalog=CursoCsharp;Integrated Security=true";
        }

        public bool Guardar(Paisdb opais )
        {
            bool resultado = false; 
            using (var conn=Conexion.GetConnection())
            {
                conn.Open();
                using (var comando=new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.CommandText = "InsertarPaises";
                    comando.Parameters.AddWithValue("@IdPais", opais.Id);
                    comando.Parameters.AddWithValue("@Pais", opais.Pais);
                    int result = comando.ExecuteNonQuery();
                    resultado = result > 0;
                }
            }

            return resultado;
        }
        public Paisdb GuardarPais(Paisdb opais)
        {
            Paisdb resultado = null;
            using (var conn = Conexion.GetConnection())
            {
                conn.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = "insert into Paises(Pais) values(@Pais)";
                    SqlParameter Param = new SqlParameter()
                    {
                        ParameterName = "@Pais",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 150,
                        SqlValue = opais.Pais
                    };
                    comando.Parameters.Add(Param);
                    comando.ExecuteNonQuery();
                    using (var Comm =new SqlCommand())
                    {
                        Comm.Connection = conn;
                        Comm.CommandType = CommandType.Text;
                        Comm.CommandText = "select @@IDENTITY";
                        SqlDataAdapter sqlData = new SqlDataAdapter(Comm);
                        DataTable Odatos = new DataTable();
                        sqlData.Fill(Odatos);

                        if (Odatos !=null && Odatos.Rows.Count>0)
                        {
                            resultado = new Paisdb()
                            {
                                 Id=int.Parse(Odatos.Rows[0][0].ToString()),
                                  Pais=opais.Pais
                            };
                        }
                    }
                }
            }

            return resultado;
        }

       //Como definir una Funcion o Metodo
       // 1 Nivel de Acceso o Visibilidad
       // Tener Claro lo que quiero hacer
       // 2  Tipo de Dato a Devolver en caso de ser una Funcion
       // 3 Nombre de la Funcion
       // Opcional si recibira parametros

        public List<Paisdb> ListadoPaises()
        {
            List<Paisdb> resultado = new List<Paisdb>();
            using (var conn = Conexion.GetConnection())
            {
                conn.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = "SELECT * FROM Paises ";
                        SqlDataAdapter sqlData = new SqlDataAdapter(comando);
                        DataTable Odatos = new DataTable();
                        sqlData.Fill(Odatos);

                        if (Odatos != null && Odatos.Rows.Count > 0)
                        {
                        foreach (DataRow item in Odatos.Rows)
                        {
                            resultado.Add(new Paisdb()
                            {
                                Id = int.Parse(item["Id"].ToString()),
                                Pais = item["Pais"].ToString()
                            });
                        }
                            
                        }
                   }
                }
            

            return resultado;
        }

    }
}
