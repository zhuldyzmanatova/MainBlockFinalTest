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

/*
string[] array = new string []{"Hello", "2", "world", ";-)"};
// string[] array = new string []{"1234", "1567", "-2", "computer science"};
// string[] array = new string []{"Russia", "Denmark", "Kazan"};
Console.Write($"[{string.Join(", ", array)}] -> ");

string A = "";
int count = 0;
foreach (string element in array)
{
    if (element.Length <= 3)
        {
            A = A + element + " ";
            count++;
        }
}

string[] newArray = new string [count];

void CreateNewArray()
{
    string[] elements = A.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    for (int i = 0; i < count; i++)
    {
        newArray[i] = elements[i];
    }
}
CreateNewArray();
Console.WriteLine($"[{string.Join(", ", newArray)}]");
*/






