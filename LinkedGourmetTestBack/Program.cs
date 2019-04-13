using System;
using System.Collections.Generic;

namespace LinkedGourmetTestBack
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Problema One

            // Restrições 1 ≤ N ≤ 1018
            Console.WriteLine("Problema One:");
            Console.WriteLine(ProblemaOne(1));
            Console.WriteLine(ProblemaOne(4));
            Console.WriteLine(ProblemaOne(11));
            Console.WriteLine(ProblemaOne(12));
            Console.WriteLine(ProblemaOne(440));

            #endregion

            Console.WriteLine("-------------------------//-------------------------");

            #region Problema Two

            // Restrições 2 ≤ N ≤ 24

            Console.WriteLine("Problema Two:");
            Console.WriteLine(ProblemaTwo(5, 12345, 31254));
            Console.WriteLine(ProblemaTwo(5, 31254, 12345));
            Console.WriteLine(ProblemaTwo(5, 31254, 53214));

            #endregion

            Console.ReadKey();
        }

        public static int ProblemaOne(int floor)
        {
            int i = 1;
            while (i <= floor)
            {
                if (i.ToString().Contains("4") || i.ToString().Contains("13"))
                {
                    floor++;
                }
                i++;
            }
            return floor;
        }

        public static int ProblemaTwo(int competidores, int largada, int chegada)
        {
            int ultrapassagens = 0;
            List<char> inicio = new List<char>(largada.ToString().ToCharArray());
            List<char> fim = new List<char>(chegada.ToString().ToCharArray());
            int posFim = 0;
            for (int i = 0; i < competidores; i++)
            {
                int posInicio = inicio.IndexOf(fim[posFim]);
                if (posFim < posInicio)
                {
                    ultrapassagens += posInicio - posFim;
                    inicio.RemoveAt(posInicio);
                    fim.RemoveAt(posFim);
                    posFim = 0;
                }
                else
                {
                    posFim += 1;
                }
            }
            return ultrapassagens;
        }
    }
}
