using Soporte_ExamenIIParcial_OscarMedina.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte_ExamenIIParcial_OscarMedina.Modelos.DAO
{
  public class ClienteDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();


        public bool InsertarNuevoCliente(Cliente cliente)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO  CLIENTE ");
                sql.Append(" VALUES (@Identidad, @Nombre , @Email, @Direccion, @Foto); ");


                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                comando.Parameters.Add("@Identidad", SqlDbType.NVarChar, 20).Value = cliente.Identidad;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = cliente.Nombre;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = cliente.Email;
                comando.Parameters.Add("@Direccion", SqlDbType.NVarChar,50).Value = cliente.Direccion;
                comando.Parameters.Add("@Foto", SqlDbType.Image).Value = cliente.Foto;
                comando.ExecuteNonQuery();
                inserto = true;
                MiConexion.Close();
                return true;
            }
            catch (Exception)
            {
                inserto = false;

            }
            return inserto;
        }

        public DataTable GetClientes()
        {
            DataTable dtu = new DataTable();

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM CLIENTE ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                SqlDataReader dr = comando.ExecuteReader();
                dtu.Load(dr);
                MiConexion.Close();
            }
            catch (Exception)
            {
            }
            return dtu;
        }
        public bool ActualizarCliente(Cliente cliente)
        {
            bool actualizo = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE CLIENTE ");
                sql.Append(" SET IDENTIDAD =@Identidad ,NOMBRE=@Nombre, EMAIL = @Email, DIRECCION = @Direccion, FOTO = @Foto ");
                sql.Append("WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                comando.Parameters.Add("@Id", SqlDbType.Int).Value = cliente.Id;
                comando.Parameters.Add("@Identidad", SqlDbType.NVarChar, 20).Value = cliente.Identidad;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = cliente.Nombre;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = cliente.Email;
                comando.Parameters.Add("@Direcion", SqlDbType.NVarChar, 50).Value = cliente.Direccion;
                comando.Parameters.Add("@Foto", SqlDbType.Image).Value = cliente.Foto;
                comando.ExecuteNonQuery();


            }
            catch (Exception)
            {
                actualizo = false;

            }
            return actualizo;
        }
        public bool EliminarCliente(int id)
        {

            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM CLIENTE");
                sql.Append("WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                comando.ExecuteNonQuery();
                elimino = true;
                MiConexion.Close();


            }
            catch (Exception)
            {
                elimino = false;

            }
            return elimino;

        }
    }
}
