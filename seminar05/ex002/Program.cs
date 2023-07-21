// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


void RevMas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = mas[i] * -1;
    }
}

int[] GetMas(int num, int min, int max)
{
    int[] mas = new int[num];
    for (int i = 0; i < num; i++)
    {
        mas[i] = new Random().Next(min, max);
    }
    return mas;
}
int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}




int num = GetInput("Введите количество чисел массива:");
int min = GetInput("Введите минимальное число массива:");
int max = GetInput("Введите максимальное число массива:");
int[] mas = GetMas(num, min, max);
Console.Write($"оригинальный массив [{String.Join(", ", mas)}]");
RevMas(mas);
Console.WriteLine($" замена знаков [{String.Join(", ", mas)}]");
