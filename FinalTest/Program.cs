Console.Clear();
string [] originalarray = new string [9] {"[","10,", "1034,", "555,", "674,", "321,", "8,", "x","]"};
string [] newarray = new string [originalarray.Length];


void FilterArray(string[] firstarray, string[] secondaray)
{
    int count = 0;
    for (int i = 0; i < firstarray.Length; i++)
    {
    if(firstarray[i].Length <= 3)
        {
        secondaray[count] = firstarray[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
        for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
    
        Console.WriteLine();
}


