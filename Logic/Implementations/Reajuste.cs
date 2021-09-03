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
    /// Questão 1
    /// </summary>
    public class Reajuste : IReajuste
    {
        public string GetResponse(DtoReajuste dto) => ReajusteSalarial(dto.Nome, dto.Cargo, dto.Salario);

        public string ReajusteSalarial(string nome, string cargo, double salario)
        {
            if (cargo != "operador" && cargo != "programador") return "Cargo invalido!";
            if (salario <= 0) return "Salario invalido!";
            
            if (cargo.Equals("operador"))
            {
                salario = salario + (salario * 0.2);
            }
            else if (cargo.Equals("programador"))
            {
                salario = salario + (salario * 0.18);
            }

            return String.Concat(nome, " teve o salario reajustado para ", salario, " reais.");
        }
    }
}
