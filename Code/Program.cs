string PrintArray(int[] A)
{
    string result = string.Empty;
    for (int i = 0; i < A.Length; i++)
    {
        result += $"{ A[i]} ";
    }
    return result;
}



string B(int[] A)
{

    string result = string.Empty;
    for (int i = 0; i < A.Length; i++)
    {
        if (A[i] % 2 == 0)
        {
            result += $"{ A[i]} ";
        }
    }
    return result;

}

int[] A = { 2, 3, 4, 5, 6, 7, 8 };

Console.WriteLine(PrintArray(A));
Console.WriteLine();
Console.WriteLine(B(A));
