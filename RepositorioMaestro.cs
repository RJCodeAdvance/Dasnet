using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDasnet.CapaDatos
{
    public abstract class RepositorioMaestro:Repositorio
    {
        protected List<SqlParameter> parametros;
        protected void ExecuteNonQuery(string transactSql) //Ejecutar sentencias de texto insert, update, delete con parametros
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.Text;
                    foreach (SqlParameter item in parametros)
                    {
                        comando.Parameters.Add(item);
                    }
                    comando.ExecuteNonQuery();
                    parametros.Clear();
                }
            }
        }
        
        protected void ExecuteNonQuery(string transactSql) //Ejecutar sentencias de texto insert, update, delete etc sin parametros
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                    parametros.Clear();
                }
            }
        }
        
        protected void ExecuteNonQuery(string transactSql) //Ejecutar procedimientos almacenados sin parametros
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.ExecuteNonQuery();
                    parametros.Clear();
                }
            }
        }
        
        protected void ExecuteNonQuery(string transactSql) //Ejecutar procedimientos almacenados con parametros
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.StoredProcedure;
                    foreach (SqlParameter item in parametros)
                    {
                        comando.Parameters.Add(item);
                    }
                    comando.ExecuteNonQuery();
                    parametros.Clear();
                }
            }
        }
        
        protected DataTable ExecuteReader(string transactSql) //Devolver tablas ejecutando consultas de texto con parametros
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.Text;
                    foreach (SqlParameter item in parametros)
                    {
                        comando.Parameters.Add(item);
                    }
                    SqlDataReader lector = comando.ExecuteReader();
                    using (var tabla = new DataTable())
                    {
                        tabla.Load(lector);
                        lector.Dispose();
                        return tabla;
                    }
                }
            }
        }
        
        protected DataTable ExecuteReader(string transactSql) //Devolver tablas ejecutando consultas de texto sin parametros
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.Text;
                    SqlDataReader lector = comando.ExecuteReader();
                    using (var tabla = new DataTable())
                    {
                        tabla.Load(lector);
                        lector.Dispose();
                        return tabla;
                    }
                }
            }
        }
        
        protected DataTable ExecuteReader(string transactSql) //Devolver tablas ejecutando consultas de procedimientos almacenados con parametros
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.StoredProcedures;
                    foreach (SqlParameter item in parametros)
                    {
                        comando.Parameters.Add(item);
                    }
                    SqlDataReader lector = comando.ExecuteReader();
                    using (var tabla = new DataTable())
                    {
                        tabla.Load(lector);
                        lector.Dispose();
                        return tabla;
                    }
                }
            }
        }
        
        protected DataTable ExecuteReader(string transactSql) //Devolver tablas ejecutando procedimientos almacenados sin parametros
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSql;
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataReader lector = comando.ExecuteReader();
                    using (var tabla = new DataTable())
                    {
                        tabla.Load(lector);
                        lector.Dispose();
                        return tabla;
                    }
                }
            }
        }
    }
}
