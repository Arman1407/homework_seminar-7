// Транспонирование - 4

// Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали.

// Входные данные
// Первая строка входного файла INPUT.TXT содержит два натуральных числа N и M – количество строк и столбцов матрицы. В каждой из последующих N строк записаны M целых чисел – элементы матрицы. Все числа во входных данных не превышают 100 по абсолютной величине.

// Выходные данные
// В выходной файл OUTPUT.TXT выведите матрицу, полученную транспонированием исходной матрицы относительно горизонтали.

// Пример
// №	            INPUT.TXT	            OUTPUT.TXT

// 1	            3 4

//                  5 9 2 6                 1 2 8 7
//                  6 2 4 3                 6 2 4 3
//                  1 2 8 7	                5 9 2 6


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-30, 31); // [-30; 30]
        }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i, j]}\t");
    }
}

void ReverseArray(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0) / 2; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        int temp = matrix[i, j];
        matrix[i, j] = matrix[matrix.GetLength];
        matrix[matrix.GetLength] = temp;
        }
    }
    Console.WriteLine($"конечный массив");
}
    

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("начальный массив");
PrintMatrix(matrix);
ReverseArray(matrix);
// Console.WriteLine("конечный массив");
// PrintMatrix(matrix);


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// double[] array = new double[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join("; ", array)}]");
// ReverseArray(array);
// Console.WriteLine($"Конечный массив: [{string.Join("; ", array)}]");