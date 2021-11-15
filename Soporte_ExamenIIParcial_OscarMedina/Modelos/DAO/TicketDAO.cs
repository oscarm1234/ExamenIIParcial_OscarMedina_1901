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
    public class TicketDAO:Conexion
    {
        SqlCommand comando = new SqlCommand();




        public bool InsertarNuevoTicket(Ticket ticket)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO TICKET ");
                sql.Append(" VALUES (@IdNumeroTicket, @EstadoTicket, @Asunto); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                comando.Parameters.Add("@IdNumeroTicket", SqlDbType.Int).Value = ticket.IdNumeroTicket;
                comando.Parameters.Add("@EstadoTicket", SqlDbType.NVarChar, 50).Value = ticket.EstadoTicket;
                comando.Parameters.Add("@Asunto", SqlDbType.NVarChar, 50).Value = ticket.Asunto;
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


        public DataTable GetTicket()
        {
            DataTable dta = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM TICKET ");

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

        public bool ActualizarTicket(Ticket ticket)
        {
            bool actualizo = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE TICKET ");
                sql.Append(" SET ID_NUMERO_TICKET = @IdNumeroTicket, ESTADO_TICKET = @EstadoTicket, ASUNTO = @Asunto");
                sql.Append("WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                comando.Parameters.Add("@Id", SqlDbType.Int).Value = ticket.Id;
                comando.Parameters.Add("@IdNumeroTicket", SqlDbType.Int).Value = ticket.IdNumeroTicket;
                comando.Parameters.Add("@EstadoTicket", SqlDbType.NVarChar, 50).Value = ticket.EstadoTicket;
                comando.Parameters.Add("@Asunto", SqlDbType.NVarChar, 50).Value = ticket.Asunto;

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

        public bool EliminarTicket(int id)
        {

            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM TICKET ");
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
