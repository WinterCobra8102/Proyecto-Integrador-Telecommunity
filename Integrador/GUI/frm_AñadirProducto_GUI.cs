using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador.GUI
{
    public partial class frm_AñadirProducto_GUI : Form
    {
        public frm_AñadirProducto_GUI()
        {
            InitializeComponent();
        }

        private void btn_Regresar_Producto_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
