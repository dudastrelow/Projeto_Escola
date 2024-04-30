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
    /// Lógica interna para TabelaAluno.xaml
    /// </summary>
    public partial class TabelaAluno : Window
    {
        public TabelaAluno()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CadastroAluno CE = new CadastroAluno();
            CE.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TabelaCurso CC = new TabelaCurso();
            CC.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TabelaTurma CT = new TabelaTurma();
            CT.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TabelaEscola CT = new TabelaEscola();
            CT.Show();
            this.Close();
        }
        private void Button_Click_sair(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
