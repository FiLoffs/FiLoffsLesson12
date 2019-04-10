using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Konspect4
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
        static int Prz(int x, int y)
        {
            return x * y;
        }
        static int Del(int x, int y)
        {
            return x / y;
        }
        static void Main()
        {
            // Присваиваем имя метода обычным способом
            IntOperation op1 = new IntOperation(Sum);
            // Используем групповое преобразование
            op1 = Sum;
            int result = op1(5, 10);
            Console.WriteLine("Сумма: " + result);
            // Изменим ссылку на метод
            op1 = Prz;
            result = op1(5, 10);
            Console.WriteLine("Произведение: " + result);
            Console.ReadLine();
        }
    }
}
