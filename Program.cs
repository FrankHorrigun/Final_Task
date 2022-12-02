// See https://aka.ms/new-console-template for more information

int GetArrayLength(string message)
{
    Console.WriteLine(message);
    int value;
    while (!int.TryParse(Console.ReadLine(), out value) ^ value <= 0)
    {
        Console.WriteLine("Введите число больше нуля ");
        Console.WriteLine(message);
    }
    return value;
}

string GetInputString(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    return input;
}

string[] GetStringArray(int value)
{
    string[] newStringArray = new string[value];
    for (int i = 0; i < newStringArray.Length; i++)
    {
        newStringArray[i] = GetInputString($"Введите {i + 1} элемент массива");
    }
    return newStringArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}] ");
}

int FindNumberOfElements(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string element = array[i];
        int lengthOfElement = element.Length;
        if (lengthOfElement <= 3) count++;
    }
    return count;
}

string[] CreateResultArray(string[] array)
{
    int length = FindNumberOfElements(array);
    string[] result = new string[length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string element = array[i];
        int lengthOfElement = element.Length;
        if (lengthOfElement <= 3)
        {
            result[j] = element;
            j++;
        }
    }
    return result;
}

int arrayLength = GetArrayLength("Введите длину массива");

string[] stringArray = GetStringArray(arrayLength);
PrintArray(stringArray);
Console.WriteLine();

int count = FindNumberOfElements(stringArray); // проверка
// Console.WriteLine(count);
// Console.WriteLine();

string[] resultArray = CreateResultArray(stringArray);
if (count != 0)
{
    PrintArray(resultArray);
}
else Console.WriteLine("Элементы длиной не более трех отсутствуют");
