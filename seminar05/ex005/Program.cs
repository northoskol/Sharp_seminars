// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


void GetNewMas(int[] mas)
{
    int size = mas.Length;
    for (int i = 0; i < mas.Length / 2; i++)
    {
        Console.Write($" {mas[i] * mas[size - 1 - i]}");
    }
    if (size % 2 != 0)
    {
        Console.Write($" {mas[(size / 2) + 1]}");
    }
}

int[] GetMas(int num, int numMin, int numMax)
{
    int[] mas = new int[num];
    for (int i = 0; i < num; i++)
    {
        mas[i] = new Random().Next(numMin, numMax + 1);
    }
    return mas;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num = GetInput("Введите количество чисел массива:");
int numMin = GetInput("Введите минимальное число массива:");
int numMax = GetInput("Введите максимальное число массива:");
int[] mas = GetMas(num, numMin, numMax);
Console.Write($"Массиве [{String.Join(", ", mas)}]");
GetNewMas(mas);