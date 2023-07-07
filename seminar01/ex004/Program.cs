// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
n = Math.Abs(n);
Console.WriteLine("Целые числа в промежутке от -{0} до {0}:", n);  //Console.WriteLine($"Целые числа в промежутке от -{n} до {n}:", n);
for (int i = -n; i < n; i++)
{
    Console.Write(i + ", ");
}
Console.Write(n);