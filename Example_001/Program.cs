// Задайте двумерный массив размером m*n, заполненный случайными целыми числами.

void PrintArray(int[,] arr)
{
    int count_x = arr.GetLength(0);
    int count_y = arr.GetLength(1);
    
    for (int i = 0; i < count_x; i++)
    {
        for (int j = 0; j < count_y; j++)
            Console.Write(arr[i, j] + "    ");
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

Console.WriteLine();
Console.WriteLine("The program will generate random two-dimensional array, using your information.");
Console.WriteLine();

Console.WriteLine("Please, set the first dimension size of array:");
int firstDimension = int.Parse(Console.ReadLine()!);

Console.WriteLine("Please, set the second dimension size of array:");
int secondDimension = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] matrix = new int[firstDimension, secondDimension];

Console.WriteLine("Generated array is:");

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();