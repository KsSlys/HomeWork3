﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int [] array = GetMas(8);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] GetMas(int size)
{
    int[] result = new int [size];
    for(int i = 0; i < size; i ++){
        result[i] = new Random().Next(1,100);
    }
    return result;
}