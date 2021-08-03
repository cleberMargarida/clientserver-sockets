using Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Implemenation
{
    public class Maioridade : IMaioridade
    {
        public string EhMaiorIdade(string Nome, string Sexo, int Idade)
        {
            if (Idade < 0 || Idade > 100) return "Idade Inválida!";
            if (Sexo != "M" || Sexo != "F") return "Sexo Inválido!";

            if ((Sexo == "M" && Idade >= 18) || (Sexo == "F" && Idade >= 21))
            {
                return String.Concat(Nome, " é maior de idade!");
            }
            else return String.Concat(Nome, " não é maior de idade! Pois tem ", Idade, " anos.");
        }
    }
}

    