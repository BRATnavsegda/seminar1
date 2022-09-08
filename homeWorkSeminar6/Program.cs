
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("How many numbers would you like to check? \n");
// int lengthArray = int.Parse(Console.ReadLine());
// int[] userArray = new int[lengthArray];
// int userNumber = 0;
// int count = 0;

// Console.WriteLine($"Enter {lengthArray} numbers to check. \n \nAfter each number entered, press Enter");
// for (int i = 0; i < lengthArray; i++)
// {
//     userNumber = int.Parse(Console.ReadLine());
//     userArray[i] = userNumber;
//     if (userNumber > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"\nYou numbers: {String.Join(", ", userArray)};");
// Console.WriteLine($"The number of positive numbers is equal to {count};");




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Enter number for b1");
float b1 = float.Parse(Console.ReadLine());

Console.WriteLine("Enter number for b2");
float b2 = float.Parse(Console.ReadLine());

Console.WriteLine("Enter number for k1");
float k1 = float.Parse(Console.ReadLine());

Console.WriteLine("Enter number for k2");
float k2 = float.Parse(Console.ReadLine());


float x = (b2 - b1) / (k1 - k2);
float y = k1 * x + b1;

Console.WriteLine($"The intersection point of the given lines will be -> {x}:{y} ");