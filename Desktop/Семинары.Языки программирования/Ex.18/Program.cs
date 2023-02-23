// Напишите программу, кт по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (Х и У)

Console.WriteLine("Введите номер четверти");
int a = int.Parse(Console.ReadLine());
switch (a)
{
    case 1: {
        Console.WriteLine("Диапазон точек: Х > 0, Y > 0");
        break;
    }
    case 2: {
        Console.WriteLine("Диапазон точек: Х < 0, Y > 0");
        break;
    }
    case 3: {
        Console.WriteLine("Диапазон точек: Х < 0, Y < 0");
        break;
    }
    case 4: {
        Console.WriteLine("иапазон точек: Х > 0, Y < 0");
        break;
    }
    default: {
        Console.WriteLine("Такой четверти нет");
        break;

    }
}
// if(a > 4){
//     Console.WriteLine("Такой четверти нет");
// }if(a == 1){
//     Console.WriteLine("Диапазон точек: Х > 0, Y > 0");
// } else if(a == 2){
//     Console.WriteLine("Диапазон точек: Х < 0, Y > 0");
// } else if(a == 3){
//     Console.WriteLine("Диапазон точек: Х < 0, Y < 0");
// } else if(a == 4){
//     Console.WriteLine("Диапазон точек: Х > 0, Y < 0");
// }


