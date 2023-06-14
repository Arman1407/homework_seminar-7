// Задача 50. 

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такой позиции нет
// 1 2 -> 4



void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = new Random().Next(1, 11); 
    }
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i, j]}\t");
        Console.WriteLine();
    }
}

void MatrixExchange(int[,] matrix, int number = 0, int n = 0, int m = 0)
{
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        if (i != n && j != m)
        number = matrix[i, j];
        // matrix[i, j] = matrix[i, j];
        }
    }
}

// string SearchNumber(int[,] matrix, int number = 1)
// {
//     foreach (int element in matrix)
    
//     if (element == number)
// // return "yes";
//     Console.WriteLine("элемент массива = ");
//     else (element > number);
//     Console.WriteLine($"такого элемента массива нет");
// // return "no";
// }



Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);
MatrixExchange(matrix);
// SearchNumber(matrix);
Console.WriteLine();
Console.Write("Введите позицию элемента в массиве: ");
int[] n = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] m = new int[n[0], n[1]];
Console.WriteLine();
Console.WriteLine($"элемент массива = {MatrixExchange(matrix)}");

Console.WriteLine($"такого элемента массива нет");


