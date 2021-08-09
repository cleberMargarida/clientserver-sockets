using Logic.Assignatures.Interface;
using System;
using System.Collections.Generic;
namespace Logic.Implementations
{
    public class Baralho : IBaralho
    {
        public string NomeDaCarta(int carta, int naipe)
        {
            return Carta.GetCarta(carta) + " de " + Carta.GetNaipe(naipe);
        }
    }

    public static class Carta
    {
        private static readonly Dictionary<int, string> _dicionarioCarta = new Dictionary<int, string>
        {
            {1,"Às"},
            {2,"Dois"},
            {3,"Três"},
            {4,"Quatro"},
            {5,"Cinco"},
            {6,"Seis"},
            {7,"Sete"},
            {8,"Oito"},
            {9,"Nove"},
            {10,"Dez"},
            {11,"Valete"},
            {12,"Dama"},
            {12,"Rei"}
        };

        private static readonly Dictionary<int, string> _dicionarioNaipe = new Dictionary<int, string>
        {
            {1,"Paus"},
            {2,"Copas"},
            {3,"Ouro"},
            {4,"Espada"},
        };

        internal static string GetCarta(int carta) => _dicionarioCarta[carta];

        internal static string GetNaipe(int naipe) => _dicionarioNaipe[naipe];
    }
}
