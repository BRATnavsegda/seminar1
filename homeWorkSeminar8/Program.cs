void LetsGo()
{
    while (true)
    {
        Console.WriteLine("Press Enter to continue... \n");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("№ 54: Задайте двумерный массив. Напишите программу, \nкоторая упорядочит по убыванию элементы каждой строки двумерного массива. \n");
        Console.WriteLine("№ 56: Задайте прямоугольный двумерный массив. Напишите программу, \nкоторая будет находить строку с наименьшей суммой элементов. \n");
        Console.WriteLine("№ 58: Задайте две матрицы. Напишите программу, \nкоторая будет находить произведение двух матриц.");
        Console.WriteLine("№ 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. \nНапишите программу, которая будет построчно выводить массив, \nдобавляя индексы каждого элемента. \n");
        Console.WriteLine("№ 62: Напишите программу, которая заполнит спирально массив 4 на 4. \n");


        Console.WriteLine("Введите номер задачи выбранной для проверки, \n  или введите 0 для завершения... \n");
        int taskNumber = enterNumber();
        if (taskNumber == 54)
        {
            SortInDescendingOrderInRows();
        }
//         else if (taskNumber == 56)
//         {
//             ;
//         }
//         else if (taskNumber == 58)
//         {
//             ;
//         }
//         else if (taskNumber == 60)
//         {
//             ;
//         }
//         else if (taskNumber == 62)
//         {
//             ;
//         }

        else if (taskNumber == 0)
        {
            Console.WriteLine("\nАнекдот напоследок: \n\nНичто не помогает так по хозяйству, как вырубленный интернет!\n\n"); break;
        }
//         else
//         {
//             Console.WriteLine("Необходимо ввести номер задачи или 0 для выхода. \n Попробуйте еще раз...");
//         }
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

    Console.Clear();


    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
            Console.Write($"{result[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("This is your array");
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

// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[] BubbleSort(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}

void SortInDescendingOrderInRows()
{
    int[,] array = GetRandomArray();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[,] result = new int[rows, columns];
    int[] row = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            row[j] = array[i, j];
        }
        BubbleSort(row);
        for (int k = 0; k < rows; k++)
        {
            result[i, k] = row[k];
        }


        Console.WriteLine();
    }
    PrintArray(result);
    Console.WriteLine("This is your sorted array");
}



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка



// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)





// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


LetsGo();