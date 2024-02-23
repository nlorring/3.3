using ConsoleApp4;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayBase[] ar;
            Console.WriteLine("Напишите true если хотите ввод с клавиатуры, если хотите с помощью рандома, напишите false");
            bool user = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество элементов в одномерной массиве");
            int n = int.Parse(Console.ReadLine());
            OneDimArray array = new OneDimArray(user, n);
            Console.WriteLine("Введите количество строк в двухмерном массиве");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в двухмерном массиве");
            int c = int.Parse(Console.ReadLine());
            TwoDimArray array2 = new TwoDimArray(user, n2, c);
            Console.WriteLine("Введите количество строк в ступенчатом массиве");
            int n3 = int.Parse(Console.ReadLine());
            ThreeDimArray array3 = new ThreeDimArray(user, n3);

            ar = new ArrayBase[] { array, array2, array3 };
            IPrinter[] ip = { array, array2, array3, new Calendar() };
            Console.WriteLine("\nВывод всех массивов:");
            foreach (IPrinter printer in ip)
                printer.Print();
            
            Console.WriteLine("\nВывод всех средних");
            foreach (ArrayBase a in ar)
            {
                Console.WriteLine(a.Average());
                a.Change();
            }

            Console.WriteLine("\nВывод всех изменений");
            foreach (ArrayBase a in ar)
                a.Print();

      

        }
    }
}

