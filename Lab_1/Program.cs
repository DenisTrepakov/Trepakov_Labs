namespace Trepakov_Labs.Lab_1;

using System;

public class Program
{
    public static void Main(string[] args)
    {
        // 1 Задание
        void first()
        {
            Console.WriteLine("Введите число для расчета факториала:");
            int a = Convert.ToInt32(Console.ReadLine());
            Factorial(a);
        }
        
        // Локальная функция — без модификатора доступа
        void Factorial(int number)
        {
            if (number <= 0)
            {
                Console.WriteLine("Факториал не может быть равен 0 или отрицательным");
                return;
            }

            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Факториал {number} = {result}");
        }
        
        // 2 Задание
        static double Calculate(double x)
        {
            double lnCalc = Math.Sqrt(Math.Log(4.0/3.0));
            double linear = x + 9.0 / 7.0;
            double exp = Math.Exp(Math.Sin(1.3 * x - 0.7));
            
            double term = lnCalc + linear - exp;
            return term;
        }

        void Term2()
        {
            Console.WriteLine("Введите число для X:");
            double x = Convert.ToDouble(Console.ReadLine());
            
            double result = Calculate(x);
            Console.WriteLine($"Функция = {result}");
        }

        void Fibonacci()
        {
            Console.WriteLine("Введите число для расчета последовательности Фибоначчи:");
            int x = Convert.ToInt32(Console.ReadLine());
            
            if (x < 0)
            {
                Console.WriteLine("Нет чисел Фибоначчи в диапазоне [0, x], если x < 0.");
                return;
            }
            
            Console.WriteLine("Последовательность:");
            
            int a = 0;
            int b = 1;
            Console.Write(a);
            
            if (x >= 1)
            {
                Console.Write(", " + b);
            }

            while (true)
            {
                int next = a + b;
                if (next >= x)
                    break;
                Console.Write(", " + next);
                a = b;
                b = next;
            }
        }
        
        // Вызов 
        //Term2();
        //first();
        //Fibonacci();
    }
}