/*Objective_003
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/

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

int DiagonalSum(int[,] arr)
{
    int count_x = arr.GetLength(0);
    int count_y = arr.GetLength(1);
    int result = 0;

    int[,] quadArr = new int[count_x, count_y];
    
    for (int i = 0; i < count_x; i++)
    {
        for (int j = 0; j < count_y; j++)
        {
            if(i == j)
            
                result += arr[i,j];
        }
    }
    return result;
}


Console.WriteLine();
Console.WriteLine("The program will generate random two-dimensional array, using your information.");
Console.WriteLine("Than programm will summ numbers on the main diagonal.");
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

Console.WriteLine($"Result of operation is: {DiagonalSum(matrix)}");
Console.WriteLine();