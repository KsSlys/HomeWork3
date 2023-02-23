// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// * при N < 0, нужно вывести от N до -1
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int a = 1;
int m = N;
Console.Write($"{N} - > ");
if (N < 0){
    N = m;
    N = -1;
    while ( m <= N){
    double result = Math.Pow(m,3);
    Console.Write($"{result}, ");
    m++;
    }
    
}else {
    while ( a <= N){
    double result = Math.Pow(a,3);
    Console.Write($"{result}, ");
    a++;
    }
} 
