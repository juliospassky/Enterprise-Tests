using System;
using System.Collections;
using System.Collections.Generic;

namespace AccentureKing
{
    internal class AlphanumComparator : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            string[] partsX = x.Split(' ');
            string[] partsY = y.Split(' ');
            string comparacao = x + " " + y;
            int valor = partsX[0].CompareTo(partsY[0]);
            if (valor != 0)
            {
                return valor;
            }
            else
            {
                int valorcompX = RomanToNumbers(partsX[1]);
                int valorcompY = RomanToNumbers(partsY[1]);
                if (valorcompX > valorcompY)
                {
                    return 1;
                }
                else if (valorcompX < valorcompY)
                {
                    return -1;
                }
                else { return 0; }
            }
        }

        #region Número Romano para int
        private enum RomanDigit
        {
            I = 1,
            V = 5,
            X = 10,
            L = 50,
            C = 100,
            D = 500,
            M = 1000
        }

        public static int RomanToNumbers(string roman)
        {
            roman = roman.ToUpper().Trim();
            if (roman == "N") return 0;

            int ptr = 0;
            ArrayList values = new ArrayList();
            int maxDigit = 1000;
            while (ptr < roman.Length)
            {
                char numeral = roman[ptr];
                int digit = (int)Enum.Parse(typeof(RomanDigit), numeral.ToString());

                int nextDigit = 0;
                if (ptr < roman.Length - 1)
                {
                    char nextNumeral = roman[ptr + 1];
                    nextDigit = (int)Enum.Parse(typeof(RomanDigit), nextNumeral.ToString());

                    if (nextDigit > digit)
                    {
                        maxDigit = digit - 1;
                        digit = nextDigit - digit;
                        ptr++;
                    }
                }

                values.Add(digit);
                ptr++;
            }

            int total = 0;
            foreach (int digit in values)
                total += digit;

            return total;
        }
        #endregion
    }
}