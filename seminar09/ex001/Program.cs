// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

String ConclusionNumber(int n)
{
    if (n == 1) return n.ToString();
    return n + ", " + ConclusionNumber(n - 1);
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(ConclusionNumber(n));



// int PrintNatural(int end, int start)
// {
//     if (end>start)
//     {
//         Console.Write(start);
//         start++;
//         return PrintNatural(end,start)
//     }
// }

