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
using static Integrador.GUI.frm_PanelAdmin_GUI;

namespace Integrador.GUI
{
    public partial class frm_EditarUsuario_GUI : Form
    {

        Usuarios_BO dato = new Usuarios_BO();
        Usuarios_DAO datoDAO = new Usuarios_DAO();
        frm_PanelAdmin_GUI obta = new frm_PanelAdmin_GUI();
        public frm_EditarUsuario_GUI()
        {
            InitializeComponent();
        }
        //Constructor para obtener los valores del otro formulario
        public frm_EditarUsuario_GUI(int valorColumna0, string valorColumna1, string valorColumna2, string valorColumna3,
        string valorColumna4, string valorColumna5, string valorColumna6)
        {
            InitializeComponent();
            dato.ID1 = valorColumna0;
            txt_Nombre.Text = valorColumna1;
            txt_Apellido1.Text = valorColumna2;
            txt_Apellido2.Text = valorColumna3;
            txt_Correo.Text = valorColumna4;
            txt_User.Text = valorColumna5;
            txt_password.Text = valorColumna6;
        }
        public frm_EditarUsuario_GUI(frm_PanelAdmin_GUI panelAdminForm)
        {
            InitializeComponent();
            
        }
        private void frm_EditarUsuario_GUI_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {

            // Comprobar si las TextBox tienen contenido
            if (string.IsNullOrWhiteSpace(txt_Nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_Apellido1.Text) ||
                string.IsNullOrWhiteSpace(txt_Apellido2.Text) ||
                string.IsNullOrWhiteSpace(txt_Correo.Text) ||
                string.IsNullOrWhiteSpace(txt_User.Text) ||
                string.IsNullOrWhiteSpace(txt_password.Text))
            {
                // Si las TextBox no tienen contenido
                MessageBox.Show("Por favor, completa todas las casillas.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Si las TextBox tienen contenido
                dato.NOMBRE = txt_Nombre.Text;
                dato.APELLIDO_1 = txt_Apellido1.Text;
                dato.APELLIDO_2 = txt_Apellido2.Text;
                dato.CORREO = txt_Correo.Text;
                dato.USERNAME = txt_User.Text;
                dato.PASSWORDD = txt_password.Text;


                if (datoDAO.Actualizar(dato) == 1)
                {

                    MessageBox.Show("Datos Actualizados");
                    obta.MostrarTabla();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error al Actualizar");
                }
                //Codigo para actualizar la tabla
                frm_PanelAdmin_GUI formularioEspecifico = Application.OpenForms["frm_PanelAdmin_GUI"] as frm_PanelAdmin_GUI;

                if (formularioEspecifico != null)
                {
                    formularioEspecifico.MostrarTabla();
                }
            }
        }

        private void btn_Regresar_Usuario_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
