using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soporte_ExamenIIParcial_OscarMedina.Vistas
{
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
        }
        UsuarioView users;
        ClientesViews clientes;

        private void MenuView_Load(object sender, EventArgs e)
        {

        }

        private void RibbonPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTabItem5_Click(object sender, EventArgs e)
        {

        }

        private void UsuariostoolStripButton_Click(object sender, EventArgs e)
        {
           if (users == null)
            {
                users = new UsuarioView();
                users.MdiParent = this;
                users.FormClosed += Users_FormClosed;
                users.Show();
            } 
           else
            {
                users.Activate();
            }
            
        }
        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            users = null;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (clientes == null)
            {
                clientes = new ClientesViews();
                clientes.MdiParent = this;
                clientes.FormClosed += Clientes_FormClosed;
                clientes.Show();
            }
            else
            {
                clientes.Activate();
            }
        }

        private void Clientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            clientes = null;
        }
    }

}
