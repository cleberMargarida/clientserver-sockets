using Logic.Assignatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace Logic.Implemenations
{
    public class Maioridade :IMaioridade
    {
        public string EhMaiorIdade(string nome, string sexo, int idade)
        {
            if (idade < 0 || idade > 100) return "idade Inválida!";
            if (sexo != "M" || sexo != "F") return "sexo Inválido!";

            if ((sexo == "M" && idade >= 18) || (sexo == "F" && idade >= 21))
            {
                return String.Concat(nome, " é maior de idade!");
            }
            else return String.Concat(nome, " não é maior de idade! Pois tem ", idade, " anos.");
        }
    }
}

    