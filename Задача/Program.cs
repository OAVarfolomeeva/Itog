string[] arraybase = new string[5] {"march", "7", "birthday", "38", "lol"};
string[] array2 = new string[arraybase.Length];

void ResultMassiv(string[] arraybase, string[] array2)
{
    int count = 0;
    for (int i = 0; i < arraybase.Length; i++)
    {
    if(arraybase[i].Length <= 3)
        {
        array2[count] = arraybase[i];
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
ResultMassiv(arraybase, array2);
PrintArray(array2);

