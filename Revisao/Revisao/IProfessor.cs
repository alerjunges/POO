using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public interface IProfessor : IPessoa
    {
        string Matricula { get; }

        List<string> Disciplinas { get; }

        void AdcionarDisciplina(string disciplina);
        void RemoverDisciplina(string disciplina);
    }
}
