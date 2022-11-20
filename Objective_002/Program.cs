/*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2         1   4   49  2
5 9 2 3         5   9   2   3
8 4 2 4         64  4   4   4*/

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

int[,] SquareElementsEvenIndex(int[,] arr)
{
    int count_x = arr.GetLength(0);
    int count_y = arr.GetLength(1);

    int[,] quadArr = new int[count_x, count_y];
    
    for (int i = 0; i < count_x; i++)
    {
        for (int j = 0; j < count_y; j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                quadArr[i,j] = arr[i,j] * arr[i,j];
            }
            else
            {
                quadArr[i,j] = arr[i,j];
            }
        }
    }
    return quadArr;
}


Console.WriteLine();
Console.WriteLine("The program will generate random two-dimensional array, using your information.");
Console.WriteLine("Than programm will square numbers with both even indexes.");
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

Console.WriteLine("Result of operation is:");
int[,] squareArray = SquareElementsEvenIndex(matrix);
PrintArray(squareArray);
Console.WriteLine();