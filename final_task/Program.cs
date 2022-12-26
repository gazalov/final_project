Console.Clear();

string[] StringArraySelect(string[] arrayToSelect, int countChar)
{
    int countElements = 0;
    for (int i = 0; i < arrayToSelect.Length; i++)
    {
        if (arrayToSelect[i].Length <= countChar)
        {
            countElements++;
        }
    }

    string[] newArray = new string[countElements];

    int newArrayCount = 0;
    for (int i = 0; i < arrayToSelect.Length; i++)
    {
        if (arrayToSelect[i].Length <= countChar)
        {
            newArray[newArrayCount] = arrayToSelect[i];
            newArrayCount++;
        }
    }
    return newArray;
}

void PrintArray(string[] arrayToPrint)
{
    Console.Write("[ ");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write($"{arrayToPrint[i]} ");
    }
    Console.Write("]");
}

int countChar = 3;
string[] array = { "hello", "2", "world", ":-" };
PrintArray(array);
string[] newArray = StringArraySelect(array, countChar);
Console.WriteLine();
PrintArray(newArray);
