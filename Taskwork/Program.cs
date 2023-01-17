string[] array1 = new string[4] {"1234", "1567", "-2", "computer science"};
string[] array2 = new string[array1.Length];
void NewArray(string[] array1, string[] array2)
{
    int count = 0;
    int maxSymbols = 3;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= maxSymbols)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
NewArray(array1, array2);
ShowArray(array2);