// Задача 12:
// Напишите программу, которая будет
// принимать на вход два числа
//     и выводить, является ли первое число кратным второму.
//     Если первое число не кратно второму, то программа выводит остаток от деления.
// 34, 5 –> не кратно, остаток 4
// 16, 4 –> кратно

Console.WriteLine("Введите первое целое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = Remainder(number1, number2);

if (result == 0) Console.WriteLine("Первое число является кратным второму.");
else Console.WriteLine($"Первое число не является кратным второму. Остаток от деления: {result}.");

int Remainder(int num1, int num2)
{
    return num1 % num2;
}
