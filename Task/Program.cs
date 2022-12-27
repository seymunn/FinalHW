string[] firstarray = new string[4] {"hello", "2", "world", ":-)"};
string[] resultarray = new string[firstarray.Length];

void GetResultArray(string[] array1, string[] array2)
{
    int num = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[num] = array1[i];
            num += 1;
        }
    }
}

void PrintFirstArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"'{array[i]}', ");
        else Console.Write($"'{array[i]}'");
    }
}

void PrintResultArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

GetResultArray(firstarray, resultarray);
PrintFirstArray(firstarray);
Console.Write(" -> ");
PrintResultArray(resultarray);
