// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

int x1 = new Random().Next(-10,10);
Console.Write($"Ввод координаты x1 {x1}");
int x2 = new Random().Next(-10,10);
Console.Write($"Ввод координаты x2 {x2}");

int y1 = new Random().Next(-10,10);
Console.Write($"Ввод координаты y1 {y1}");
int y2 = new Random().Next(-10,10);
Console.Write($"Ввод координаты y2 {y2}");

int z1 = new Random().Next(-10,10);
Console.Write($"Ввод координаты z1 {z1}");
int z2 = new Random().Next(-10,10);
Console.Write($"Ввод координаты z2 {z2}");

int distance = 0;
distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"Расстояние между точками {distance}");
