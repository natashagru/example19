//программа которая на вход принимает пятизначное число и проверяет, является ли оно палиндромом
Console.Clear();
Console.WriteLine("Введите пятизначное число");
Console.WriteLine("Число является палиандромом?");
int n = int.Parse(Console.ReadLine()!);
if (n / 10000 == n % 10 && n / 1000 % 10 == n / 10 % 10)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}
