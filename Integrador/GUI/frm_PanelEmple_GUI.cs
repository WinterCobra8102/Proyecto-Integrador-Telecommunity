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
    public partial class frm_PanelEmple_GUI : Form
    {
        public frm_PanelEmple_GUI()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }


        private void btn_AñadirProducto_Empleado_Click(object sender, EventArgs e)
        {
            GUI.frm_AñadirProducto_GUI v1 = new frm_AñadirProducto_GUI();
            v1.Show();
            
        }

        private void btn_AñadirCliente_Empleado_Click(object sender, EventArgs e)
        {
            GUI.frm_AñadirCliente_GUI v1 = new frm_AñadirCliente_GUI();
            v1.Show();
            
        }

        private void btn_CancelarVenta_Empleado_Click(object sender, EventArgs e)
        {
            GUI.frm_CancelarVenta_GUI v1 = new frm_CancelarVenta_GUI();
            v1.Show();
            
        }

        private void frm_PanelEmple_GUI_Load(object sender, EventArgs e)
        {

        }

        private void ptb_Cerrar_Emple_panel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_panel_admin_Click(object sender, EventArgs e)
        {
            GUI.frm_PanelAdmin_GUI v1 = new frm_PanelAdmin_GUI();
            v1.Show();
            this.Hide();
        }

        private void btn_EditarProducto_Emple_Click(object sender, EventArgs e)
        {
            frm_EditarProducto_GUI v1 = new frm_EditarProducto_GUI();
            v1.Show();
        }

        private void btn_EditarCliente_Emple_Click(object sender, EventArgs e)
        {
            frm_EditarCliente_GUI v1 = new frm_EditarCliente_GUI();
            v1.Show();
        }
    }
}
