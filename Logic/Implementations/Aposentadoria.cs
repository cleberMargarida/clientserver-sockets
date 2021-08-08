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
    /// Questão 7
    /// </summary>
    public class Aposentadoria : IAposentadoria
    {
        public string PermiteAposentadoria(int idade, int tempo)
        {
            if (idade < 0 || idade > 100) return "Idade invalida.";
            if (tempo < 0 || tempo > 80) return "Tempo de contribuicao invalido.";

            if (idade >= 65 || tempo >= 30 || (idade >= 60 && tempo >= 25)) return "Aposentadoria liberada!";

            return "Aposentadoria nao permitida.";
        }
    }
}
