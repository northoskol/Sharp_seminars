// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

static double CalculateDistance(double x1, double y1, double x2, double y2)
{
    double dx = x2 - x1;
    double dy = y2 - y1;
    double distance = Math.Sqrt(dx * dx + dy * dy);
    return distance;
}
double GetInput(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}
double x1 = GetInput("Введите координаты X1: ");
double y1 = GetInput("Введите координаты y1: ");
double x2 = GetInput("Введите координаты x2: ");
double y2 = GetInput("Введите координаты y2: ");
CalculateDistance(x1, y1, x2, y2);
Console.Write("Ответ: " + CalculateDistance(x1, y1, x2, y2));