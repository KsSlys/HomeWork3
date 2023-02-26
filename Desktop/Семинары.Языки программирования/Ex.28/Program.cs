//Напишите программу, которая принимает 
//на вход число N и выдаёт произведение чисел от 1 до N.
Console.Clear();
Console.WriteLine("Введите число");
int n  = int.Parse(Console.ReadLine());

int GetMultiplication(int n)
{
    int result = 1;
    int i = 2;
    if (n < 0){
        i = n;
        n = -1;
    }
    for ( ; i <= n; i++)
    result *= i;
    return result;

}
Console.WriteLine($"Произведение чисел от 1 до {n} - > {GetMultiplication(n)}");