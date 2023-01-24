/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

/* АЛГОРИТМ
1. Метод получения чисел из консоли
2. Инициализация массива
3. Печать массива
4. Поиск заданного элемента
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

int[,] InitArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindArrayElement(int[,] array, int p, int q)
{
    if (p >= array.GetLength(0) || q >= array.GetLength(1))
    {
        Console.WriteLine($"Числа с заданными индексами N[{p}][{q}] в массиве нет.");
    }
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(p == i && q == j)
                {
                    Console.WriteLine($"Значение элемента N[{p}][{q}] = {array[i, j]} ");
                }
            }
        }

    }
}

int p = GetNumber("Поиск элемента по индексу в строке: ");
int q = GetNumber("Поиск элемента по индексу в столбце: ");
int rows = GetNumber("Введите количество строк в массиве: ");
int columns = GetNumber("Введите количество столбцов в массиве: ");

int[,] arr = InitArray(rows, columns);

PrintArray(arr);
FindArrayElement(arr, p, q);