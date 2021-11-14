using Soporte_ExamenIIParcial_OscarMedina.Modelos.Entidades;
using Soporte_ExamenIIParcial_OscarMedina.Vistas;
using Soporte_ExamenIIParcial_OscarMedina.Modelos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Soporte_ExamenIIParcial_OscarMedina.Modelos.DAO
{
    public class TiposDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();
        public bool InsertarNuevoSoporte(Tipos tipo)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO TIPO_SOPORTE ");
                sql.Append(" VALUES (@CategoriaTecnica, @TipoDeSoporte, @Descripcion); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                comando.Parameters.Add("@CategoriaTecnica", SqlDbType.NVarChar, 50).Value = tipo.CategoriaTecnica;
                comando.Parameters.Add("@TipoDeSoporte", SqlDbType.NVarChar, 50).Value = tipo.TipoDeSoporte;
                comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 200).Value = tipo.Descripcion;
                comando.ExecuteNonQuery();
                inserto = true;
                MiConexion.Close();


            }
            catch (Exception ex)
            {
                inserto = false;
            }
            return inserto;
        }

        public DataTable GetSoporte()
        {
            DataTable dta = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM TIPO_SOPORTE ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                SqlDataReader dr = comando.ExecuteReader();
                dta.Load(dr);
                MiConexion.Close();
            }
            catch (Exception)
            {
            }
            return dta;
        }

        public bool ActualizarSOPORTE(Tipos tipo)
        {
            bool actualizo = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE TIPO_SOPORTE ");
                sql.Append(" SET CATEGORIA_TECNICA = @CategoriaTecnica, TIPO_DE_SOPORTE = @TipoDeSoporte, DESCRIPCION = @Descripcion");
                sql.Append("WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                comando.Parameters.Add("@Id", SqlDbType.Int).Value = tipo.Id;
                comando.Parameters.Add("@CategoriaTecnica", SqlDbType.NVarChar, 50).Value = tipo.CategoriaTecnica;
                comando.Parameters.Add("@TipoDeSoporte", SqlDbType.NVarChar, 50).Value = tipo.TipoDeSoporte;
                comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 200).Value = tipo.Descripcion;
                comando.ExecuteNonQuery();
                actualizo = true;
                MiConexion.Close();
            }
            catch (Exception ex)
            {
                actualizo = false;

            }
            return actualizo;

        }

        public bool EliminarSoporte(int id)
        {

            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM TIPO_SOPORTE ");
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
