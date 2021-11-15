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
        TipoSoporteView tsoporte;
        EstadoView estadot;
        TicketView tickett;

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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (tsoporte == null)
            {
                tsoporte = new TipoSoporteView();
                tsoporte.MdiParent = this;
                tsoporte.FormClosed += Soporte_FormClosed;
                tsoporte.Show();
            }
            else
            {
                tsoporte.Activate();
            }
        }
        private void Soporte_FormClosed(object sender, FormClosedEventArgs e)
        {
            tsoporte = null;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (estadot == null)
            {
                estadot = new EstadoView();
                estadot.MdiParent = this;
                estadot.FormClosed += Estado_FormClosed;
                estadot.Show();
            }
            else
            {
                estadot.Activate();
            }
        }
        private void Estado_FormClosed(object sender, FormClosedEventArgs e)
        {
            estadot = null;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (tickett == null)
            {
                tickett = new TicketView();
                tickett.MdiParent = this;
                tickett.FormClosed += Ticket_FormClosed;
                tickett.Show();
            }
            else
            {
                tickett.Activate();
            }
        }
        private void Ticket_FormClosed(object sender, FormClosedEventArgs e)
        {
            tickett = null;
        }
    }

}
