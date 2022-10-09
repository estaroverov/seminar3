////Решена задача на определение палиндрома для разных количеств цифр в числе

void isPolyndrom(int number)
{
    int counter = 0;
    int num = number;

    while(number != 0)
    {
        number /= 10;
        counter++;
    }

    int [] arr  = new int [counter];
    for(int i = 0; i<counter; i++)
    {
        arr[i] = num % 10;
        num /= 10;
    }

    counter = arr.Length-1;
    int CountCheck = arr.Length/2;
    for (int i = 0; i < CountCheck; i++)
    {
            if(arr[i] != arr[counter])
                break;
            counter --;
    }
    Console.WriteLine(CountCheck == counter ? "Палиндром" : "Не палиндром");
}

int num = int.Parse(Console.ReadLine());
isPolyndrom(num);

////////////////Задача 21 принимает на вход координаты двух точек и 
////////////////находит расстояние между ними в 3D пространстве.
void PrintArray(int [] arr)
{
    foreach(int i in arr)
    {
        Console.Write(i + " ");
    }
}
int [] FillManualArray(int length, int[] arr)
{
    Console.Write("Введите координаты точки:");
    for(int i=0; i<length; i++)
        arr[i] = int.Parse(Console.ReadLine());
    return arr;
}
int [] FillRandomArray(int length, int[] arr, int minVal = -100, int maxVal = 100)
{
    for(int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(minVal,maxVal);
    }
    return arr;
}
int [] DefineDots(int dimention = 3, bool isRandom = true)
{
    int [] arr = new int [dimention];
    if(isRandom == true)
        return FillRandomArray(dimention,arr);
    else
        return FillManualArray(dimention,arr);
    

}

double FindDistance3d(int[] a, int[] b)
{
    double sum = 0;
    for(int i = 0;i<a.Length;i++)
    {
        sum += Math.Pow((a[i] - b[i]),2);
    }
    double d = Math.Pow(sum,0.5);
    Console.WriteLine($"Расстояние: {d}");
    return d;
}

int[] firstDot = DefineDots(3,false);
int[] secondDot = DefineDots(3,false);

PrintArray(firstDot);
PrintArray(secondDot);
double d = FindDistance3d(firstDot,secondDot);


////Задача 23
////принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine());
int getCube(int number)
{
    return number*number*number;
}

void PrintCubeTable(int number)
{
    for(int i = 1; i <= number; i++)
    {
        Console.Write(getCube(i) + " ");
    }
}
PrintCubeTable(number);
