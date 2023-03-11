// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int leftBorder, int rightBorder)
{
    int[,] matrix = new int[rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SummaryOfRows(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        Console.WriteLine($"Сумма чисел в строке равна = {sum}");     
    }
}

int m = ReadNumber("Введите количество строк:");
int n = ReadNumber("Введите количество столбцов:");

int[,] myMatrix = GetRandomMatrix(m, n, 0, 10);
PrintMatrix(myMatrix);
SummaryOfRows(myMatrix);
