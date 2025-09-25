using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dimenzios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 2dimenziós tömb
            /*
            //ha az elem egyetlen sorszámmal azonosítható a tömben akkor az egydimenziós tömb (elemek egyszerű sora)
            //ha az azonosításhoz két indexet használunk két dimanziós a tömb (olyan mint egy táblázat)
            int[,] tablazat = new int[2, 3];
            //Adjuk meg egyesével a táblázat elemeit
            tablazat[0, 0] = 1;
            tablazat[0, 1] = 2;
            tablazat[0, 2] = 3;
            tablazat[1, 0] = 4;
            tablazat[1, 1] = 5;
            tablazat[1, 2] = 6;
            //kiírás
            //sorokat lépető külső ciklus
            for (int i = 0; i < tablazat.GetLength(0); i++)
            {
                //belső for ciklus lépteti az oszlopokat
                for (int j = 0; j <tablazat.GetLength(1); j++)
                {
                    Console.Write($"{tablazat[i,j]}");
                }
                Console.WriteLine();
            }
            */
            #endregion
            int n = 0;
            int m = 0;
            Console.WriteLine("Adj meg egy 2 és 10 közé eső számot:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adj meg egy 2 és 10 közé eső számot:");
            m = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j <matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 10);
                    Console.Write($"{matrix[i,j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
