// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.Write("Введите координаты X: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты Y: ");
// int number2 = Convert.ToInt32(Console.ReadLine());


void ShowQuarter(int x, int y)
{
    if (x>0&y>0) Console.WriteLine("Это первая четверть: ");
    if (x<0&y>0) Console.WriteLine("Это вторая четверть: ");
    if (x<0&y<0) Console.WriteLine("Это третья четверть: ");
    if (x>0&y<0) Console.WriteLine("Это четвертая четверть: ");
}
int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int x = GetInput("Введите координаты X: ");
int y = GetInput("Введите координаты Y: ");
ShowQuarter(x,y);






