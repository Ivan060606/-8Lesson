int [,,] FillArray (int m, int n, int o)
{
int [,,] array = new int [m,n,o];
int l = m*m*m;
int [] massall = new int[l];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < o; k++)
        {
            for (int u = 0; u < l; u++)
            {
                array[i,j,k] = new Random().Next(10, 100);
                massall[u] = array[i,j,k];
                for ( int p = 0; p < 8; p++)
                {
                    if (array[i,j,k] == massall[p]) array[i,j,k] = new Random().Next(10, 100);
                    if (array[i,j,k] == massall[p]) array[i,j,k] = new Random().Next(10, 100);
                }
            }
        }
    }    
}
return array;
}
void PrintArray(int [,,] table)
{
for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        for (int k = 0; k < table.GetLength(2); k++)
        {
            Console.Write($"{table[i,j,k]}({i},{j},{k}) ");
            
        }
        Console.WriteLine();
    }
    
}

}
int [,,] mas = FillArray(2,2,2);
PrintArray(mas);