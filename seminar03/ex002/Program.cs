// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).




void ShowQuarter(int quarter)
{
    if (quarter==1) Console.WriteLine("(x>0 y>0)");
    if (quarter==2) Console.WriteLine("x<0 y>0");
    if (quarter==3) Console.WriteLine("x<0 y<0");
    if (quarter==4) Console.WriteLine("x>0 y<0");
}
int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int quarter = GetInput("Введите четверть: ");
ShowQuarter(quarter);





