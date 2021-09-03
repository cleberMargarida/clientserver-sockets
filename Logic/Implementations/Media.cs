using Logic.Assignatures.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using Logic.Assignatures.DTO;

namespace Logic.Implementations
{
    /// <summary>
    /// Questão 3
    /// </summary>
    public class Media : IMedia
    {
        public string GetResponse(DtoMedia dto) => ReajusteSalarial(dto.N1, dto.N2, dto.N3);

        public string ReajusteSalarial(float n1, float n2, float n3)
        {
            if (n1 < 0 || n1 > 10 || n2 < 0 || n2 > 10 || n3 < 0 || n3 > 10) return "Nota invalida!";
            
            float media = (n1/n2);

            if (media >= 7)
            {
                return String.Concat("Aprovado com media: ", media);
            }
            else if (media > 3 && media < 7)
            {
                media = (media + n3) / 2;

                if (media >= 5) return String.Concat("Aprovado usando N3, com media: ", media);
            }

            return String.Concat("Reprovado com media: ", media);
        }
    }
}
