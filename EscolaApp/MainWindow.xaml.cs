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

namespace EscolaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Turma_click(object sender, RoutedEventArgs e)
        {
            Turmajanela TJ = new Turmajanela();
            TJ.ShowDialog();
        }

        private void Aluno_click(object sender, RoutedEventArgs e)
        {
            AlunoJanela AJ = new AlunoJanela();
            AJ.ShowDialog();
        }

        private void Matricula_click(object sender, RoutedEventArgs e)
        {
            MatriculaJanela MJ = new MatriculaJanela();
            MJ.ShowDialog();
        }

        private void Diario_click(object sender, RoutedEventArgs e)
        {
            DiarioJanela DJ = new DiarioJanela();
            DJ.ShowDialog();
        }
    }
}
