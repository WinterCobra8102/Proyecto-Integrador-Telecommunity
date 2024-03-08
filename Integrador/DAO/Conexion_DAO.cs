using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//lIBRERIAS DE BASE DE DATOS
using System.Data;
using System.Data.SqlClient;
using System.Drawing;


namespace Integrador.DAO
{
    internal class Conexion_DAO
    {

        //Variable para conectar la base de datos
        SqlConnection Conex;
        private string CadenaCon;
        //metodo para conectar la base de datos 
        public SqlConnection ConectarBD()
        {

            CadenaCon = "Data Source=DESKTOP-EQ4J0G3\\SQLEXPRESS; Initial Catalog= INTEGRA; Integrated Security=true";
            Conex = new SqlConnection(CadenaCon);
            return Conex;
        }

        //metodo para abrir la base de datos
        public void AbrirBD()
        {
            Conex.Open();
        }
        public void CerrarBD()
        {
            Conex.Close();
        }


    }
}
