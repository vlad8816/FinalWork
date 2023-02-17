// Задача: Написать программу, которая из имеющегося массива строк формирует массив строк, длинна которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется использовать коллекции, лучше обойтись исключительно массивами.

// Примеры: ['hello', '2', 'world', ':-)'] -> ['2', ':-)'] 
// ['1234', '1567', '-2', 'computer science'] -> [ '-2' ] 
// ['Russia', 'Denmark', 'Kazan'] -> []

using static System.Console;
Clear();

WriteLine("Введите произвольные слова через пробел: ");
string [] UserArray = ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);
WriteLine("[{0}]", string.Join(", ", Array(UserArray)));


string[] Array(string[] array)
{
    int count =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        } 
    }
    string[] NewArray = new string[count];    
    int index = 0;
    for (int j = 0; j < array.Length; j++)
        {
            if (array[j].Length <=3)
            {
                NewArray[index] = array[j];
                index++;
            }           
        }
    return NewArray;
 }

