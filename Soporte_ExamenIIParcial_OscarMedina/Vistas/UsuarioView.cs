using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soporte_ExamenIIParcial_OscarMedina.Controladores;

namespace Soporte_ExamenIIParcial_OscarMedina.Vistas
{
    public partial class UsuarioView : Form
    {
        public UsuarioView()
        {
            InitializeComponent();
            UsuarioController controller = new UsuarioController(this);

        }
    }
}
