void Sorting(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if(firstArray[i].Length <= 3)
        {
            secondArray[count] = firstArray[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] firstArray = new string[5] {"Hello", "2", "world", ":-)", "-2"};
string[] secondArray = new string[firstArray.Length];

Sorting(firstArray, secondArray);
PrintArray(secondArray);