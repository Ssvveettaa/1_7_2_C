// Задача 14:
// Напишите программу, которая
// принимает на вход число
// и проверяет кратно ли оно одновременно 7 и 23.
//  14 –> нет
//  46 –> нет
// 161 –> да

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Multiplicity(number);
Console.WriteLine(result ? $"Число {number} кратно одновременно 7 и 23." : $"Число {number} не кратно одновременно 7 и 23.");

bool Multiplicity(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}
