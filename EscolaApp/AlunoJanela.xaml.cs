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
    /// Lógica interna para AlunoJanela.xaml
    /// </summary>
    public partial class AlunoJanela : Window
    {
        public AlunoJanela()
        {
            InitializeComponent();
        }

        private void inserirclick(object sender, RoutedEventArgs e)
        {
            //Novo objeto com os dados da turma que será inserida
            int id = int.Parse(txtid.Text);
            string nome = txtnome.Text;
            string mat = txtmatricula.Text;
            string email = txtemail.Text;
            Aluno a = new Aluno();
            a.id = int.Parse(txtid.Text);
            a.idturma = int.Parse(txtidturma.Text);
            a.nome = txtnome.Text;
            a.matricula = txtmatricula.Text;
            a.email = txtemail.Text;
            //Inserir a turma na lista de turmas
            nAluno.Inserir(a);
            //Lista a turma inserida
            listarclick(sender, e);
        }

        private void listarclick(object sender, RoutedEventArgs e)
        {
            listalunos.ItemsSource = null;
            listalunos.ItemsSource = nAluno.Listar();
        }

        private void attclick(object sender, RoutedEventArgs e)
        {
            Aluno a = new Aluno();
            a.id = int.Parse(txtid.Text);
            a.idturma = int.Parse(txtidturma.Text);
            a.nome = txtnome.Text;
            a.matricula = txtmatricula.Text;
            a.email = txtemail.Text;
            //Inserir a turma na lista de turmas
            nAluno.Atualizar(a);
            listarclick(sender, e);
        }

        private void excluirclick(object sender, RoutedEventArgs e)
        {
            //Novo objeto com os dados da turma que será inserida
            Aluno a = new Aluno();
            a.id = int.Parse(txtid.Text);
            a.idturma = int.Parse(txtidturma.Text);
            a.nome = txtnome.Text;
            a.matricula = txtmatricula.Text;
            a.email = txtemail.Text;
            //Inserir a turma na lista de turmas
            nAluno.Excluir(a);
            listarclick(sender, e);
        }
        private void listAlunos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listalunos.SelectedItem != null)
            {
                Aluno obj = (Aluno)listalunos.SelectedItem;
                txtid.Text = obj.id.ToString();
                txtnome.Text = obj.nome;
                txtmatricula.Text = obj.matricula;
                txtemail.Text = obj.email;
            }
        }
    }
}
