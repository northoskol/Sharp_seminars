// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

String ConclusionNumber(int firstNumber, int SecondNumber)
{
    if (firstNumber == SecondNumber) return firstNumber.ToString();
    return firstNumber + ", " + ConclusionNumber(firstNumber + 1, SecondNumber);
}

Console.Write("Введите число M: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("[ " + ConclusionNumber(firstNumber, SecondNumber) + " ]");
