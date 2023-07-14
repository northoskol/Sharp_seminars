// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


int GetSum(int limit)
{
    int summa = 1;
    for (int i = 1; i <= limit; i++)
    {
        summa = summa * i;
    }
    return summa;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = GetInput("Введите число N: ");
Console.WriteLine($"Произведение чисел 1 до {numberA} равно {GetSum(numberA)}");