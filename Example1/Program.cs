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

void SortingMass (int [,] NotSortMas, int k)
{
    for (int j = 0; j < NotSortMas.GetLength(0); j++)
{
    int[] z = new int[k];
    for (int i = 0; i < NotSortMas.GetLength(1); i++)
    {
        z [i] = NotSortMas[j,i];
    }
        Array.Sort(z);
        Array.Reverse(z);
        Console.WriteLine(string.Join(" " ,z));
}
}

Console.Write("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] mas = FillArray(m,n);
PrintArray(mas);
Console.WriteLine();
SortingMass(mas, n);