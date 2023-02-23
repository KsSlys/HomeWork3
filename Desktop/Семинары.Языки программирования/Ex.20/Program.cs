// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве

Console.WriteLine("Введите координаты х1");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y1");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты х2");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y2");
double y2 = double.Parse(Console.ReadLine());

// double a = Math.Pow(((x1 - x2)+(y1 - y2)),2);
// double s = Math.Sqrt(a);
double s = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1 - y2,2));

Console.WriteLine($"Расстояние = {s:f2}"); //f2 - означает, что будет 2 знака после запятой

