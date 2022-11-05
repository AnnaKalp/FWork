/* ЗАДАЧА:
Написать программу, которая из имеющегося массива строк формирует 
массив из строк, 
длина которых либо меньше либо равна 3 символа. Первоначальный массив
 можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями, лучше обойтись
 исключительно массивами.*/

Console.Clear();
int n = 3;
string[] GetString()
{
    Console.WriteLine("Введите символы через запятую, затем нажмите Enter: ");
    return Console.ReadLine()!.Split(",");
}

int GetLength(string[] arr, int n)
{
    int len = 0;
    for (int k = 0; k < arr.Length; k++)
    {
        if (arr[k].Length <= n)
            len++;
    }
    return len;
}

string[] FindString(string[] inputArray, int n)
{
    string[] result = new string[GetLength(inputArray, n)];
    for (int i = 0, j = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= n)
        {
            result[j] = inputArray[i];
            j++;
        }
    }
    return result;
}

string[] input = GetString();
string[] output = FindString(input, n);

Console.WriteLine($"[{String.Join(", ", input)}] -> [{String.Join(", ", output)}]");