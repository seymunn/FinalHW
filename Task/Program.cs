string[] firstarray = new string[4] {"hello", "2", "world", ":-)"};
string[] resularray = new string[firstarray.Length];

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