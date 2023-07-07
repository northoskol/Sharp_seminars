// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да
try
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number % 7 == 0)
    {
        if (number % 23 == 0)
        {
            Console.Write($"Число {number} кратно 7 и 23");
        }
    }
    else
    {
        Console.Write($"Число {number} не кратно 7 и 23");
    }
}
catch
{
    Console.Write("Не корректный ввод");
}



