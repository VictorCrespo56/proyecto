using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;
using WpfApp1.Pops;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Login1 logIn = new Login1();
            logIn.ShowDialog();

            Load_datagrid();
        }

        private void BtNewPlato_Click(object sender, RoutedEventArgs e)
        {
            Plato1 nuevoPlato = new Plato1();
            nuevoPlato.ShowDialog();
        }

        private void BtBorrar_Click(object sender, RoutedEventArgs e)
        {
            //cbDesayuno.
            txtDesayuno.Text = "gr";
            //cbComida.
            txtComida.Text = "gr";
            //cbMerienda.
            txtMerienda.Text = "gr";
            //cbCena.
            txtCena.Text = "gr";
            txtNotas.Text = "";
        }

        private void Load_datagrid()
        {
            string connectionString = WpfApp1.Properties.Settings.Default.proyectoConnectionString;
            MySqlConnection sqlCon = new MySqlConnection(connectionString);

            try
            {
                sqlCon.Open();
                string query = "select * from USUARIO";
                MySqlCommand createComm = new MySqlCommand(query, sqlCon);
                string resultado = "" + createComm.ExecuteNonQuery();

                MySqlDataAdapter dataAdp = new MySqlDataAdapter(createComm);
                DataTable dt = new DataTable("USUARIO");
                dataAdp.Fill(dt);
                dg_usuario.ItemsSource = dt.DefaultView;
                dataAdp.Update(dt);

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
