using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaApp
{
    public class Aluno
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string matricula { get; set; }
        public string email { get; set; }
        public int idturma { get; set; }
        public override string ToString()
        {
            if (idturma == 0)
                return $"{id} - {nome} - {matricula} - {email}";
            else
                return $"{id} - {nome} - {matricula} - {email} - Turma: {idturma}";
        }

    }
}

