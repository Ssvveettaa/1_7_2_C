// Задача 11:
// Напишите программу, которая
// выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.
// 456 –> 46
// 782 –> 72
// 918 –> 98

int number = new Random().Next(100, 1000); // [min, max)
Console.WriteLine($"Случайное число из отрезка [100, 999]: {number}");

int result = DeleteSecondDigit(number); // Вызов функции
Console.WriteLine($"Результат удаления второй цифры: {result}");

int DeleteSecondDigit(int num) // int num = number // Реализация функции
{
    int firstDigit = num / 100;
    // int secondDigit = num / 10 % 10;
    int thirdDigit = num % 10;
    return firstDigit * 10 + thirdDigit;
}
