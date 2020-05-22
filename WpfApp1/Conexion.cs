using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows;

namespace WpfApp1
{
    
    public class Conexion
    {

        MySqlConnection con = new MySqlConnection(WpfApp1.Properties.Settings.Default.proyectoConnectionString);

        public DataTable Rellenar(string query, string tabla)
        {
            try
            {
                con.Open();

                MySqlCommand createComm = new MySqlCommand(query, con);
                createComm.ExecuteNonQuery();

                MySqlDataAdapter dataAdp = new MySqlDataAdapter(createComm);
                DataTable dt = new DataTable(tabla);
                dataAdp.Fill(dt);
                con.Close();

                return dt;
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable(tabla);
                dt = null;
                MessageBox.Show(ex.Message);
                return dt;
            }
        }

        public bool Comprobar(string query)
        {
            MessageBox.Show(query);
            try
            {
                con.Open();

                MySqlCommand comm = new MySqlCommand(query, con);
                comm.ExecuteReader();
                MySqlDataReader resultado = comm.ExecuteReader();
                string numero = "" + resultado;
                MySqlDataAdapter dataAdp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable("USUARIO");
                dataAdp.Fill(dt);
                MessageBox.Show("-" + Convert.ToString(dt.Rows[0]["USUARIO"]) + "-");
                MessageBox.Show("-" + resultado.HasRows);
                if (resultado.HasRows == true)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("No se han encontrado resultados");
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Insertar(string query)
        {
            try
            {
                con.Open();

                MySqlCommand createComm = new MySqlCommand(query, con);
                createComm.ExecuteNonQuery();

                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        public bool Update(string query)
        {
            try
            {
                con.Open();

                MySqlCommand comm = new MySqlCommand(query, con);
                comm.ExecuteNonQuery();

                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Delete(string query)
        {
            try
            {
                con.Open();

                MySqlCommand comm = new MySqlCommand(query, con);
                comm.ExecuteNonQuery();

                con.Close();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }

    

}
