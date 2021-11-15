using Soporte_ExamenIIParcial_OscarMedina.Modelos.DAO;
using Soporte_ExamenIIParcial_OscarMedina.Modelos.Entidades;
using Soporte_ExamenIIParcial_OscarMedina.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soporte_ExamenIIParcial_OscarMedina.Controladores
{
    public class TicketController
    {
        TicketView vista;
        string operacion = string.Empty;
        TicketDAO ticketDAO = new TicketDAO(); 
        Ticket ticket = new Ticket();

        public TicketController(TicketView view)
        {
            vista = view;
            vista.bttnuevo.Click += new EventHandler(Nuevo);
            vista.bttguardar.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            vista.bttmodificar.Click += new EventHandler(Modificar);
            vista.btteliminar.Click += new EventHandler(Eliminar);
            
        }



        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.usuariosdatagriedviwe.SelectedRows.Count > 0)
            {
                bool elimino = ticketDAO.EliminarTicket((int)vista.usuariosdatagriedviwe.CurrentRow.Cells[0].Value);
                if (elimino)
                {
                    MessageBox.Show("El Ticket ya ha sido eliminado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el ticket", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Modificar(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (vista.usuariosdatagriedviwe.SelectedRows.Count > 0)
            {
                vista.txtid.Text = vista.usuariosdatagriedviwe.CurrentRow.Cells["ID"].Value.ToString();
                vista.txtnum.Text = vista.usuariosdatagriedviwe.CurrentRow.Cells["ID_NUMERO_TICKET"].Value.ToString();
                vista.cbticket.Text = vista.usuariosdatagriedviwe.CurrentRow.Cells["ESTADO_TICKET"].Value.ToString();
                vista.txtdescri.Text = vista.usuariosdatagriedviwe.CurrentRow.Cells["ASUNTO"].Value.ToString();
                HabilitarControles();
            }
        }

        private void Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }
        private void ListarUsuarios()
        {
            vista.usuariosdatagriedviwe.DataSource = ticketDAO.GetTicket();
        }

        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";


        }




        private void Guardar(object sender, EventArgs e)
        {

            if (vista.txtdescri.Text == "")
            {
                vista.errorProvider1.SetError(vista.txtdescri, "Ingrese la descripcion con relacion al ticket");
                vista.txtdescri.Focus();
                return;
            }

            if (vista.cbticket.Text == "")
            {
                vista.errorProvider1.SetError(vista.cbticket, "Por favor, seleccione el estado del ticket");
                vista.cbticket.Focus();
                return;
            }


            ticket.IdNumeroTicket = vista.txtnum.Text;
            ticket.Asunto = vista.txtdescri.Text;
            ticket.EstadoTicket = vista.cbticket.Text;

            if (operacion == "Nuevo")
            {
                bool inserto = ticketDAO.InsertarNuevoTicket(ticket);
                //insertar un nuevo usuario
                if (inserto)
                {
                    MessageBox.Show("El Ticket se ha creado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("Error al crear el Ticket", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //modificar usuario
            else if (operacion == "Modificar")
            {
                ticket.Id = Convert.ToInt32(vista.txtid.Text);
                bool modifico = ticketDAO.ActualizarTicket(ticket);
                if (modifico)
                {

                    MessageBox.Show("El Ticket se ha modificado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("Error al modificar el Ticket", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //LimpiarControles();
                }

            }

        }

        private void HabilitarControles()
        {
            vista.txtnum.Enabled = true;
            vista.txtdescri.Enabled = true;
            vista.cbticket.Enabled = true;
            vista.bttguardar.Enabled = true;
            vista.bttcancelar.Enabled = true;
            vista.bttmodificar.Enabled = false;
            vista.bttnuevo.Enabled = false;
        }


        //codigo para limpiar controles
        private void LimpiarControles()
        {
            vista.txtnum.Clear();
            vista.txtdescri.Clear();
            vista.cbticket.Text = "";

        }

        //codigo para deshabilitar controles
        private void DesabilitarControles()
        {
            vista.txtnum.Enabled = false;
            vista.txtdescri.Enabled = false;
            vista.cbticket.Enabled = false;
            vista.bttguardar.Enabled = false;
            vista.bttcancelar.Enabled = false;
            vista.bttmodificar.Enabled = true;
            vista.bttnuevo.Enabled = true;
        }

    }
}
