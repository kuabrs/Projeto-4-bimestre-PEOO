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
    /// Lógica interna para DiarioJanela.xaml
    /// </summary>
    public partial class DiarioJanela : Window
    {
        public DiarioJanela()
        {
            InitializeComponent();
            listTurmas.ItemsSource = nTurma.Listar();

        }

        private void buttonlist(object sender, RoutedEventArgs e)
        {
            if (listTurmas.SelectedItem != null)
            {
                Turma t = (Turma)listTurmas.SelectedItem;
                listAlunos.ItemsSource = null;
                listAlunos.ItemsSource = nAluno.Listar();
            }
        }
    }
}
