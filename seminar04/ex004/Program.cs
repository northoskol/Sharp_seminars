// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    for (int i = 0; i<length; i++)
    {
        collection[i] = new Random().Next(0, 2);
    }
}

// void PrintArray(int[] array)
// {
//     int length = array.Length;
//     for (int i = 0; i<length-1; i++)
//     {
//         Console.Write(array[length-1]);
//         Console.WriteLine();
//     }
// }

int[] array = new int[8];

FillArray(array);
// PrintArray(array);
Console.WriteLine($"[{String.Join(",", array)}]");
// Console.WriteLine();
// Console.WriteLine(array);

