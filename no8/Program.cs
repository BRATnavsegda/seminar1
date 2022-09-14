


int[,] GetRandomArray()
{
    // Console.WriteLine("Enter the number of rows in the array:\t ");
    // int rows = enterNumber();

    // Console.WriteLine("Enter the number of columns in the array:\t ");
    // int columns = enterNumber();

    // Console.WriteLine("Enter the minimum possible number of the array:\t ");
    // int minValue = enterNumber();

    // Console.WriteLine("Enter the maximum possible number of the array:\t ");
    // int maxValue = enterNumber();
    Console.Clear();
    Random rnd = new Random();

    int[,] array = new int[rnd.Next(3, 5), rnd.Next(3, 5)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
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

// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

int[,] ChangeFirstLastRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        var temp = array[array.GetLength(0) - 1, i];

        array[array.GetLength(0) - 1, i] = array[0, i];
        array[0, i] = temp;

    }
    return array;
}

// PrintArray(ChangeFirstLastRow(GetRandomArray()));

// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

int[,] TurnArray(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    int[,] arr = new int[row, column];
    if (row == column)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                arr[i, j] = array[j, i];
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
            
        }
        return arr;
    }
    else
    {
        Console.WriteLine("Невозможно развернуть такой массив \n");
        return array;
    }

}
// TurnArray(GetRandomArray());

// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных.

void DictionaryArrayElements(int[,] array)
{
int m = array.GetLength(0);
int n = array.GetLength(1);
int trg = 0;
int[,] dict = new int[m * n, 2];
int k = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
trg = 0;
for (int r = 0; r < k; r++)
{
if (dict[r, 0] == array[i, j])
{
dict[r, 1]++;
trg = 1;
break;
}

}
if (trg == 0)
{
//dict = new int[k+1,2] (dict);
dict[k, 0] = array[i, j];
dict[k, 1]++;
k++;
}
}
}

for (int i = 0; i < k; i++)
{
for (int j = 0; j < dict.GetLength(1); j++)
{
Console.Write($"{dict[i, j]} ");
}
System.Console.WriteLine();
}
}

DictionaryArrayElements(GetRandomArray());