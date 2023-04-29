//  Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать 
// на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

int Length(string arg)
{
    int num;
    System.Console.Write($"{arg}");
    while(!int.TryParse(Console.ReadLine(), out num) || num < 1)
    {
        System.Console.WriteLine("It's not a number or incorrect data!");
        System.Console.Write($"{arg}");
    }
    return num;
}

string[] CreateArray()
{
    System.Console.WriteLine();
    System.Console.WriteLine("Hello!");
    int count = Length("How many elements do you want to see in your array? Your answer: ");
    string[] array = new string[count];
    return array;
}

void FillArray(string[] array)
{
    System.Console.WriteLine();
    int elems = 1;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Enter your {elems} element: ");
        array[i] += Console.ReadLine();
        elems++;
    }
}

void PrintArray(string[] array)
{
    System.Console.WriteLine();
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
    System.Console.Write(array[array.Length - 1] + "]" + "  -->  ");
     
}

int CountOfElems(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] Main(int a, string[] array)
{
    int count = 0;
    string[] elements = new string[a];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            elements[count] += array[i];
            count++;
        }
    }
    return elements;
}

void PrintMiniArray(string[] array)
{
    if(array.Length == 0) System.Console.Write("[]");
    else
    {
        System.Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            System.Console.Write(array[i] + ", ");
        }
        System.Console.Write(array[array.Length - 1] + "]");
    }
}

string[] strings = CreateArray();
FillArray(strings);
PrintArray(strings);
PrintMiniArray(Main(CountOfElems(strings), strings));
