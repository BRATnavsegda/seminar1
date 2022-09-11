// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int GetNumber()
{
    int result = int.Parse(Console.ReadLine());
    return result;
}

int[,] GetRandomArray()
{
    Console.WriteLine("Enter the number of rows in the array:\t ");
    int rows = GetNumber();

    Console.WriteLine("Enter the number of columns in the array:\t ");
    int columns = GetNumber();

    Console.WriteLine("Enter the minimum possible number of the array:\t ");
    int minValue = GetNumber();

    Console.WriteLine("Enter the minimum possible number of the array:\t ");
    int maxValue = GetNumber();

    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int[,] PrintArray(int[,] array)
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
    Console.WriteLine();
    return array;
}
//PrintArray(GetRandomArray());

// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.

// Console.WriteLine("Enter the number of rows in the array:");
// int rows = GetNumber();

// Console.WriteLine("Enter the number of columns in the array:");
// int columns = GetNumber();

// int[,] array = new int[rows, columns];
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         array[i, j] = i + j;
//     }
// }
// PrintArray(array);

// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

int[,] SquaresEvenIndices(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }
        }
    }
    return array;
}

// PrintArray( SquaresEvenIndices( PrintArray (GetRandomArray())));

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int SumElementsMainDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += array[i, j];
            }
        }
    }
    Console.WriteLine($"{sum}");
    return sum;
}
/* SumElementsMainDiagonal(PrintArray (GetRandomArray())); */