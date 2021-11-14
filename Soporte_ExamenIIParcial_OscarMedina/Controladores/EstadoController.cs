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
   public class EstadoController
    {
        EstadoView vista;
        string operacion = string.Empty;
        EstadoDAO estadoDAO = new EstadoDAO(); // este codigo se trae arriba para reutilizarlo en todo lps metodos
        Estado user = new Estado();

        public EstadoController(EstadoView view)
        {
            vista = view;
            vista.bttnuevo.Click += new EventHandler(Nuevo);
            vista.bttguardar.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            vista.bttmodificar.Click += new EventHandler(Modificar);
            vista.btteliminar.Click += new EventHandler(Eliminar);
        }
        //codigo para elimianr un registro
        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.usuariosdatagriedviwe.SelectedRows.Count > 0)
            {
                bool elimino = estadoDAO.EliminarEstado((int)vista.usuariosdatagriedviwe.CurrentRow.Cells[0].Value);
                if (elimino)
                {
                    MessageBox.Show("El usuario se ha eliminado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //codigo para modificar un usuario
        private void Modificar(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (vista.usuariosdatagriedviwe.SelectedRows.Count > 0)
            {
                vista.txtid.Text = vista.usuariosdatagriedviwe.CurrentRow.Cells["ID"].Value.ToString();
                vista.cbestado.Text = vista.usuariosdatagriedviwe.CurrentRow.Cells["TICKET_ESTADO"].Value.ToString();
                vista.Cbx_Prioridad.Text = vista.usuariosdatagriedviwe.CurrentRow.Cells["PRIORIDAD"].Value.ToString();
                vista.chbdisponible.Checked = (bool)vista.usuariosdatagriedviwe.CurrentRow.Cells["DISPONIBLE_TICKET"].Value;
                HabilitarControles();
            }
        }
        //codigo para acceder al datagriewview y ver los usuarios reflejados en el data
        private void Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }
        private void ListarUsuarios()
        {
            vista.usuariosdatagriedviwe.DataSource = estadoDAO.GetEstado();
        }

        //codigo para agreagr un nuevo usuarios
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }


        //codigo para guardar un usuario
        private void Guardar(object sender, EventArgs e)
        {


            if (vista.cbestado.Text == "")
            {
                vista.errorProvider1.SetError(vista.cbestado, "Seleccione el estado del ticket");
                vista.cbestado.Focus();
                return;
            }
            if(vista.Cbx_Prioridad.Text == "")
            {
                vista.errorProvider1.SetError(vista.cbestado, "Seleccione La Prioridad del ticket");
                vista.Cbx_Prioridad.Focus();
                return;
            }



            user.TicketEstado = vista.cbestado.Text;
            user.Prioridad = vista.Cbx_Prioridad.Text;
            user.DisponibleTicket = vista.chbdisponible.Checked;
            //user.Disponible = vista.txtestado.Text;


            if (operacion == "Nuevo")
            {
                bool inserto = estadoDAO.InsertarNuevoEstado(user);
                //insertar un nuevo usuario
                if (inserto)
                {
                    MessageBox.Show("El Estado se ha creado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("Error al crear el Estado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //modificar usuario
            else if (operacion == "Modificar")
            {
                user.Id = Convert.ToInt32(vista.txtid.Text);
                bool modifico = estadoDAO.ActualizarEstado(user);
                if (modifico)
                {

                    MessageBox.Show("El Estado Del Ticket se ha modificado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("ERROR AL MODIFICAR ESTADO", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //LimpiarControles();
                }

            }

        }


        //codigo para tener los botones desactivados 
        private void HabilitarControles()
        {
            vista.chbdisponible.Enabled = true;
            vista.cbestado.Enabled = true;
            vista.Cbx_Prioridad.Enabled = true;
            vista.bttguardar.Enabled = true;
            vista.bttcancelar.Enabled = true;

            vista.bttmodificar.Enabled = false;
            vista.bttnuevo.Enabled = false;
        }


        //codigo para limpiar controles
        private void LimpiarControles()
        {
            vista.chbdisponible.Checked = false;
            vista.cbestado.Text = " ";
            vista.Cbx_Prioridad.Text = " ";

        }

        //codigo para deshabilitar controles
        private void DesabilitarControles()
        {
            vista.chbdisponible.Enabled = false;
            vista.cbestado.Enabled = false;
            vista.Cbx_Prioridad.Enabled = false;
            vista.bttguardar.Enabled = false;
            vista.bttcancelar.Enabled = false;

            vista.bttmodificar.Enabled = true;
            vista.bttnuevo.Enabled = true;
        }
    }


}
