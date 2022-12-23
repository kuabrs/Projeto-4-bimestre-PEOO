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
    }
}
