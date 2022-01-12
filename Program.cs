using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA14_PrimeNo2DArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] a, ans;
            int n, m;

            Console.Write("Enter Array number of row \'n\': ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter Array number of column \'m\': ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Enter a random seed number: ");
            int seed = int.Parse(Console.ReadLine());
            a = new int[n, m];
            Console.WriteLine("\n=== 2D Random Array : ===");
            //ans = new int[n, m];
            Populate(a, seed);
            ans = a;
                        
            ShowPrime(a,ans);
            Console.WriteLine("=== 2D Random Prime Array : ===");
            WriteMatrix(ans, n, m);

            Console.Read();
        }

        private static void WriteMatrix(int[,] ans, int n, int m)
        {
           for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (ans[i, j] == -1)
                    {
                        Console.Write(string.Format("{0,3}", "--") + " ");
                    }
                    else
                    {
                        Console.Write(string.Format("{0,3}", ans[i, j]) + " ");
                    }
                }           
                Console.WriteLine();
            }
        }
        public static void Populate(int[,] a, int seed)
        {
            Random r = new Random(seed);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = r.Next(1, 100);
                    Console.Write(string.Format("{0,3}", a[i, j]) + " "); //0-parameter 3-width
                }
                Console.WriteLine();
            }
        }

        public static void ShowPrime(int[,] a, int[,] ans)
         {

             for (int i = 0; i < a.GetLength(0); i++)
             {
                 for (int j = 0; j < a.GetLength(1); j++)
                 {
                     for (int k = 2; k <= (a[i, j] / 2); k++)
                     {
                         if (a[i, j] == 0 || a[i, j] == 1)
                         {
                             ans[i, j] = -1 ;
                        }
                         else if ((a[i, j] % k == 0))
                         {
                             ans[i, j] = -1;
                         }
                     }
                 }
             }
        }
    }
}

