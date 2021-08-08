using Logic.Assignatures.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace Logic.Implementations
{
    /// <summary>
    /// Questão 5
    /// </summary>
    public class Natacao : INatacao
    {
        public string Categoria(int idade)
        {
            if (idade < 5 || idade > 100) return "Idade invalida!";

            if (idade >= 5 && idade <= 7) return "Categoria: infantil A.";
            if (idade >= 8 && idade <= 10) return "Categoria: infantil B.";
            if (idade >= 11 && idade <= 13) return "Categoria: juvenil A.";
            if (idade >= 14 && idade <= 17) return "Categoria: juvenil B.";
            if (idade >= 18) return "Categoria: adulto.";

            return "Categoria inexistente para idade.";
        }
    }
}
