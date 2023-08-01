// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int Show(int m, int summ)
// {
//     if (m >0)
//     {
//         summ = summ + m % 10;
//         m = m / 10;
//         return Show (m,summ);
//     }
//     else return summ;

// }
// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int summ =0;
// Console.WriteLine($"{Show(m, summ)}");



int GetSumDigit(int number)
{
    if (number==0) return number;
    return number%10+GetSumDigit(number/10);
}

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{number} -> {GetSumDigit(number)}");