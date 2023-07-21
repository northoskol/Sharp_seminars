// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


// void FillArray(int[] collection)
// {
//     int Length = collection.Length;
//     int index = 0;
//     while (index < Length)
//     {
//         collection[index] = new Random().Next(-9, 9);
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(col[position] + ", ");
//         position++;
//     }
// }
// int[] array = new int[12];                   из лекции
// FillArray(array);
// PrintArray(array);

int GetSumPlusOrMinus(int[] array, bool positive)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (positive) 
        {
            if (array[i] > 0) sum = sum + array[i];
        }
        else
        {
            if (array[i] < 0) sum = sum + array[i];
        }

    }
    return sum;
}

int[] GenRandomArray(int elements, int start, int finish)
{
    int[] array = new int[elements];
    for (int i = 0; i < elements; i++) 
    {
        array[i] = new Random().Next(start, finish);
    }
    return array;
}

int[] array = GenRandomArray(12, -9, 9);
Console.Write($"в массиве [{String.Join(", ", array)}]");
Console.WriteLine($" сумма положительных чисел равна {GetSumPlusOrMinus(array, true)}, сумма отрицательных равна {GetSumPlusOrMinus(array, false)}.");