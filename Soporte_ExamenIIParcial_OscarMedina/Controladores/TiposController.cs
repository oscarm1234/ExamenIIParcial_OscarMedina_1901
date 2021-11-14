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
    public class TiposController
    {
        TipoSoporteView vista;
        string operacion = string.Empty;
        TiposDAO tipoDAO = new TiposDAO(); // este codigo se trae arriba para reutilizarlo en todo lps metodos
        Tipos tipo = new Tipos();

        public TiposController(TipoSoporteView view)
        {
            vista = view;
            vista.bttnuevo.Click += new EventHandler(Nuevo);
            vista.bttguardar.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            vista.bttmodificar.Click += new EventHandler(Modificar);
            vista.btteliminar.Click += new EventHandler(Eliminar);
            // vista.cbsoporte.Click += new EventHandler(Agregar);
        }



        //codigo para elimianr un registro
        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.usuariosdatagriedviwe.SelectedRows.Count > 0)
            {
                bool elimino = tipoDAO.EliminarSoporte((int)vista.usuariosdatagriedviwe.CurrentRow.Cells[0].Value);
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

        private void Modificar(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (vista.usuariosdatagriedviwe.SelectedRows.Count > 0)
            {
                vista.txtid.Text = vista.usuariosdatagriedviwe.CurrentRow.Cells["ID"].Value.ToString();
                vista.txtdepto.Text = vista.usuariosdatagriedviwe.CurrentRow.Cells["CATEGORIA_TECNICA"].Value.ToString();
                vista.txtobservacion.Text = vista.usuariosdatagriedviwe.CurrentRow.Cells["DESCRIPCION"].Value.ToString();
                vista.cbsoporte.Text = vista.usuariosdatagriedviwe.CurrentRow.Cells["TIPO_DE_SOPORTE"].Value.ToString();

                //vista.chbadmi.Checked = (bool)vista.usuariosdatagriedviwe.CurrentRow.Cells["ESADMINISTRADOR"].Value;
                HabilitarControles();
            }
        }

        private void Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }
        private void ListarUsuarios()
        {
            vista.usuariosdatagriedviwe.DataSource = tipoDAO.GetSoporte();
        }
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";


        }

        private void Guardar(object sender, EventArgs e)
        {
            if (vista.txtdepto.Text == "")
            {
                vista.errorProvider1.SetError(vista.txtdepto, "Ingrese el Departamento Tecnico de donde requiera soporte");
                vista.txtdepto.Focus();
                return;
            }

            if (vista.cbsoporte.Text == "")
            {
                vista.errorProvider1.SetError(vista.cbsoporte, "Ingrese el tipo de soporte que necesita");
                vista.cbsoporte.Focus();
                return;
            }

            if (vista.txtobservacion.Text == "")
            {
                vista.errorProvider1.SetError(vista.txtobservacion, "Ingrese una observacion, sobre el fallo");
                vista.txtobservacion.Focus();
                return;
            }

            //if (vista. cbsoporte.Text == string.Empty)
            //{
            //    MessageBox.Show("Seleccione el tipo de solicitud");
            //    vista.cbsoporte.Focus();
            //    return;
            //}
            //if (vista.cbsoporte.Text == "Soporte de Hardware")
            //{
            //    return;
            //}

            //if (vista.cbsoporte.Text == "Soporte de Software")
            //{
            //    return;
            //}


            tipo.CategoriaTecnica = vista.txtdepto.Text;
            tipo.TipoDeSoporte = vista.cbsoporte.Text;
            tipo.Descripcion= vista.txtobservacion.Text;


            if (operacion == "Nuevo")
            {
                bool inserto = tipoDAO.InsertarNuevoSoporte(tipo);
                //insertar un nuevo usuario
                if (inserto)
                {
                    MessageBox.Show("Soporte creado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("Error al crear el un nuevo soporte", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //modificar usuario
            else if (operacion == "Modificar")
            {
                tipo.Id = Convert.ToInt32(vista.txtid.Text);
                bool modifico = tipoDAO.ActualizarSOPORTE(tipo);
                if (modifico)
                {

                    MessageBox.Show("El Soporte se ha modificado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("ERROR AL MODIFICAR EL SOPORTE", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //LimpiarControles();
                }

            }

        }


        private void HabilitarControles()
        {
            vista.txtdepto.Enabled = true;
            vista.txtobservacion.Enabled = true;
            vista.cbsoporte.Enabled = true;
            vista.bttguardar.Enabled = true;
            vista.bttcancelar.Enabled = true;
            vista.bttmodificar.Enabled = false;
            vista.bttnuevo.Enabled = true;
        }


        //codigo para limpiar controles
        private void LimpiarControles()
        {
            vista.txtdepto.Clear();
            vista.txtobservacion.Clear();
            vista.cbsoporte.Text = " ";

        }

        //codigo para deshabilitar controles
        private void DesabilitarControles()
        {
            vista.txtdepto.Enabled = false;
            vista.txtobservacion.Enabled = false;
            vista.cbsoporte.Enabled = false;
            vista.bttguardar.Enabled = false;
            vista.bttcancelar.Enabled = false;
            vista.bttmodificar.Enabled = true;
            vista.bttnuevo.Enabled = true;
        }


    }
}
