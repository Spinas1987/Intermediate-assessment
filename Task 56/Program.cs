// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

int SumOfRow(int[,] matrix, int row)
{
    int sum = matrix[row, 0];
    for (int j = 1; j < matrix.GetLength(1); j++)
    {
        sum += matrix[row, j];
    }
    return sum;
}

int[] MinimumSumRow(int[,] matrix)
{
    int minSum = SumOfRow(matrix, 0);
    int minRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = SumOfRow(matrix, i);
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i; 
        }
    }
    return new int[] {minRow, minSum};
}
   


int[,] array2d = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();

int[] minSumRow = MinimumSumRow(array2d);
 Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");
int rowToSum = 1;
int sum = SumOfRow(array2d, rowToSum);
Console.WriteLine($"Сумма элементов в строке {rowToSum + 1}: {sum}");


