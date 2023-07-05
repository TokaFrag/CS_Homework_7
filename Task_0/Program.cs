// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void PrintArr(double[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Print($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Print(string text)
{
    Console.Write(text);
}

double[,] CreateArray(int row, int col, int min, int max)
{
    Random random = new Random();
    double[,] array = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = random.Next(min, max + 1) + Math.Round(random.NextDouble(), 2);
        }
    }
    return array;
}



double[,] array = CreateArray(3, 4, -9, 9);
PrintArr(array);
