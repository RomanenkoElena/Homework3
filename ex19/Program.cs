// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int numberN = new Random().Next(10000, 99999);
Console.WriteLine($"Ввод пятизначного числа {numberN}");

int result1 = (numberN / 10000) %10;
int result2 = (numberN / 1000) % 10;
int result4 = (numberN / 10) % 10;
int result5 = numberN % 10;

if (result5 == result1 && result2 == result4)
{
    Console.WriteLine($"Да, число {numberN} является палиндромом");
}
else
{
    Console.WriteLine($"Нет, число {numberN} не является палиндромом");
}

// Console.WriteLine(result1); // эти строки писала для вывода промежуточного результата и проверки работы алгоритма
// Console.WriteLine(result2);
// Console.WriteLine(result4);
// Console.WriteLine(result5);