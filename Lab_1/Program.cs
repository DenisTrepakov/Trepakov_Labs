// Факториал числа n
// Ввести число 
// Считать число и отнять от него 1
// Вывести результат 

Console.WriteLine("Введите число для расчета факториала:");
int a = Convert.ToInt32(Console.ReadLine());

void Factorial(int number)
{
    // Проверка отрицательного числа 
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

Factorial(a);

//hello world!
Console.WriteLine("Привет, мир!");