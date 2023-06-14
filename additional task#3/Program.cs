// Задача 364. Заполнение диагоналями

// Даны два числа n и m.Создайте массив А[n][m] и заполниетеего, как показано на примере.

// Входные данные
// Программа получает на вход два числа n и m.

// Выходные данные
// Программа должна вывести полученный массив.

// Примеры 
// входные данные 
// 4 10

// выходные данные
// 1  1  3  6  10 14 18 22 26 30
// 2  4  7  11 15 19 23 27 31 34
// 5  8  12 16 20 24 28 32 35 37
// 9  13 17 21 25 29 33 36 38 39


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int number = 1;
for (int i = 1; i < matrix.GetLength(0) + matrix.GetLength(1) + 1; i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            if (j + k + 1 == i)
            {
                matrix[j, k] = number++;
            }
        }
    }
}
PrintMatrix(matrix);
