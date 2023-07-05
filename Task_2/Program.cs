// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

string PrintArrSingl(double[] array)
{
    return string.Join(". ", array);
}

void PrintArrDouble(int[,] array)
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

int[,] CreateArray(int row, int col, int min, int max)
{
    Random random = new Random();
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = random.Next(min, max + 1);
        }
    }
    return array;
}

double[] FindMean(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    double[] arrayMean = new double[row];
    double mean = 0;

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            mean += array[i, j];
        }
        arrayMean[i] = mean / col;
        mean = 0;
    }
    return arrayMean;
}



int[,] array = CreateArray(4, 4, 1, 9);
PrintArrDouble(array);
double[] arrMean = FindMean(array);
Print($"Arithmetic mean: {PrintArrSingl(arrMean)}");
