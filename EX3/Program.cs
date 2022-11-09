//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


// 1.Запрашиваем длину масива
// Console.WriteLine("Задайте длину массива");
// int Num=Convert.ToInt32(Console.ReadLine());
// 2.Создаем массив вещественных чисел
double[] array(int Num)
{
    return new double[Num];
}
// 3.Заполняем масиив рандомными значениями
void FillArray(double[] ar)
{
    int length=ar.Length;
    for (int i = 0; i < length; i++)
    {
        ar[i]= new Random().NextDouble()*100;
    }
}
// 4.Ищем максимальный элемент массива
double MaxOfArray(double[] a)
{
    double Max=a[0];
    int length= a.Length;
    for (int i = 1; i < length; i++)
    {
        if(a[i]>Max) Max=a[i];
    }
    return Max;
}
// 5.Ищем минимальный элемент массива
double MinOfArray(double[] a)
{
    double Min=a[0];
    int length= a.Length;
    for (int i = 1; i < length; i++)
    {
        if(a[i]<Min) Min=a[i];
    }
    return Min;
}
// 6 находим разницу менежду максимальным и минимальным значениями
double Diff(double A, double B)
{
    double Diffval=A-B;
    return Diffval;
}
// 7 выводим на печать массив.
void Print(double[]arr)
{
    int length=arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
}
// 8 выводим на печать разницу из пункта 6
//Console.WriteLine(Diff);


Console.WriteLine("Задайте длину массива");
int Num=Convert.ToInt32(Console.ReadLine());
double[] A=array(Num);
FillArray(A);
double X=MaxOfArray(A);
double Y=MinOfArray(A);
double di=Diff(X,Y);
Print(A);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {di}");
