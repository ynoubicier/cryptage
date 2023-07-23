using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cryptage.Classe
{
    internal class CLS_Fonction
    {
        public static int[] GetColumnVector(string message)
        {

            int[] col = new int[message.Length];

            // On assigne a chaque nombre une lettre avec A=0,B=1...
            for (int i = 0; i < message.Length; i++)
            {
                col[i] = message[i] - 'A' - 32;
            }

            return col;
        }

        public static int[,] GenerateMatrix(int n)
        {

            int[,] matrix = new int[n, n];


            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                matrix[i, i] = rand.Next(1, 26);
            }

            return matrix;
        }
    }
}
