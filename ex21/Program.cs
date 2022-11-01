// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

double x1 = new Random().Next(-10,10);
double x2 = new Random().Next(-10,10);
double y1 = new Random().Next(-10,10);
double y2 = new Random().Next(-10,10);
double z1 = new Random().Next(-10,10);
double z2 = new Random().Next(-10,10);

Console.WriteLine($"Ввод координат первой точки: x1 - {x1}, y1 - {y1}, z1 - {z1}");
Console.WriteLine($"Ввод координат второй точки: x2 - {x2}, y2 - {y2}, z2 - {z2}");

double distance = 0;
distance = Math.Sqrt((x2 - x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2 - z1));

Console.WriteLine($"Расстояние между точками {distance}");
