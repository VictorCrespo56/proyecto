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
using System.Windows.Shapes;

namespace WpfApp1.Pops
{
    /// <summary>
    /// Lógica de interacción para Plato1.xaml
    /// </summary>
    public partial class Plato1 : Window
    {
        public Plato1()
        {
            InitializeComponent();
        }

        private void BtCancelar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void borrarNomPlato(object sender, MouseEventArgs e)
        {
            if (txtNomPlato.Text == "Nombre del plato")
            {
                txtNomPlato.Text = "";
            } 
        }

        private void borrartxtCant1(object sender, MouseEventArgs e)
        {
            if (txtCant1.Text == "Cantidad (gr)")
            {
                txtCant1.Text = "";
            }
        }

        private void borrartxtCant2(object sender, MouseEventArgs e)
        {
            if (txtCant2.Text == "Cantidad (gr)")
            {
                txtCant2.Text = "";
            }
        }

        private void borrartxtCant3(object sender, MouseEventArgs e)
        {
            if (txtCant3.Text == "Cantidad (gr)")
            {
                txtCant3.Text = "";
            }
        }

        private void borrartxtCant4(object sender, MouseEventArgs e)
        {
            if (txtCant4.Text == "Cantidad (gr)")
            {
                txtCant4.Text = "";
            }
        }

        private void borrartxtCant5(object sender, MouseEventArgs e)
        {
            if (txtCant5.Text == "Cantidad (gr)")
            {
                txtCant5.Text = "";
            }
        }
    }
}
