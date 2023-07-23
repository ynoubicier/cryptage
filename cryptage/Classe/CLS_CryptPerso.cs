using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace cryptage.Classe
{
    internal class CLS_CryptPerso
    {
        public int[] encrypted;
        public int[,] key;

        public object Fonction { get; private set; }

        public string EncryptedMessage(string message)
        {
            int[] col = CLS_Fonction.GetColumnVector(message);

            key = CLS_Fonction.GenerateMatrix(col.Length);
            int keyRow = key.GetLength(0);
            int keyCol = key.GetLength(1);

            // Initialize the encrypted array as a class field
            encrypted = new int[col.Length];

            for (int i = 0; i < col.Length; i++)
            {
                for (int j = 0; j < col.Length; j++)
                {
                    encrypted[i] += key[i, j] * col[j];
                }
            }

            string finalEncryptedMessage = "";
            foreach (int num in encrypted)
            {
                finalEncryptedMessage += (char)(num % 26 + 'A');
            }
            return finalEncryptedMessage;
        }

        public string DecryptMessage(int[,] key, int[] encrypted)
        {

            int keyRow = key.GetLength(0);
            int keyCol = key.GetLength(1);

            double[,] keyArray = new double[keyRow, keyCol];
            for (int i = 0; i < keyRow; i++)
            {
                for (int j = 0; j < keyCol; j++)
                {
                    keyArray[i, j] = (double)key[i, j];
                }
            }
            //Installation de la bibliothèque MathNet.Numerics via le Gestionnaire de packages Nuget
            Matrix<double> inverseKey = Matrix<double>.Build.DenseOfArray(keyArray).Inverse();

            double[] decrypted = new double[encrypted.Length];
            for (int i = 0; i < inverseKey.RowCount; i++)
            {
                for (int j = 0; j < encrypted.Length; j++)
                {
                    decrypted[i] += inverseKey[i, j] * encrypted[j];
                }
            }
            int[] decrypted2 = Array.ConvertAll(decrypted, x => (int)x);

            string finalDecryptedMessage = "";
            foreach (int num in decrypted2)
            {
                finalDecryptedMessage += (char)(num % 26 + 'A' + 32);
            }
            return finalDecryptedMessage;
        }
    }
}
