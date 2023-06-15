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
        matrix[i, j] = new Random().Next(1, 31); // [1; 30]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void ReverseMatrix(int[,] matrix)
{
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[0, j];
            matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
            matrix[matrix.GetLength(0) - 1, j] = temp;
            // matrix[0, j] ++;
            // for(int i = 0; i < matrix.GetLength(1); i++)
            // {
            //     int temp1 = matrix[1, j];
            //     matrix[1, j] = matrix[matrix.GetLength(0) - 2, j];
            //     matrix[matrix.GetLength(0) - 2, j] = temp1;
            // } 

        }

}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
ReverseMatrix(matrix);
PrintMatrix(matrix);
 // Как перевернуть весь массив, а не только первую и последнюю строкку?
