// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// int[] newArray = new int[4];

// int[] FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// FillArray(newArray);

// void CountOfEvenNum(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     Console.WriteLine($"You array: {String.Join(", ", array)}");
//     Console.WriteLine($"{count} even numbers in this array");


// }
// CountOfEvenNum(newArray);




// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] EnterRandomArray()
// {
//     Console.Write("Enter length of array...\t");
//     int number = Convert.ToInt32(Console.ReadLine());

//     int[] array = new int[number];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-100, 100);
//     }
//     Console.WriteLine($"You array: {String.Join(", ", array)}");
//     return array;
// }

// void SummOfElementsInOddPositions(int[] array)
// {   
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0) sum += array[i];
//     }
//     Console.WriteLine($"The sum of elements in odd positions -> {sum}.");
// }

// int[] array = EnterRandomArray();
// SummOfElementsInOddPositions(array);




// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] EnterRandomArray()
// {
//     Console.Write("Enter length of array...\t");
//     int number = Convert.ToInt32(Console.ReadLine());

//     int[] array = new int[number];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 10);
//     }
//     Console.WriteLine($"You array: {String.Join(", ", array)}");
//     return array;
// }

// int[] array = EnterRandomArray();

// void ProductOfPairsOfNumbers(int[] array)
// {
//     int lengthNewArray = 0;
//     if (array.Length % 2 == 0)
//     {
//         lengthNewArray = array.Length / 2;
//     }
//     else
//     {
//         lengthNewArray = (array.Length / 2) + 1;
//     }
//     int[] newArray = new int[lengthNewArray];
//     int temp = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         temp = (array[i] * array[(array.Length - 1) - i]);
//         if (i < newArray.Length - 1)
//         {
//             newArray[i] = temp;
//             temp = 0;
//         }
//         else if (i == newArray.Length - 1 && array.Length % 2 == 0)
//         {

//             newArray[i] = temp;
//             break;

//         }
//         else
//         {
//             newArray[i] = array[i];
//             break;
//         }
//     }

//     Console.WriteLine($"You new array: {String.Join(", ", newArray)}");
// }

// ProductOfPairsOfNumbers(array);






// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


// double[] EnterRandomDoubleArray()
// {
//     Console.Write("Enter length of array...\t");
//     int number = Convert.ToInt32(Console.ReadLine());

//     double[] array = new double[number];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().NextDouble()*100;
//     }
//     Console.WriteLine($"You array: {String.Join(", ", array)}");
//     return array;
// }


// void DifferenceOfMaxAndMinNumOfArray(double[] array)
// {
// double maxNumber = array[0], minNumber = array[0];
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > maxNumber)
//     {
//         maxNumber = array[i];
//     }
//     else if (array[i] < minNumber)
//     {
//         minNumber = array[i];
//     }
// }
// double result = maxNumber - minNumber;
// Console.WriteLine($"The difference between the maximum and minimum elements of the array will be -> {result}");
// }

// double[] array = EnterRandomDoubleArray();
// DifferenceOfMaxAndMinNumOfArray(array);