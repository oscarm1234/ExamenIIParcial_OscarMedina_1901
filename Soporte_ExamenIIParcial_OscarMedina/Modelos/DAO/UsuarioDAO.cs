using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Soporte_ExamenIIParcial_OscarMedina.Modelos.Entidades;

namespace Soporte_ExamenIIParcial_OscarMedina.Modelos.DAO
{
    public class UsuarioDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool ValidarUsuario(Usuario user)
        {
            bool valido = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT 1 FROM USUARIO WHERE EMAIL=@Email AND CLAVE =@Clave; ");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = user.Email;
                comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 100).Value = user.Clave;
                valido = Convert.ToBoolean(comando.ExecuteScalar());
            }
            catch (Exception)
            {
            }
            return valido;

        }

        public bool InsertarNuevoUsuario(Usuario user)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO  USUARIO ");
                sql.Append(" VALUES (@Nombre, @Email, @Clave, @EsAdministrador); ");


                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = user.Nombre;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = user.Email;
                comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 100).Value = user.Clave;
                comando.Parameters.Add("@EsAdministrador", SqlDbType.Bit).Value = user.EsAdministrador;
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

        public DataTable GetUsuarios()
        {
            DataTable dtu = new DataTable();

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM USUARIO ");

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
        public bool ActualizarUsuario(Usuario user)
        {
            bool actualizo = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE USUARIO ");
                sql.Append(" SET NOMBRE = @Nombre, EMAIL = @Email, CLAVE = @Clave, ESADMINISTRADOR = @EsAdministrador ");
                sql.Append("WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                comando.Parameters.Add("@Id", SqlDbType.Int).Value = user.Id;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = user.Nombre;
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = user.Email;
                comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 100).Value = user.Clave;
                comando.Parameters.Add("@EsAdministrador", SqlDbType.Bit).Value = user.EsAdministrador;
                comando.ExecuteNonQuery();
                actualizo = true;
                MiConexion.Close();


            }
            catch (Exception)
            {
                actualizo = false;

            }
            return actualizo;
        }
        public bool EliminarUsuario(int id)
        {

            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM USUARIO ");
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