// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void GetCount(int[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] >= 10 & mas[i] < 100)
        {
            count++;
        }
    }
    Console.WriteLine($" количество элементов массива: {count}");
}


int[] GetMas(int num, int numMin, int numMax)
{
    int[] mas = new int[num];
    for (int i = 0; i < num; i++)
    {
        mas[i] = new Random().Next(numMin, numMax+1);
    }
    return mas;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] mas = GetMas(123, 10, 99);
int numMin = GetInput("Введите минимальное число массива:");
int numMax = GetInput("Введите максимальное число массива:");
Console.Write($"массив [{String.Join(", ", mas)}]");
GetCount(mas);