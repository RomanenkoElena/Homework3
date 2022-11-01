// Задача 23. Найти кубы чисел от 1 до N

int numberN = new Random().Next(1, 10);
Console.WriteLine($"Ввод числа {numberN}");

for (int i = 1; i <= numberN; i++)
{
    int cube = i * i * i;
    Console.WriteLine($"Число {i}, куб числа {cube}");
}
