//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void array (int [] arr, int size, int max, int min, int i = 0)
{
    if (i == size) return;
    Random rnd = new Random();    
    arr[i] = rnd.Next(min, max+1);
    if (i == 0)
    {
        Console.Write($"[{arr[i]}");
        if (i == size - 1)
        {
            Console.Write($"] => ");            
        }
    }
    else if (i > 0 && i < size - 1)
    {
        Console.Write($", {arr[i]}");
    }
    else if (i == size - 1)
    {
        Console.Write($", {arr[i]}] => ");
    }
    array (arr, size, max, min, i+1);
    Console.Write($"{arr[i]}  ");
}


Console.WriteLine("Введите размер массива: ");
int s = Convert.ToInt32(Console.ReadLine());
if (s <= 0)
{
    Console.Write("Некорректный ввод");
}
else
{

Console.WriteLine("Введите нижний предел массива: ");
int low = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите верхний предел массива: ");
int top = Convert.ToInt32(Console.ReadLine());
if (low > top)
{
    Console.Write("Некорректный ввод");
}
else
{
    int[] arr = new int [s];
    array (arr, s, top, low);
}
}