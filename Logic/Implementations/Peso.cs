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
    /// Questão 4
    /// </summary>
    public class Peso : IPeso
    {
        public string GetResponse(DtoPeso dto) => PesoIdeal(dto.Sexo, dto.Altura);

        public string PesoIdeal(string sexo, double altura)
        {
            if (sexo != "M" && sexo != "F") return "Sexo invalido!";
            if (altura <= 0) return "Altura invalida!";

            double peso = 0;
            string genero = "";

            if (sexo == "M")
            {
                peso = (72.7 * altura) - 58;
                genero = "homem";
            }
            else if (sexo == "F")
            {
                peso = (62.1 * altura) - 44.7;
                genero = "mulher";
            }

            return String.Concat("O peso ideal para ", genero, " com altura ", altura, " eh: ", peso);
        }
    }
}
