// 26 Напишите программу,
// которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(CountNumbers(a));

int CountNumbers(int a)
{
    int count = 0;

    if(a < 0)
    a *= (-1); // a = a * -1
    while (a > 0){
        a = a / 10;
        count ++;
    }
    return count;
}

