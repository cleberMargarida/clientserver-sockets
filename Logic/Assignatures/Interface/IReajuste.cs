using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Assignatures.Interface
{
    public interface IReajuste
    {
        public string ReajusteSalarial(string nome, string cargo, double salario);
    }
}
