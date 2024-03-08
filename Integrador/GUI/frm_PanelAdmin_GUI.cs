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
namespace Integrador.GUI
{
    public partial class frm_PanelAdmin_GUI : Form
    {

        Usuarios_BO dato = new Usuarios_BO();
        Usuarios_DAO datoDAO = new Usuarios_DAO();

        //Crea variables para modificar la tabla
        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();
        public frm_PanelAdmin_GUI()
        {
            InitializeComponent();
        }
        

        public void MostrarTabla()
        {
            //Se muestra la tabla
            dt = datoDAO.MostrarUsuario();
            ds.Tables.Add(dt);
            dataGridView1.DataSource = dt;
        }

        private void frm_PanelAdmin_GUI_Load(object sender, EventArgs e)
        {
            MostrarTabla();
            // Cargar los datos de los usuarios en el DataGridView al cargar el formulario
            dataGridView1.DataSource = usuarioDAO.MostrarUsuario();
        }
        public int ObtenerIDUsuarioSeleccionado()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                return Convert.ToInt32(selectedRow.Cells["ID"].Value);
            }
            else
            {
                return -1; // Retorna un valor que indique que no hay ninguna fila seleccionada
            }
        }
        private Usuarios_DAO usuarioDAO = new Usuarios_DAO();


        private void lbl_name_admin_panel_Click(object sender, EventArgs e)
        {

        }

        private void tbl_tp_Compras_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddUser_Admin_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddUser_Admin_Click_1(object sender, EventArgs e)
        {

        }

        

        private void btn_BuscarUsuario_Admin_Click(object sender, EventArgs e)
        {

        }

        private void btn_FiltroBuscarUsuario_Admin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AñadirUsuario_Admin_Click(object sender, EventArgs e)
        {
            frm_AñadirUsuario_GUI v1 = new frm_AñadirUsuario_GUI();
            v1.Show();
        }

        private void btn_AñadirProducto_Admin_Click(object sender, EventArgs e)
        {
            GUI.frm_AñadirProducto_GUI v1 = new frm_AñadirProducto_GUI();
            v1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            GUI.frm_AñadirProveedor_GUI v1 = new frm_AñadirProveedor_GUI();
            v1.Show();
        }

        private void btn_AñadirClientes_Admin_Click(object sender, EventArgs e)
        {
            GUI.frm_AñadirCliente_GUI v1 = new frm_AñadirCliente_GUI();
            v1.Show();
        }

        private void ptb_Cerrar_Admin_panel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_panel_admin_Click(object sender, EventArgs e)
        {
            GUI.frm_PanelEmple_GUI v1 = new frm_PanelEmple_GUI();
            v1.Show();
            this.Hide();
        }

        private void tbl_tp_Usuarios_Click(object sender, EventArgs e)
        {
            
        }

        private void pnl_UsuariosDatos_Paint(object sender, PaintEventArgs e)
        {

        }
        public class Dato
        {
            public int ID1 { get; set; }
            // Otras propiedades según sea necesario
        }
        private void btn_EliminarUsuario_Admin_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtenemos el índice de la fila seleccionada
                int indiceFilaSeleccionada = dataGridView1.SelectedRows[0].Index;

                // Obtenemos el valor del ID en la primera columna donde se encuentra
                int idSeleccionado = Convert.ToInt32(dataGridView1.Rows[indiceFilaSeleccionada].Cells[0].Value);
                
                dato.ID1 = idSeleccionado;
                if (datoDAO.Eliminar(dato) == 1)
                {
                    MostrarTabla();
                    MessageBox.Show("Datos Eliminados");
                }
                else
                {
                    MessageBox.Show("Error al Eliminar");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }

            //Codigo antiguo

            /*
             Dato datoA = new Dato();
             dato.ID1 = int.Parse(txt_search_admin.Text);
            if (datoDAO.Eliminar(dato) == 1)
            {
                MostrarTabla();
                MessageBox.Show("Datos Eliminado");
            }
            else
            {
                MessageBox.Show("Error al Eliminar");
            }
             */

        }

        private void btn_EditarUsuario_Admin_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)//Se verifica que se tenga seleccionada la fila
            {
                // Obtiene la primera fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                // Obtiene el valor de la columna "ID" y lo convierte a un entero utilizando 
                //Convert.ToInt32() para convertir el valor de la celda a un entero
                int valorColumna0 = Convert.ToInt32(selectedRow.Cells["ID"].Value);
                // Obtiene los valores de las demás columnas y los convierte a string
                string valorColumna1 = selectedRow.Cells["Nombre"].Value.ToString();
                string valorColumna2 = selectedRow.Cells["Apellido_1"].Value.ToString();
                string valorColumna3 = selectedRow.Cells["Apellido_2"].Value.ToString();
                string valorColumna4 = selectedRow.Cells["correo"].Value.ToString();
                string valorColumna5 = selectedRow.Cells["username"].Value.ToString();
                string valorColumna6 = selectedRow.Cells["passwordd"].Value.ToString();
                frm_EditarUsuario_GUI v1 = new frm_EditarUsuario_GUI(valorColumna0,valorColumna1, valorColumna2, valorColumna3,
                    valorColumna4,valorColumna5,valorColumna6);
                v1.Show();
            }
            else//en caso de que no este seleccionada se le envia un mensaje
            {
                MessageBox.Show("Por favor, selecciona una fila antes de editar el usuario.");
            }
        }

        private void txt_search_admin_TextChanged(object sender, EventArgs e)
        {

            //Se declaran dos variables para poder buscar ya sea por ID o Nombre
            string Nombre = string.Concat("[", dt.Columns[1].ColumnName, "]");
            string ID = string.Concat("[", dt.Columns[0].ColumnName, "]");

            dt.DefaultView.Sort = Nombre;
            DataView vista = dt.DefaultView;
            vista.RowFilter = string.Empty;

            if (txt_search_admin.Text != string.Empty)
            {
                //Aqui se hizo un cambio para que aplicar dos condicones para filtrar datos
                vista.RowFilter = Nombre + " LIKE '%" + txt_search_admin.Text + "%' OR Convert(" + ID + ", 'System.String') LIKE '%" + txt_search_admin.Text + "%'";
                dataGridView1.DataSource = vista;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Habilitar el botón solo si se selecciona una fila completa para actualizar
            btn_EditarUsuario_Admin.Enabled = dataGridView1.SelectedRows.Count == 1;
        }

        private void btn_Editar_Producto_Click(object sender, EventArgs e)
        {
            frm_EditarProducto_GUI v1 = new frm_EditarProducto_GUI();
            v1.Show();
        }

        private void btn_Editar_Proveedor_Click(object sender, EventArgs e)
        {
            frm_EditarProveedor_GUI v1 = new frm_EditarProveedor_GUI();
            v1.Show();
        }

        private void btn_Editar_Cliente_Click(object sender, EventArgs e)
        {
            frm_EditarCliente_GUI v1 = new frm_EditarCliente_GUI();
            v1.Show();
        }
    }
}
