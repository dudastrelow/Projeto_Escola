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
    /// Lógica interna para CadastroCurso.xaml
    /// </summary>
    public partial class CadastroCurso : Window
    {
        public CadastroCurso()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TabelaCurso TC = new TabelaCurso();
            TC.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TabelaEscola T = new TabelaEscola();
            T.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TabelaCurso T = new TabelaCurso();
            T.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TabelaTurma T = new TabelaTurma();
            T.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TabelaAluno T = new TabelaAluno();
            T.Show();
            this.Close();
        }private void Button_Click_sair(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
