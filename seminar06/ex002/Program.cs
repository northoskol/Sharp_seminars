// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.



void Triangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a)
        Console.WriteLine("такой треугольник может существовать");
    else Console.WriteLine("такой треугольник не может существовать");
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int a = GetInput("Введите первое число:");
int b = GetInput("Введите второе число:");
int c = GetInput("Введите третье число:");
Triangle(a, b, c);