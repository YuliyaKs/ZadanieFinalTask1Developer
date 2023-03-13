// Задача: Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать
// на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

using System;
using static System.Console;

Clear();

Write("Введите строковые значения через пробел: ");
string[] arrayOrigin = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int countElements = CountArrayElements(arrayOrigin);

string[] arrayResult = ThreeCharacterElements(arrayOrigin, countElements);
Write($"[{String.Join(", ", arrayResult)}]");

int CountArrayElements(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] ThreeCharacterElements(string[] array, int count)
{
    string[] result = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }        
    }
    return result;
}