/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

/* АЛГОРИТМ
1. Метод получения чисел из консоли
2. Инициализация двухмерного массива
3. Печать двухмерного массива
*/

int GetNumber(string message)
{
    int result = 0;

    Console.Write(message);

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено не число. Повторите ввод: ");
        }
    }
    return result;
}

double[,] InitArray(int rows, int colums, int leftBound, int rightBound)
{
    double[,] result = new double[rows, colums];

    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)

            result[i, j] = Math.Round(rnd.NextDouble() + rnd.Next(leftBound, rightBound), 1);

    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

            Console.Write($"{array[i, j]}  ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int rows = GetNumber("Введите количество строк: ");
int colums = GetNumber("Введите количество столбцов: ");
int leftBound = GetNumber("Введите левую границу значений: ");
int rightBound = GetNumber("Введите правую границу значений: ");

double[,] arr = InitArray(rows, colums, leftBound, rightBound);

PrintArray(arr);