
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void create_mas(int[] a, int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(0, 100);
            Console.Write("Массив: ");
            for (int i = 0; i < n; i++)
            {
               
                Console.Write(a[i] + " ");

            }
            Console.WriteLine(" ");

        }

        static void func_prov(int[] a, int n)
        {
            int k = 0;
            for (int i = 0; i < n - 1; i++)
            
                if ((a[i] + a[i + 1]) % 2 == 0)
                {
                    k++;
                    Console.WriteLine(i + 1);
                    break;
                }
            if (k == 0) Console.WriteLine(0); ;




        }

        static void Main(string[] args)
        {
            
            int[] a= new int[1000];
            int n;
            Console.WriteLine(" Укажите количество элементов массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            create_mas(a , n);
            Console.Write("Результат: ");
            func_prov(a, n);

        }
    }
}





