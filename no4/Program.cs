// Задача 26: Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.
// void Number(string? data)
// {
//     int number;

//     while (true)
//     {
//         if (int.TryParse(data, out number))
//         {
//             break;
//         }
//         else
//         {
//             Console.WriteLine("Ошибка ввода");
//             data = Console.ReadLine();
//         }
//     }
//     int num = (int)Math.Log10(number) + 1;
//     Console.WriteLine($"Здесь будет количество цифр {num}");
// }

// Console.WriteLine("Введите число, для получения количества цифр в числе!");

// Number(Console.ReadLine());

// Задача 28: Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// int result = 1;

// for (int i = 2; i <= number; i++)
// {
//     result = result * i;
// }
// Console.WriteLine($"Произведение чисел от 1 до {number} равно {result}");

// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.


Console.Clear();

int[] mas = new int [8];

for (int i = 0; i < mas.Length; i++)
{
    //Random rnd = new Random();

    mas[i] = new Random().Next(0,2);
    Console.Write(mas[i]);
}
