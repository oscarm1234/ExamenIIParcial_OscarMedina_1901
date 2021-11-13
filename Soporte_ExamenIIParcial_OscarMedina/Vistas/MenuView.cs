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
            UsuarioView users = new UsuarioView();
            users.Show();
        }

        }
    
}
