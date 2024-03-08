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
    public partial class frm_CancelarVenta_GUI : Form
    {
        public frm_CancelarVenta_GUI()
        {
            InitializeComponent();
        }

        private void btn_Regresar_Venta_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
