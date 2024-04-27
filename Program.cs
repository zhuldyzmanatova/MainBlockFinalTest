# pragma warning disable

// *Задача*: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// *Примеры*:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] array = new string []{"Hello", "2", "world", ":-)"};
// string[] array = new string []{"1234", "1567", "-2", "computer science"};
// string[] array = new string []{"Russia", "Denmark", "Kazan"};

Console.Write($"[{string.Join(", ", array)}] -> ");

string A = "";

for (int i = 0; i < array.GetLength(0); i++){
        if (array[i].Length <= 3) 
            A = A + array[i] + " ";     
    }

string[] newArray = A.Split(" ");

Console.WriteLine($"[{string.Join(", ", newArray).TrimEnd(',', ' ')}]");




