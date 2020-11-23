using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ConexionBD
{
    public class ConexionSQLServer
    {
        #region Parametros
        private string stringConexion;
        private SqlConnection sqlConexion;
        private string dataBase;
        private string server;
        #endregion

        #region Propiedades
        private string StringConexion { get => stringConexion; set => stringConexion = value; }
        private SqlConnection SqlConexion { get => sqlConexion; set => sqlConexion = value; }
        public string DataBase { get => dataBase; set => dataBase = value; }
        public string Server { get => server; set => server = value; }
        #endregion

        #region Funciones

        public void Conectar()
        {
            if (DataBase.Equals(string.Empty))
            {
                MessageBox.Show("ConexionSQL, DataBase no ingresado");
                return;
            }
            if (Server.Equals(string.Empty))
            {
                MessageBox.Show("ConexionSQL, DataBase no ingresado");
                return;
            }

            try
            {
                StringConexion = $"Server={Server};Database={DataBase};Trusted_Connection=True;";
                SqlConexion = new SqlConnection(StringConexion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ConexionSQL, No se pudo realizar la conexion. \n" + ex.Message);
                SqlConexion = null;
            }
        }

        public void Open()
        {
            try
            {
                SqlConexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ConexionSQL, No se pudo abrir la conexion. \n" + ex.Message);
            }
        }

        public void Close()
        {
            try
            {
                SqlConexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ConexionSQL, No se pudo cerrar la conexion. \n" + ex.Message);
            }
        }

        public DataTable Select(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, SqlConexion);
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ConexionSQL, No se pudo realizar un select. \n" + ex.Message);
            }
            Close();
            return dataTable;
        }

        public bool NonQuery(string non_query)
        {
            int cambios = 0;

            try
            {
                Open();
                SqlCommand command = new SqlCommand(non_query, SqlConexion);
                cambios = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ConexionSQL, No se pudo realizar el NonQuery. \n" + ex.Message);
                Close();
                return false;
            }
            Close();
            return cambios > 0;
        }

        #endregion
    }
}
