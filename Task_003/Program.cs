// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3


int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int column, int leftRange, int rightRange) 
{
    var matrix = new int[row, column];
    var rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return matrix;
}

void PrintMatrix(int[, ] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[] FindColumnAverage(int[,] matrix)
{
    var arrayOfAverage = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
             sum += matrix[j, i];
        }
        arrayOfAverage[i] = Math.Round(sum / (matrix.GetLength(0) * 1.0), 1);
    }
    return arrayOfAverage;
}

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
var matrix = FillMatrix(rows, cols, 0, 30);
PrintMatrix(matrix);
System.Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", FindColumnAverage(matrix))}.");