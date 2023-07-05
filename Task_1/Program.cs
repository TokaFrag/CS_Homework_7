// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void PrintArr(int[,] array)
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

int GetNumber(string description)
{

    int number;
    Print($"{description} => ");

    while (true)
    {
        string temp = Console.ReadLine();
        if (int.TryParse(temp, out number))
        {
            return number;
        }
        Print($"This number \"{temp}\" is not correct. Try again. => ");
    }
}

void FindNumber(int[,] array, int indexRow, int indexCol)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);

    if (indexRow > row || indexCol > col)
    {
        Print("There is no such element");
    }
    else
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (i == indexRow && j == indexCol)
                {
                    Print($"Requested number => {array[i, j]}");
                }

            }
        }
    }

}

int indexRow = GetNumber("Enter the row index");
int indexCol = GetNumber("Enter the col index");
int[,] array = CreateArray(4, 4, 1, 9);
PrintArr(array);
FindNumber(array, indexRow, indexCol);
