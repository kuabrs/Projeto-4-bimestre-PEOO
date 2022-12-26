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
    /// Lógica interna para Turmajanela.xaml
    /// </summary>
    public partial class Turmajanela : Window
    {
        public Turmajanela()
        {
            InitializeComponent();
        }

        private void inserirclick(object sender, RoutedEventArgs e)
        {
            //Novo objeto com os dados da turma que será inserida
            Turma t = new Turma();
            t.id = int.Parse(txtid.Text);
            t.Curso = txtcurso.Text;
            t.Descricao = txtturma.Text;
            t.AnoLetivo = int.Parse(txtano.Text);
            //Inserir a turma na lista de turmas
            nTurma.Inserir(t);
            //Lista a turma inserida
            listarclick(sender, e);
        }

        private void listarclick(object sender, RoutedEventArgs e)
        {
            listturmas.ItemsSource = null;
            listturmas.ItemsSource = nTurma.Listar();
        }
        private void attclick(object sender, RoutedEventArgs e)
        {
            //Novo objeto com os dados da turma que será inserida
            Turma t = new Turma();
            t.id = int.Parse(txtid.Text);
            t.Curso = txtcurso.Text;
            t.Descricao = txtturma.Text;
            t.AnoLetivo = int.Parse(txtano.Text);
            //Inserir a turma na lista de turmas
            nTurma.Atualizar(t);
            listarclick(sender, e);
        }

        private void excluirclick(object sender, RoutedEventArgs e)
        {

            //Novo objeto com os dados da turma que será inserida
            Turma t = new Turma();
            t.id = int.Parse(txtid.Text);
            t.Curso = txtcurso.Text;
            t.Descricao = txtturma.Text;
            t.AnoLetivo = int.Parse(txtano.Text);
            //Inserir a turma na lista de turmas
            nTurma.Excluir(t);
            listarclick(sender, e);
        }


    }
}
