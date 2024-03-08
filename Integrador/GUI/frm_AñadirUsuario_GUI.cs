using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Integrador.BO;
using Integrador.DAO;
using Integrador.GUI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Integrador.GUI
{
    public partial class frm_AñadirUsuario_GUI : Form
    {
        Usuarios_BO dato = new Usuarios_BO();
        Usuarios_DAO datoDAO = new Usuarios_DAO();
        frm_PanelAdmin_GUI obta = new frm_PanelAdmin_GUI(); 
        
        public frm_AñadirUsuario_GUI()
        {
            InitializeComponent();
        }
        


        private void btn_Regresar_Usuario_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frm_AñadirUsuario_GUI_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_Nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_Apellido1.Text) ||
                string.IsNullOrWhiteSpace(txt_Apellido2.Text) ||
                string.IsNullOrWhiteSpace(txt_Correo.Text) ||
                string.IsNullOrWhiteSpace(txt_User.Text) ||
                string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Por favor, completa todas las casillas.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dato.NOMBRE = txt_Nombre.Text;
                dato.APELLIDO_1 = txt_Apellido1.Text;
                dato.APELLIDO_2 = txt_Apellido2.Text;
                dato.CORREO = txt_Correo.Text;
                dato.USERNAME = txt_User.Text;
                dato.PASSWORDD = txt_password.Text;

                if (datoDAO.Guardar(dato) == true)
                {
                    MessageBox.Show("Datos guardados con exito");
                    obta.MostrarTabla();
                }
                else
                {
                    MessageBox.Show("Error al guardar");
                }


                frm_PanelAdmin_GUI formularioEspecifico = Application.OpenForms["frm_PanelAdmin_GUI"] as frm_PanelAdmin_GUI;

                if (formularioEspecifico != null)
                {
                    formularioEspecifico.MostrarTabla();
                }

                this.Hide();

            }
            
            
        }
        
        private void pnl_UsuariosDatos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
