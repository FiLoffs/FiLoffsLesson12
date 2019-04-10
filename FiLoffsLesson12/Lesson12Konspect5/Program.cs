using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Konspect5
{
    // Создадим делегат
    delegate int IntOperation(int i, int j);
    public class MyClass
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Prz(int x, int y)
        {
            return x * y;
        }
        public static int Del(int x, int y)
        {
            return x / y;
        }
    }
    class Program
    {
        static void Main()
        {
            // Инициализируем делегат
            IntOperation op1 = MyClass.Sum;
            int result = op1(5, 10);
            Console.WriteLine("Сумма: " + result);
            op1 = MyClass.Prz;
            result = op1(5, 10);
            Console.WriteLine("Произведение: " + result);
            Console.ReadLine();
        }
    }
}
