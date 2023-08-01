// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int ConclusionNumber(int number, int pow, int count, int multi)
// {
//     if (count == pow) return multi;
//     else
//     {
//         multi = multi * number;
//         count++;
//         return ConclusionNumber(number, pow, count, multi);
//     }
// }

// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// int multi = a;
// Console.WriteLine($"{ConclusionNumber(a, b, count, multi)}");


int GetPower (int num, int power)
{
    if (power>1)
    {
        return num*GetPower(num, power-1);
    }
    return num;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInput("Введите число A: ");
int num2 = GetInput("Введите число B: ");
Console.Write(GetPower(num,num2));