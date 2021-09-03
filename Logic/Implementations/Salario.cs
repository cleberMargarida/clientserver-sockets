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
    /// Questão 6
    /// </summary>
    public class Salario : ISalario
    {
        public string GetResponse(DtoSalario dto) => CalculoSalarioLiquido(dto.Nome, dto.Nivel, dto.SalarioBruto, dto.Dependentes);

        public string CalculoSalarioLiquido(string nome, string nivel, double salario, int dependentes)
        {
            if (nome == String.Empty) return "Nome invalido.";
            if (nivel != "A" && nivel != "B" && nivel != "C" && nivel != "D") return "Nivel invalido.";
            if (salario < 1000) return "O salario liquido so eh calculado a partir de 1000 reais.";
            if (dependentes < 0) return "Numero de dependentes invalido.";

            double SalarioLiquido = 0;

            switch (nivel)
            {
                case "A":
                    if (dependentes == 0) {SalarioLiquido = salario - (salario * 0.03);}
                    else {SalarioLiquido = salario - (salario * 0.08);}
                    break;

                case "B":
                    if (dependentes == 0) {SalarioLiquido = salario - (salario * 0.05);}
                    else {SalarioLiquido = salario - (salario * 0.1);}
                    break;

                case "C":
                    if (dependentes == 0) {SalarioLiquido = salario - (salario * 0.08);}
                    else {SalarioLiquido = salario - (salario * 0.15);}
                    break;

                case "D":
                    if (dependentes == 0) {SalarioLiquido = salario - (salario * 0.1);}
                    else {SalarioLiquido = salario - (salario * 0.17);}
                    break;

                default:
                    return "Calculo nao efetuado. Verifique os dados informados.";
            }

            return String.Concat(nome, " no nivel ", nivel, " tem salario liquido de: ", SalarioLiquido, " reais.");
        }
    }
}
