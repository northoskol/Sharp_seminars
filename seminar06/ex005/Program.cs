// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.



int[] CreateArray(int elements, int start, int finish)
{
    int[] array = new int[elements];
    for (int i = 0; i < elements; i++)
    {
        array[i] = new Random().Next(start,finish+1);
    }
    return array;
}

int[] CopyArray(int[] array, int[] copy_of_array)
{
    for (int i = 0; i < array.Length; i++)
    {
        copy_of_array[i]=array[i];
    }
    return array;
}

int[] array = CreateArray(4,1,9);
int[] copy_of_array=new int[array.Length];
CopyArray(array,copy_of_array);
Console.Write($"[{String.Join(", ", array)}] -> [{String.Join(", ", copy_of_array)}]");