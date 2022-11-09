//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// 1. задаем длину массива
// Console.WriteLine("Введите длину массива");
// 2. создаем массив указанной длиной
int[] CreateNewArray(int Number)
{
    return new int[Number];
}
// 3. заполняем массив случайными числами
int[] FillArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = Random.Shared.Next(-100, 101);
    }
    return arr;
}
// 4. ищем сумму элементов которые стоят на нечетных позициях
int SumOfOddPosition(int[] array)
{
    int Sum = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 != 0) Sum += array[i];
    }
    return Sum;
}
// 5. выводим результат
void PrintArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}


Console.WriteLine("Введите длину массива");
Console.WriteLine();
int Num = Convert.ToInt32(Console.ReadLine());
int[] A = CreateNewArray(Num);
A = FillArray(A);
PrintArray(A);
Console.WriteLine();
int Sum = SumOfOddPosition(A);
Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях массива равна {Sum}");

