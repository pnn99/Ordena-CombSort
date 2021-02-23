using System;

namespace Comb_Sort
{
    class Program
    {
        public static void CombSort(ref int[] data)
        {
            //inicializa o intervalo.
            double intervalo = data.Length;
            //Inicializar a troca como true para que o loop continue.
            bool troca = true;

            /*Um laço para manter as trocas dentro das condições
            onde ja ocorre o calculo das interações
            */
            while (intervalo > 1  || troca)
            {
                intervalo /= 1.3;

                if(intervalo < 1)
                intervalo = 1;

                int i = 0;
                troca = false;

                //Ondesão realizadas as trocas.
                while (i + intervalo < data.Length)
                {
                    int igap = i + (int)intervalo;

                    if(data[i] > data[igap])
                    {
                        int temp = data[i];
                        data[i] = data[igap];
                        data[igap] = temp;
                        troca = true;
                    }
                    //passa para apróxima posição do vetor.
                    i++;
                } 
            }
        }

        static void Main(string[] args)
        {
            int[] data = new int[]{8, 4, 1, 56, 3, -44, 23, -6, 28, 0};

            Console.WriteLine("Vetor fora de ordem");
            for(int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] +"  ");
            }
            Console.WriteLine();
            Console.ReadKey();

            CombSort(ref data);

            Console.WriteLine("Vetor Ordenado:");

            for(int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] +"  ");
            }
            Console.WriteLine();
        }
    }
}