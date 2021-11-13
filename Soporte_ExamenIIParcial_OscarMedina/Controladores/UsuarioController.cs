using Soporte_ExamenIIParcial_OscarMedina.Modelos.DAO;
using Soporte_ExamenIIParcial_OscarMedina.Modelos.Entidades;
using Soporte_ExamenIIParcial_OscarMedina.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soporte_ExamenIIParcial_OscarMedina.Controladores
{
 
   public class UsuarioController
    {
        UsuarioView vista;
        string operacion = string.Empty;

        public UsuarioController(UsuarioView view)
        {
            vista = view;
            vista.bttnuevo.Click += new EventHandler(Nuevo);
            vista.bttguardar.Click += new EventHandler(Guardar);
        }
        
        private void Nuevo (object sender , EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }
        private void Guardar(object sender, EventArgs e)
        {
            if (vista.txtnomb.Text == "")
            {
                vista.errorProvider1.SetError(vista.txtnomb, "Ingrese Un Nombre ");
                vista.txtnomb.Focus();
                return;
            }
                if (vista.txtemail.Text == "")
                {
                    vista.errorProvider1.SetError(vista.txtemail, "Ingrese el email del usuario");
                    vista.txtemail.Focus();
                    return;
                }

                if (vista.txtclave.Text == "")
                {
                    vista.errorProvider1.SetError(vista.txtclave, "Ingrese la clave correcta");
                    vista.txtclave.Focus();
                    return;
                }
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            Usuario user = new Usuario();

            user.Nombre = vista.txtnomb.Text;
            user.Email = vista.txtemail.Text;
            user.Clave = vista.txtclave.Text;
            user.EsAdministrador = vista.chbadmi.Checked;
            
            if (operacion == "Nuevo")
            {
                bool inserto = usuarioDAO.InsertarNuevoUsuario(user);
                LimpiarControles();
                DesabilitarControles();
            }
            

            
        }
        private void HabilitarControles()
        {
            vista.txtnomb.Enabled = true;
            vista.txtemail.Enabled = true;
            vista.txtclave.Enabled = true;
            vista.chbadmi.Enabled = true;
            vista.bttguardar.Enabled = true;
            vista.bttcancelar.Enabled = true;
            vista.bttmodificar.Enabled = false;
            vista.bttnuevo.Enabled = false;
        }
        private void LimpiarControles()
        {
            vista.txtnomb.Clear();
            vista.txtemail.Clear();
            vista.txtclave.Clear();
            vista.chbadmi.Checked = false;
        }
        private void DesabilitarControles()
        {
            vista.txtnomb.Enabled = false;
            vista.txtemail.Enabled = false;
            vista.txtclave.Enabled = false;
            vista.chbadmi.Enabled = false;
            vista.bttguardar.Enabled = false;
            vista.bttcancelar.Enabled = false;
            vista.bttmodificar.Enabled = true;
            vista.bttnuevo.Enabled = true;
        }
    }
}
