// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


void FindNumber(int[] array, int number)
{
    string text = "Искомое число" + number + " присутствует в данном массиве";
    for (int i = 0, i < array.Length, i++)
    {
        if (array[i] == number)
        {
            text = "Искомое число" + number + " присутствует в данном массиве";
            break;
        }

    }
    Console.WriteLine(text);
}

int[] array = { 6, 7, 19, 345, 3 };
Console.Write("Введите искомое число: ");
int number = int.Parse(Console.ReadLine());
FindNumber(array, number);