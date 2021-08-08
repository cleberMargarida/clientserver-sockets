using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Assignatures.Interface
{
    public interface ISalario
    {
        public string CalculoSalarioLiquido(string nome, string nivel, double salario, int dependentes);
    }
}
