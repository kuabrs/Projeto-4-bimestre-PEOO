using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EscolaApp
{
    static class nAluno
    {
        private static List<Aluno> Alunos = new List<Aluno>();
        public static void Inserir(Aluno A)
        {
            Abrir();
            Alunos.Add(A);
            Salvar();
        }
        public static List<Aluno> Listar()
        {
            Abrir();
            return Alunos;
        }
        public static void Atualizar(Aluno a)
        {
            Abrir();
            // Percorrer a lista de Alunos procurando o id informado (a.Id)
            foreach (Aluno obj in Alunos)
                if (obj.id == a.id)
                {
                    obj.nome = a.nome;
                    obj.matricula = a.matricula;
                    obj.email = a.email;
                }
            Salvar();
        }
        public static void Excluir(Aluno a)
        {
            Abrir();
            // Percorrer a lista de Alunos procurando o id informado (a.Id)
            Aluno x = null;
            foreach (Aluno obj in Alunos)
                if (obj.id == a.id) x = obj;
            if (x != null) Alunos.Remove(x);
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                // Objeto que serializa (transforma) uma lista de Alunos em um texto em XML
                XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
                // Objeto que abre um texto em um arquivo
                f = new StreamReader("./Alunos.xml");
                // Chama a operação de desserialização informando a origem do texto XML
                Alunos = (List<Aluno>)xml.Deserialize(f);
            }
            catch
            {
                Alunos = new List<Aluno>();
            }
            // Fecha o arquivo
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            // Objeto que serializa (transforma) uma lista de Alunos em um texto em XML
            XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
            // Objeto que grava um texto em um arquivo
            StreamWriter f = new StreamWriter("./Alunos.xml", false);
            // Chama a operação de serialização informando o destino do texto XML
            xml.Serialize(f, Alunos);
            // Fecha o arquivo
            f.Close();
        }
    }
}