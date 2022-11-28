// Задача: 
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ['1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

// РЕШЕНИЕ

string[] oneArray = {"hello", "2", "world", ":-)"};
string[] twoArray = new string[oneArray.Length];
void SecondArray(string[] oneArray, string[] twoArray)
{
    int count = 0;
    for (int i = 0; i < oneArray.Length; i++)
    {
        if (oneArray[i].Length <= 3)
        {
            twoArray[count] = oneArray[i];
            count++;
        }
    }
}


void PrintArray(string[] array)
{
    for ( int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Массив строк, заданный на старте выполнения алгоритма");
PrintArray(oneArray);
Console.WriteLine();
Console.WriteLine("Полученный массив строк, состоящий из трех элеметов в  заданном массиве строк");
SecondArray(oneArray, twoArray);
PrintArray(twoArray);