﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координаты х1");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y1");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты z1");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты х2");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y2");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты z2");
double z2 = double.Parse(Console.ReadLine());

double s = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1 - y2,2)+ Math.Pow(z1-z2,2));

Console.WriteLine($"Расстояние = {s:f2}");
