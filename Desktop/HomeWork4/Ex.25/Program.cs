﻿//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"{a} и {b} -> {Multiplication(a)}");

int Multiplication(int a)
{
    int result = 1;
    int count = 1;
    for (; count <= b; count ++){
        result = result*a;
    }
    return result;
}
