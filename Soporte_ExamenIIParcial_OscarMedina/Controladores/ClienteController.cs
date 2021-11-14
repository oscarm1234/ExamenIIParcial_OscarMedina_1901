using Soporte_ExamenIIParcial_OscarMedina.Modelos.DAO;
using Soporte_ExamenIIParcial_OscarMedina.Modelos.Entidades;
using Soporte_ExamenIIParcial_OscarMedina.Vistas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soporte_ExamenIIParcial_OscarMedina.Controladores
{
    public class ClienteController
    {
        ClientesViews vista;
        ClienteDAO clienteDAO = new ClienteDAO();
        Cliente cliente = new Cliente();
        string operacion = string.Empty;
        public ClienteController(ClientesViews view)
        {
            vista = view;
            vista.bttnuevo.Click += new EventHandler(Nuevo);
            vista.bttguardar.Click += new EventHandler(Guardar);
            vista.bttimagen.Click += new EventHandler(CargarImagen);
            vista.Load += new EventHandler(Load);
            vista.bttmodificar.Click += new EventHandler(Modificar);
            vista.btteliminar.Click += new EventHandler(Eliminar);

        }

        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.dataGridView1.SelectedRows.Count > 0)
            {
                bool elimino = clienteDAO.EliminarCliente((int)vista.dataGridView1.CurrentRow.Cells[0].Value);
                if (elimino)
                {
                    MessageBox.Show("El cliente se ha eliminado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DeshabilitarControles();
                   
                    ListarClientes();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el cliente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Guardar(object sender, EventArgs e)
        {
            if (vista.txtidentidad.Text == " ")
            {
                vista.errorProvider1.SetError(vista.txtidentidad, "Ingrese su Identidad");
                vista.txtidentidad.Focus();
                return;
            }
            if (vista.txtnomb.Text == " ")
            {
                vista.errorProvider1.SetError(vista.txtnomb, "Ingrese su Nombre");
                vista.txtnomb.Focus();
                return;
            }
            if (vista.txtemail.Text == " ")
            {
                vista.errorProvider1.SetError(vista.txtemail, "Ingrese su Email");
                vista.txtemail.Focus();
                return;
            }
            if (vista.txtdireccion.Text == " ")
            {
                vista.errorProvider1.SetError(vista.txtdireccion, "Ingrese su Direcion");
                vista.txtdireccion.Focus();
                return;
            }

            cliente.Identidad = vista.txtidentidad.Text;
            cliente.Nombre = vista.txtnomb.Text;
            cliente.Email = vista.txtemail.Text;
            cliente.Direccion = vista.txtdireccion.Text;

            if (vista.bttimagen.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                vista.bttimagen.Image.Save(ms, ImageFormat.Jpeg);
                cliente.Foto = ms.GetBuffer();
            }

            if (operacion == "Nuevo")
            {

                bool inserto = clienteDAO.InsertarNuevoCliente(cliente);
                if (inserto)
                {
                    MessageBox.Show("El cliente ha sido insertado correctamente");
                    DeshabilitarControles();
                    LimpiarControles();
                    ListarClientes();
                }
                else
                {
                    MessageBox.Show("El cliente no se pudo insertar");
                }
            }
            else if (operacion == "Modificar")
            {
                cliente.Id = Convert.ToInt32(vista.txtid.Text);
                bool modifico = clienteDAO.ActualizarCliente(cliente);
                if (modifico)
                {
                    MessageBox.Show("El cliente ha sido Modificado correctamente");
                    DeshabilitarControles();
                    LimpiarControles();
                    ListarClientes();
                }
                else
                {
                    MessageBox.Show("Cliente no se modifico corectamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Load(object sender, EventArgs e)
        {
            ListarClientes();
        }
        //cargar clientes
        private void ListarClientes()
        {
            vista.dataGridView1.DataSource = clienteDAO.GetClientes();

        }
        private void CargarImagen(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                vista.pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }
        private void Modificar(object sender, EventArgs e)
        {
            if (vista.dataGridView1.SelectedRows.Count > 0)
            {
                operacion = "Modificar";
                HabilitarControles();
                vista.txtid.Text = vista.dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                vista.txtnomb.Text = vista.dataGridView1.CurrentRow.Cells["NOMBRE"].Value.ToString();
                vista.txtidentidad.Text = vista.dataGridView1.CurrentRow.Cells["IDENTIDAD"].Value.ToString();
                vista.txtemail.Text = vista.dataGridView1.CurrentRow.Cells["EMAIL"].Value.ToString();
                vista.txtdireccion.Text = vista.dataGridView1.CurrentRow.Cells["DIRECCION"].Value.ToString();

            }

        }
        private void Nuevo(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
        }

        private void HabilitarControles()
        {
            vista.txtidentidad.Enabled = true;
            vista.txtnomb.Enabled = true;
            vista.txtemail.Enabled = true;
            vista.txtdireccion.Enabled = true;
            vista.pictureBox1.Enabled = true;
            vista.bttimagen.Enabled = true;
            vista.bttguardar.Enabled = true;
            vista.bttcancelar.Enabled = true;

            vista.bttmodificar.Enabled = false;
            vista.bttnuevo.Enabled = false;


        }


        private void LimpiarControles()
        {
            vista.txtidentidad.Clear();
            vista.txtnomb.Clear();
            vista.txtemail.Clear();
            vista.txtdireccion.Clear();
            vista.pictureBox1.Image = null;
            vista.txtid.Clear();


        }

        private void DeshabilitarControles()
        {
            vista.txtidentidad.Enabled = false;
            vista.txtnomb.Enabled = false;
            vista.txtemail.Enabled = false;
            vista.txtdireccion.Enabled = false;
            vista.pictureBox1.Enabled = false;
            vista.bttimagen.Enabled = false;
            vista.bttguardar.Enabled = false;
            vista.bttcancelar.Enabled = false;

            vista.bttmodificar.Enabled = true;
            vista.bttnuevo.Enabled = true;


        }
    }

   
    
}

