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

namespace WpfApp_27_02.Telas
{
    /// <summary>
    /// Interação lógica para TelaCadastro.xam
    /// </summary>
    public partial class TelaCadastro : Window
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CadastroEscola CE = new CadastroEscola();
            CE.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TabelaEscola TE = new TabelaEscola();
            TE.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TabelaEscola CC = new TabelaEscola();
            CC.Show();
            this.Close();
        }
        private void Button_Click_cancelar(object sender, RoutedEventArgs e)
        {
            TelaDashboard telaDashboard = new TelaDashboard();
            telaDashboard.Show();
            this.Close();
        }
        private void Button_Click_sair(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
