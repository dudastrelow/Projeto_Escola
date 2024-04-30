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

namespace WpfApp_27_02.Telas
{
    /// <summary>
    /// Lógica interna para TelaDashboard.xaml
    /// </summary>
    public partial class TelaDashboard : Window
    {
        public TelaDashboard()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TelaLogin TL = new TelaLogin();
            TL.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TelaCadastro TC = new TelaCadastro();
            TC.Show();
            this.Close();
        }
        private void Button_Click_sair(object sender, RoutedEventArgs e)
        {
            TelaCadastro TC = new TelaCadastro();
            TC.Show();
            this.Close();
        }
    }
}
