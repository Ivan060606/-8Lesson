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

int [,] Result (int[,] first, int[,] second)
{
    if (first.GetLength(1) != second.GetLength(0)) Console.WriteLine("Матрицы нельзя перемножить");
    int [,] third = new int [first.GetLength(0), second.GetLength(1)];
    for (int i = 0; i < first.GetLength(0); i++)
    {
        for (int j = 0; j < second.GetLength(1); j++)
        {
            for (int k = 0; k < second.GetLength(0); k++)
            {
                third[i,j] += first[i,k] * second[k,j];
            }
            
        }
    }
return third;
}

Console.Write("Введите число строк первого массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов первого массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите число строк второго массива: ");
int w = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов второго массива: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] mas1 = FillArray(m,n);
PrintArray(mas1);
Console.WriteLine();
int [,] mas2 = FillArray(w,z);
PrintArray(mas2);
Console.WriteLine();
int [,] mas3 = Result(mas1,mas2);
PrintArray(mas3);