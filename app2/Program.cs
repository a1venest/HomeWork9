// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

double AmountFromAndTo(double m, double n)
{
    double result = 0;
    if (m < n)
    {
        result = m + AmountFromAndTo(m + 1, n);
    }
    else if (m == n)
    {
         result = result + n;
    }
    return result;
}

double GetNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

double firstNumber = Math.Ceiling(GetNumber("Введите число M : "));
double lastNumber = Math.Floor(GetNumber("Введите число N : "));
Console.WriteLine($"Сумма натуральных чисел от {firstNumber} до {lastNumber} = {AmountFromAndTo(firstNumber, lastNumber)}");