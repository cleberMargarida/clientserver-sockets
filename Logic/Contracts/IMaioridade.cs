using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Contracts
{
    public interface IMaioridade
    {
        public string EhMaiorIdade(string Nome, string Sexo, int Idade);
    }
}
