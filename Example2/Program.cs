void PrintArray(int [,] table)
{
for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        Console.Write(table[i,j] + " ");
    }
    Console.WriteLine();
}
}

int [,] FillArray (int m, int n)
{
int [,] array = new int [m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(1, 10);
    }    
}
return array;
}

void SearchMin (int [,] NotSortMas, int k)
{
    int indexminsum = 0;
    int minsum1 = 0;
    int minsum;
    for (int i = 0; i < NotSortMas.GetLength(0); i++)
    {
        
        minsum = 0;
        for (int j = 0; j < NotSortMas.GetLength(1); j++)
        {
            minsum = minsum + NotSortMas[i,j];
            if (i == 0) minsum1 = minsum;
            if (minsum<minsum1)
                {
                minsum1 = minsum;
                indexminsum = i + 1;
                }
            
        }
        
    }
Console.Write(indexminsum);
}

Console.Write("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] mas = FillArray(m,n);
PrintArray(mas);
SearchMin(mas, n);