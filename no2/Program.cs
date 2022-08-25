using System;

namespace Seminar2
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     MaxNumber2();
        // }

        // 9. Напишите программу, кторая выводит случайное число из отрезка (10, 999)
        // и показывает наибольшую цифру числа.

        // static void MaxNumber2()
        // {
        //     int number = new Random().Next(10, 100);
        //     int number1 = number % 10;
        //     int number2 = number / 10;

        //     int max = number1;

        //     if (number1 < number2)
        //     {
        //         max = number2;
        //     }
        //     System.Console.WriteLine($"Max {max}");

        // int number1 = new Random().Next(10, 1000);

        // int max = 0;

        // int iterator = number1;
        // while (iterator !=0)
        // {
        //     int number2 = iterator % 10;
        // }
        //   11. Напишите программу, которая выводит случайное трёхзначное число
        // и удаляет вторую цифру этого числа.

        static void Main(string[] args)
        {
            SecondNumber();
        }
        static void SecondNumber()
        {
            int number = new Random().Next(100, 1000);
            int result = (number / 100 * 10) + (number % 10);
            System.Console.WriteLine($"Number={number}; result = {result}");

        }
    }
}