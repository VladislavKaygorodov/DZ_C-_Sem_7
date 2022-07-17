/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/


void CreateMatrix(int [,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            matrix [i,j] = new Random().Next(1, 10);
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

void FindNum(int [,] matrix, int find)
{
    int Find = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            if(matrix [i,j] == find)
            {
                Find = find;
                break;
            }
        }
    }
    if(Find == find)
    {
        Console.WriteLine($"Число {find} присутствует в заданном массиве");
    }
    else
    {
         Console.WriteLine($"Число {find} отсутствует в заданном массиве");
    }
}


Console.WriteLine("Введите количество строк в матрице:");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице:");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[lines,columns];

CreateMatrix(matrix);
PrintMatrix(matrix);

Console.WriteLine("Введите искомое число: ");
int findNum = Convert.ToInt32(Console.ReadLine());

FindNum(matrix, findNum);
