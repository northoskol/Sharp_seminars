// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите число N:");
// int N = int.Parse(Console.ReadLine());

// Console.WriteLine("Таблица квадратов чисел от 1 до {0}", N);
// Console.WriteLine("---------------------------");
// Console.WriteLine("|  Число  |  Квадрат  |");
// Console.WriteLine("---------------------------");

// for (int i = 1; i <= N; i++)
// {
//     int square = i * i;
//     Console.WriteLine("|   " + i + "      |   " + square + "       |");
// }

// Console.WriteLine("---------------------------");

void Square(int value)
{
    for (int i = 1; i <= value; i++)
    {
        int square = i * i;
        Console.WriteLine(square);
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int value = GetInput("Введите число: ");
Square(value);
