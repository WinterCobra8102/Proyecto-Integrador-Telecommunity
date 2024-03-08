using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Integrador.DAO;
using Integrador.BO;
using System.Drawing;

namespace Integrador.DAO
{
    internal class Usuarios_DAO
    {
        Conexion_DAO Con = new Conexion_DAO();
        SqlCommand Query = new SqlCommand();
        private string InsSQL;


        //Metodo para guardar para la base de datos
        public bool Guardar(Usuarios_BO Objt)
        {
            Usuarios_BO datos = (Usuarios_BO)Objt;
            Query.Connection = Con.ConectarBD();
            Con.AbrirBD();
            InsSQL = "insert into Usuario (Nombre,Apellido_1,Apellido_2,Fecha_ingreso,Correo,username,passwordd) values ('" + datos.NOMBRE + "','" + datos.APELLIDO_1 + "','" + datos.APELLIDO_2 + "',GetDate(),'" + datos.CORREO + "','" + datos.USERNAME + "','" + datos.PASSWORDD + "')";
            Query.CommandText = InsSQL;
            int Folio = Query.ExecuteNonQuery();
            Con.CerrarBD();

            if (Folio <= 0)
            {
                return false;
            }
            return true;
        }

        public int Eliminar(Usuarios_BO ObjPersona)
        {

            //Mismo comando enseñado por el maestro
            Usuarios_BO datos = (Usuarios_BO)ObjPersona;
            Query.Connection = Con.ConectarBD();
            Con.ConectarBD();
            InsSQL = "Delete from Usuario where ID = @ID ";
            Query.CommandText = InsSQL;
            Query.Parameters.Clear();//Aqui se limpia el Query para que no haga conflicto con el nuevo por si se desea eliminar otro dato
            Query.Parameters.AddWithValue("@ID", datos.ID1);//Aqui igualamos el @ID a ID1
            if (Query.Connection.State != ConnectionState.Open)//Verificamos que se abra la conexion
            {
                Query.Connection.Open();
            }
            int valor = Query.ExecuteNonQuery();
            Con.CerrarBD();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int Actualizar(Usuarios_BO ObjPersona)
        {
            Usuarios_BO datos = (Usuarios_BO)ObjPersona;
            Query.Connection = Con.ConectarBD();
            Con.ConectarBD();
            InsSQL = "Update Usuario set Nombre = '" + datos.NOMBRE + "' ,Apellido_1 = '" + datos.APELLIDO_1 + "' ,Apellido_2 = '" + datos.APELLIDO_2 + "', Correo = '" + datos.CORREO + "' ,username = '" + datos.USERNAME + "' ,passwordd = '" + datos.PASSWORDD + "' Where ID=@ID";
            Query.CommandText = InsSQL;
            Query.Parameters.Clear();//Aqui se limpia el Query para que no haga conflicto con el nuevo por si se desea eliminar otro dato
            Query.Parameters.AddWithValue("@ID", datos.ID1);//Aqui igualamos el @ID a ID1
            if (Query.Connection.State != ConnectionState.Open)//Verificamos que se abra la conexion
            {
                Query.Connection.Open();
            }
            int valor = Query.ExecuteNonQuery();
            Con.CerrarBD();
            if (valor <= 0)
            {
                return 0;
            }
            return 1;
        }

        //Metodo para mostrar Tabla Division
        public DataTable MostrarUsuario()
        {
            InsSQL = "Select * from Usuario";
            SqlDataAdapter adp = new SqlDataAdapter(InsSQL, Con.ConectarBD());
            DataTable TablaVirtual = new DataTable();
            adp.Fill(TablaVirtual);
            return TablaVirtual;

        }

    }
}
