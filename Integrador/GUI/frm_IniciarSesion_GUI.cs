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
    public partial class frm_IniciarSesion_GUI : Form
    {
        public frm_IniciarSesion_GUI()
        {
            InitializeComponent();
        }

        private void btn_panel_admin_Click(object sender, EventArgs e)
        {
            GUI.frm_PanelAdmin_GUI v1 = new frm_PanelAdmin_GUI();
            v1.Show();
            this.Hide();
        }

        private void btn_employee_panel_Click(object sender, EventArgs e)
        {
            GUI.frm_PanelEmple_GUI v1 = new frm_PanelEmple_GUI();
            v1.Show();
            this.Hide();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();        
        }

        private void frm_IniciarSesion_GUI_Load(object sender, EventArgs e)
        {

        }
    }
}
