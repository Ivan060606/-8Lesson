void PrintArray(int [,] table)
{
for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        if (table[i,j] < 10) Console.Write(0);
        Console.Write(table[i,j] + " ");
    }
    Console.WriteLine();
}
}

int [,] FillArray (int n)
{
int index = 1;
int [,] array = new int [n,n];
Console.WriteLine();
    int i, j;

    for (j = 0, i = 0; j < n-1; j++)
    {array[i, j] = index;
    index++;}
    for (i = 0, j = n - 1; i < n-1; i++)
        {array[i, j] = index;
        index++;}
    for (j = n-1, i = n-1; j >=0; j--)
        {array[i, j] = index;
        index++;}
    for (i = n-2, j = 0; i >= 1; i--)
        {array[i, j] = index;
        index++;}
    for (j = 1, i = 1; j < n-1; j++)
        {array[i, j] = index;
        index++;}
    for (i = 2, j = 2; i < n-1; i++)
        {array[i, j] = index;
        index++;}
    for (j = 1, i = 2; j >=1; j--)
        {array[i, j] = index;
        index++;}
return array;
}


int m = 4;
int [,] mas = FillArray(m);
PrintArray(mas);