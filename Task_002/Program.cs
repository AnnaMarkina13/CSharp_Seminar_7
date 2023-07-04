// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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

bool CheckIndex(int[,] matrix, int row, int col)
{
    if (row >= matrix.GetLength(0)|| row < 0 || col >= matrix.GetLength(1) || col < 0)
    {
        System.Console.WriteLine("Выход за границы двумерного массива!");
        return false;
    }
    return true;
}

int FindMatrixElement(int[,] matrix, int row, int col)
{
    return matrix[row, col];
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

var matrix = FillMatrix(3, 4, -10, 10);
PrintMatrix(matrix);

int row = ReadInt("Введите номер строки элемента: ");
int col = ReadInt("Введите номер столбца элемента: ");
if (CheckIndex(matrix, row, col))
{
    System.Console.WriteLine(FindMatrixElement(matrix, row, col));
}