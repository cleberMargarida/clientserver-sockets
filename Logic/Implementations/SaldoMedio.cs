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
    /// Questão 8
    /// </summary>
    public class SaldoMedio : ISaldoMedio
    {
        public string CalculoDeCredito(double saldo)
        {
            if (saldo < 0) return "Saldo invalido.";

            double credito = 0;

            if (saldo >= 0 && saldo <= 200) { }
            else if (saldo >= 201 && saldo <= 400) { credito = (saldo * 0.2); }
            else if (saldo >= 401 && saldo <= 600) { credito = (saldo * 0.3); }
            else if (saldo >= 601) { credito = (saldo * 0.4); }

            return String.Concat("O cliente tem um saldo medio de ", saldo, " reais e um valor de credito de ", credito, " reais.");
        }
    }
}
