using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Konspect1
{
    // Создадим делегат
    delegate int IntOperation(int i, int j);

    class Program
    {
        // Организуем ряд методов
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static int Min(int x, int y)
        {
            return x - y;
        }

        static int Mul(int x, int y)
        {
            return x * y;
        }

        static int Div(int x, int y)
        {
            return x / y;
        }

        static void Main()
        {
            // Сконструируем делегат
            IntOperation op1 = new IntOperation(Sum);

            int result = op1(5, 10);
            Console.WriteLine("Сумма: " + result);

            // Изменим ссылку на метод
            op1 = new IntOperation(Mul);
            result = op1(5, 10);
            Console.WriteLine("Произведение: " + result);

            // Изменим ссылку на метод
            op1 = new IntOperation(Min);
            result = op1(op1(5, 10), 10);
            Console.WriteLine("Разность: " + result);
        }
    }
}
