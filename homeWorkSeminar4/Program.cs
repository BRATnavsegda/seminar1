// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число, которое надо возвести в степень ");
// int number = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число, которое будет степенью первого ");
// int numberDegree = int.Parse(Console.ReadLine());
// int result = 1;
// for (int i = 0; i < numberDegree; i++)
// {
//     //int temp = (number * number);
//     result = result * number;
// }

// Console.WriteLine($"Число {number} в {numberDegree} степени, будет равно {result}");


// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число, цифры которого необходимо сложить ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = 0;
// while (number > 0)
// {
//    result = result + (number % 10);
//    number /= 10;
// }
// Console.WriteLine($"Сумма цифр введенного числа будет равна - {result}");

// Задача 29: Напишите программу, которая задаёт массив из введенного числа
// и выводит их на экран.  пользователь вводит число элементов в массиве
// и минимальное, и максимальное значение . надо заполнить массив рандомными данными
// от минимального до максимального значения .
// И важное уточнение , делать все в методе который возвращает массив.
// 5, 1, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 33 -> [6, 1, 33]

// Вот так:
// int[] Massiv(int num1, int num2, int num3)
// {
//     int[] array = new int[num1];
//     Random rand = new Random();
//     for (int i = 0; i < array.Length; i++)
//         array[i] = rand.Next(num2, num3);
//     Console.WriteLine($"You array: {String.Join(", ", array)}");
//     return array;
// }

// Massiv(5,1,20);

// Или вот так:
int[] Massiv()
{
    Console.WriteLine("Введите число элементов в массиве ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите минимально возможное число массива ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите максимально возможное число массива ");
    int num3 = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[num1];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(num2, num3);
    Console.WriteLine($"You array: {String.Join(", ", array)}");
    return array;
}

Massiv();