// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int GetCountNumber(int num)
{
    int count = 0;
    while (num > 0)
    {
        count++;
        num /= 10;
    }
    return count;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInput("Введите число: ");
int result = GetCountNumber(num);
Console.WriteLine($"Количество цифр равно {result}");


// Console.WriteLine("Vvedite 4islo");
// string number = Console.ReadLine();
// int n = number.Length;
// Console.WriteLine($"Количество чисел: {n}");