// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


var matrix = new int[4, 4];
Spiral(matrix);
Print(matrix);


void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            System.Console.Write(matrix[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] Spiral(int[,] matrix)
{
    int number = 1;
    int size = 4;
    int maxNumber = size - 1;
    int i = 0;
    int j = 0;

    while (number <= size*size)
    {
        matrix[i, j] = number;
        number++;
        if (i <= j + 1 && i + j < maxNumber)
            j++;
        else if (i < j && i + j >= maxNumber)
            i++;
        else if (i >= j && i + j > maxNumber)
            j--;
        else
            i--;
    }
        return matrix;
            
}
