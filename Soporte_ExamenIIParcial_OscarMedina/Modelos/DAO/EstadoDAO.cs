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
    public class EstadoDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();
        public bool InsertarNuevoEstado(Estado estado)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO ESTADO_TICKET ");
                sql.Append(" VALUES (@TicketEstado, @Prioridad, @DisponibleTicket); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                comando.Parameters.Add("@TicketEstado", SqlDbType.NVarChar, 50).Value = estado.TicketEstado;
                comando.Parameters.Add("@Prioridad", SqlDbType.NVarChar, 50).Value = estado.Prioridad;
                comando.Parameters.Add("@DisponibleTicket", SqlDbType.Bit).Value = estado.DisponibleTicket;
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

        public DataTable GetEstado()
        {
            DataTable dta = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM ESTADO_TICKET ");

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

        public bool ActualizarEstado(Estado estado)
        {
            bool actualizo = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE ESTADO_TICKET ");
                sql.Append(" SET TICKET_ESTADO = @TicketEstado, PRIORIDAD = @Prioridad, DISPONIBLE_TICKET = @DisponibleTicket ");
                sql.Append("WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                comando.Parameters.Add("@Id", SqlDbType.Int).Value = estado.Id;
                comando.Parameters.Add("@TicketEstado", SqlDbType.NVarChar, 50).Value = estado.TicketEstado;
                comando.Parameters.Add("@Prioridad", SqlDbType.NVarChar, 50).Value = estado.Prioridad; 
                comando.Parameters.Add("@DisponibleTicket", SqlDbType.Bit).Value = estado.DisponibleTicket;
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

        public bool EliminarEstado(int id)
        {

            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE ESTADO_TICKET ");
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
