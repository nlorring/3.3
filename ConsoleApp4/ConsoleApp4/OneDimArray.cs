using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class OneDimArray : ArrayBase, IArrayOne, IPrinter
    {
        int[] array;

        public OneDimArray(bool user, int n) : base(user, n)
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
            array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите элемент {i + 1}");
                int d = int.Parse(Console.ReadLine());
                array.SetValue(d, i);
            }
        }
        public override void RndCreate()
        {
            Random rnd = new Random();
            array = new int[n];
            for (int i = 0; i < n; i++)
            {
                int r = rnd.Next(1, 200);
                array.SetValue(r, i);
            }
        }

        public void DeleteAbs()
        {
            int n = array.Length;
            int[] d = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(array[i]) <= 100)
                {
                    d.SetValue(array[i], i);

                }
            }

            array = d;
        }

        public void DeleteSame()
        {
            int n = array.Length;
            int[] res = new int[n];
            int k = 0;
            bool f;
            foreach (int i in array)
            {
                f = true;
                for (int j = 0; j < k; j++)
                {
                    if (i == res[j])
                    {
                        f = false;
                    }
                }
                if (f)
                {
                    res[k] = i;
                    k += 1;
                }
            }
            array = res;
        }
        public override decimal Average()
        {
            int[] l = array;
            decimal summ = 0;
            decimal sred = 0;
            for (int i = 0; i < l.Length; i++)
            {
                summ += array[i];
                int len = l.Length;
                sred = summ / len;
            }

            return Math.Round(sred, 2);
        }

        public override void Print()
        {
            Console.WriteLine("Одномерный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        public override void Change()
        {
            DeleteSame();
            DeleteAbs();
        }
    }
}
