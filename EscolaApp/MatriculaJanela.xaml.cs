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

namespace EscolaApp
{
    /// <summary>
    /// Lógica interna para MatriculaJanela.xaml
    /// </summary>
    public partial class MatriculaJanela : Window
    {
        public MatriculaJanela()
        {
            InitializeComponent();
        }

        private void buttonlist(object sender, RoutedEventArgs e)
        {
            listTurmas.ItemsSource = null;
            listTurmas.ItemsSource = nTurma.Listar();
            listAlunos.ItemsSource = null;
            listAlunos.ItemsSource = nAluno.Listar();
        }

        private void buttonmatric(object sender, RoutedEventArgs e)
        {
            if(listTurmas.SelectedItem!=null && listAlunos.SelectedItem != null)
            {
                Aluno a = (Aluno)listAlunos.SelectedItem;
                Turma t = (Turma)listTurmas.SelectedItem;
                nAluno.Matricular(a, t);
                buttonlist(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um aluno e uma turma");
            }
        }
    }
}
