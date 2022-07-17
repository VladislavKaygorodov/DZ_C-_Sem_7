/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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

void AvgColumn(int [,] matrix)
{   
    int k = 0;
    int j = 0;
    double sum = 0;
    double [] array = new double [matrix.GetLength(1)];
    int i = 0;
    int arraySize = array.Length;
    while (i< arraySize)
    {   
        if(k < matrix.GetLength(0))
        {
            sum += matrix[k,j];
            k++;
        }
        else
        {
            array[i] = Math.Round(sum / k, 2);
            i++;
            sum = 0;
            k=0;
            j++;
        }
    }
    Console.WriteLine($"Построчно среднее арифметическое каждого столбца выглядит так: [{String.Join(";", array)}]");
}


Console.WriteLine("Введите количество строк в матрице:");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в матрице:");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[lines,columns];

CreateMatrix(matrix);
PrintMatrix(matrix);

AvgColumn(matrix);
