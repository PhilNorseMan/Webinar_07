/*Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5*/

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
            matr[i, j] = i + j;
        }
    }
}

Console.WriteLine();
Console.WriteLine("The program will generate random two-dimensional array, where each element generates by A(m,n) = m + n, using your information.");
Console.WriteLine();

Console.WriteLine("Please, set the first dimension size of array (m):");
int firstDimension = int.Parse(Console.ReadLine()!);

Console.WriteLine("Please, set the second dimension size of array (n):");
int secondDimension = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] matrix = new int[firstDimension, secondDimension];

Console.WriteLine("Generated array is:");

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();