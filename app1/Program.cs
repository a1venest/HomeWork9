// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

double GetNumberFromConsole()
{
    Console.WriteLine("Введите число:");
    return Convert.ToDouble(Console.ReadLine());
}

void WriteNumbers(double lastNumber)
{

    if (lastNumber>1)
    {
        Console.Write(lastNumber+ ", ");
        WriteNumbers(lastNumber-1);
    }
    if(lastNumber==1)
    {
        Console.Write(lastNumber+".");
    }
    else if(lastNumber<=0) 
    Console.WriteLine($"Нет натуральных чисел от 1 до {lastNumber}.");
}
WriteNumbers(Math.Truncate(GetNumberFromConsole()));
