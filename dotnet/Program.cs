// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] initialArray = new string [8] {"458", "72", "student", "sol", "song", "256",  "dog", "data"};

string[] resultingArray = new string[initialArray.Length];

string[] NewArrayOfStrings(string[] initialArray, string[] resultingArray)
{
    int temp = 0;
    for (int i = 0; i < initialArray.Length; i++)
    {
    if(initialArray[i].Length <= 3)
        {
        resultingArray[temp] = initialArray[i];
        temp++;
        }
    }
    return resultingArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

Console.WriteLine("Исходный массив");
Console.WriteLine("458  72  student  sol  song  256  dog  data");

Console.WriteLine();
Console.WriteLine("Задача: ");
Console.WriteLine("Получить новый массив из строк, длина которых меньше, либо равна 3 символам.");

Console.WriteLine();
Console.WriteLine("Полученный массив");

resultingArray = NewArrayOfStrings(initialArray, resultingArray);
PrintArray(resultingArray);
