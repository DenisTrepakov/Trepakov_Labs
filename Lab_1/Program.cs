// Факториал числа n
// Ввести число 
// Считать число и отнять от него 1
// Вывести результат 

int Factorial(int a)
{
    if (a == 0 || a == 1)
        return 1;
    else
    {
        return a * Factorial(a - 1);
    }
} 
Console.WriteLine(Factorial(5));