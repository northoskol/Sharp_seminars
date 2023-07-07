// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int random = new Random().Next(100, 1000);
int firstDigit = random / 100;
int secondDigit = random % 10;
int thirdDigit = (random / 10)%10;

Console.WriteLine($"{random} -> первое и третье {firstDigit}{secondDigit} -> второе число {thirdDigit}");