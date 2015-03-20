using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int linha;
            int coluna;

            Console.WriteLine("informe o numero de linhas da matriz");
            linha = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o numero de colunas da matriz");
            coluna = int.Parse(Console.ReadLine());

            int[,] mat = new int[linha, coluna];

            for (int l = 0; l < linha; l++)
            {
                for (int c = 0; c < coluna; c++)
                {
                    Console.WriteLine("digite um valor");
                    mat[l, c] = int.Parse(Console.ReadLine());
                }
            }

            Console.Clear();
            for (int l = 0; l < linha; l++)
            {
                for (int c = 0; c < coluna; c++)
                {
                    Console.Write(mat[l, c]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Informe um indice a ser removido da matriz");
            int num;
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Nova matriz");
            for (int l = 0; l < linha; l++)
            {
                if (l != num)
                {
                    for (int c = 0; c < coluna; c++)
                    {
                        if (c != num)
                        {
                            Console.Write(mat[l, c]);
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
