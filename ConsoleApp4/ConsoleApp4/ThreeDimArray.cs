using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    sealed class ThreeDimArray : ArrayBase, IArrayThree, IPrinter
    {
        int[][] array;
        public ThreeDimArray(bool user, int n) : base(user, n)
        {
            if (user == true)
            {
                UserCreate();
            }
            else
            {
                RndCreate();
            }
        }
        public override void UserCreate()
        {
            array = new int[n][];
            Console.WriteLine("Введите числа через пробел");
            for (int i = 0; i < n; i++)
            {
                string[] a = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                array[i] = new int[a.Length];
                for (int j = 0; j < a.Length; j++)
                    array[i][j] = int.Parse(a[j]);
            }
        }
        public override void RndCreate()
        {
            Random rnd = new Random();
            array = new int[n][];
            for (int i = 0; i < n; i++)
            {
                int c = rnd.Next(1, 7);
                int[] tmp = new int[c];
                for (int j = 0; j < c; j++)
                {
                    tmp[j] = rnd.Next(0, 100);
                }
                array[i] = tmp;
            }
        }
        public override decimal Average()
        {
            int[][] l = array;
            decimal summ = 0;
            int all_sz = 0;
            for (int i = 0; i < n; i++)
            {
                all_sz += array[i].Length;

                for (int j = 0; j < l[i].Length; j++)
                {
                    summ += array[i][j];
                }
            }

            return Math.Round(summ / all_sz,2);
        }


        public void change()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] = (i +1) * (j+1);
                    }
                }
            }
        }

        public override void Print()
        {
            Console.WriteLine("Ступенчатый массив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]} ");
                }
                Console.WriteLine();
            }
        }
        public override void Change()
        {
            change();
        }

    }

}
