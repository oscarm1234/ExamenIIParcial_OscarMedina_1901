using Soporte_ExamenIIParcial_OscarMedina.Controladores;
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
    public partial class TipoSoporteView : Form
    {
        public TipoSoporteView()
        {
            InitializeComponent();
            TiposController controller = new TiposController(this);
        }
    }
}
