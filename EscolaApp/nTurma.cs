using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaApp
{
    static class nTurma
    {
        private static List<Turma> Turmas = new List<Turma>();
        public static void Inserir(Turma t)
        {
            Turmas.Add(t);
        }
        public static List<Turma> Listar()
        {
            return Turmas;
        }
        public static void Atualizar(Turma t)
        {
            foreach(Turma obj in Turmas)
                if(obj.id == t.id)
                {
                    obj.Curso = t.Curso;
                    obj.Descricao = t.Descricao;
                    obj.AnoLetivo = t.AnoLetivo;
                }
            
        }
        public static void Excluir(Turma t)
        {
            Turma x = null;
            foreach (Turma obj in Turmas)
                if (obj.id == t.id) x = obj;
            if (x != null) Turmas.Remove(x);
        }
    }
}
