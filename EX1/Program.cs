//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// 1. Печать массива
void PrintArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}
// 2. указать число элементов массива
Console.WriteLine("Введите число элементов Массива");
int[] CreateNewArray(int Num)
{
    return new int[Num];
}
// 3. заполнить указанный массив трехзначными часлами рандомно
int[] FillArrayTREE_DIGIT(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = Random.Shared.Next(100, 1000);
    }
    return array;
}
// 4. высести на печать
// 5. псчитать количество четных элементов
int CountOfEvenNum(int[] array)
{
    int Count = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i]%2== 0) Count++;
    }
    return Count;
}
// 6. вывести результат на экране
//Console.WriteLine("Введите число элементов Массива");
int Num = Convert.ToInt32(Console.ReadLine());
int[] array = CreateNewArray(Num);
FillArrayTREE_DIGIT(array);
PrintArray(array);
int Count = CountOfEvenNum(array);
Console.WriteLine($"Число четных элементов Массива array = {Count}");
