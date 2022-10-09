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
