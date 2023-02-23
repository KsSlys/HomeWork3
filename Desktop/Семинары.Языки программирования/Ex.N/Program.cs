// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1,4

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int a = 1;
Console.Write($"{N} - > ");
while ( a <= N){
    double result = Math.Pow(a,2);
    Console.Write($"{result}, ");
    a++;
}

