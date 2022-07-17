/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

void CreateMatrix(int [,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            matrix [i,j] = new Random().Next(99, 999);
        }
        Console.WriteLine();
    }
}

void PrintMatrix ( int [,] matrix )
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк в матрице:");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице:");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[lines,columns];

CreateMatrix(matrix);
PrintMatrix(matrix);
