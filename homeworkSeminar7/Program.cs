void LetsGo()
{
    while (true)
    {
        Console.WriteLine("Press Enter to continue... \n");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("№ 47. Задайте двумерный массив размером m * n, \nзаполненный случайными вещественными числами. \n");
        Console.WriteLine("№ 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, \nи возвращает значение этого элемента или же указание, что такого элемента нет. \n");
        Console.WriteLine("№ 52. Задайте двумерный массив из целых чисел. \nНайдите среднее арифметическое элементов в каждом столбце.");

        Console.WriteLine("Введите номер задачи выбранной для проверки, \n  или введите 0 для завершения... \n");
        int taskNumber = enterNumber();
        if (taskNumber == 47)
        {
            GetRandomDoubleArray();
        }
        else if (taskNumber == 50)
        {
            SearchingElementInArray();
        }
        else if (taskNumber == 52)
        {
            ArithmeticMeanElementsColumn();
        }
        else if (taskNumber == 0)
        {
            Console.WriteLine("\nАнекдот напоследок: \n\nВот чем хорош Интернет — он дает возможность высказаться каждому. \nА вот чем Интернет плох: он дает возможность высказаться каждому. \n\n"); break;
        }
        else
        {
            Console.WriteLine("Необходимо ввести номер задачи или 0 для выхода. \n Попробуйте еще раз...");
        }
    }
}
int enterNumber()
{
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

int[,] GetRandomArray() 
{
    Console.WriteLine("Enter the number of rows in the array:\t ");
    int rows = enterNumber();

    Console.WriteLine("Enter the number of columns in the array:\t ");
    int columns = enterNumber();

    Console.WriteLine("Enter the minimum possible number of the array:\t ");
    int minValue = enterNumber();

    Console.WriteLine("Enter the maximum possible number of the array:\t ");
    int maxValue = enterNumber();

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
    return array;
}


// Задача 47. Задайте двумерный массив размером m * n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetRandomDoubleArray()
{
    Console.WriteLine("Enter the number of rows in the array:\t ");
    int rows = enterNumber();

    Console.WriteLine("Enter the number of columns in the array:\t ");
    int columns = enterNumber();

    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {Math.Round(array[i, j], 2)} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
    return array;
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] SearchingElementInArray()
{
    Console.WriteLine("Enter the number of rows in the array:\t ");
    int rows = enterNumber();

    Console.WriteLine("Enter the number of columns in the array:\t ");
    int columns = enterNumber();

    Console.WriteLine("Enter the minimum possible number of the array:\t ");
    int minValue = enterNumber();

    Console.WriteLine("Enter the maximum possible number of the array:\t ");
    int maxValue = enterNumber();

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("This is your array, now enter item to search for\n ");

    Console.WriteLine("Enter the index of row for searchig item in the array:\t ");
    int row = enterNumber();

    Console.WriteLine("Enter the index of column for searchig item in the array:\t ");
    int column = enterNumber();
    if (row > rows && column > columns)
    {
        Console.WriteLine($"\nThe required element was not found in the array!!!");
    }
    else if (row <= rows && column <= columns)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[row, column] == array[i, j])
                {
                    Console.WriteLine($"Your item is {array[row, column]}");
                    break;
                }



            }

        }
    }
    Console.WriteLine();
    return array;
}



// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] ArithmeticMeanElementsColumn()
{
    int[,] array = GetRandomArray();
    Console.WriteLine();
    PrintArray(array);

    Console.Write("The arithmetic mean of the elements in each column... ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.Write($"{Math.Round(sum / array.GetLength(0), 2)}; ");
    }
    Console.WriteLine();
    return array;
}
LetsGo();