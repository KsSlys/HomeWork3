// Напишите программу, которая выводит массив из 8 эдементов 
// заполненный нулями и единицами в рандомном порядке

Console.Clear();
int num = 8;
int[] array = GetBinArray(num);
Console.Write($"[{String.Join(", ", array)}]");

int[] GetBinArray(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(2);
    }
    return result;
}

