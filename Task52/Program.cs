/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


int GetNumber(string message)
{
    Console.Write(message);

    int result = 0;

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введены не числа.");
        }
    }
    return result;
}

int[,] InitArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];

    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)

            result[i, j] = rnd.Next(0, 10);
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

            Console.Write($"{array[i, j]} ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void GetSum(int[,] array, int rows, int columns)
{
    int[,] arr = new int[columns, rows];

    for (int i = 0; i < columns; i++)
    {
        double temp = 0;

        for (int j = 0; j < rows; j++)
        {
            temp += array[j, i];
        }
        Console.WriteLine($"Среднее арифметическое столбца ({i}) = {Math.Round(temp / rows, 1)} ");
    }
}

int rows = GetNumber("Введите количество строк массива: ");
int columns = GetNumber("Введите количество столбцов массива: ");

int[,] arr = InitArray(rows, columns);
PrintArray(arr);
GetSum(arr, rows, columns);