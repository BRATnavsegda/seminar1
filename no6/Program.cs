// Решение в группах задач:
// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

// void Triangle()
// {
//     Console.WriteLine("Введите число 1: ");
//     int num1 = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Введите число 2: ");
//     int num2 = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Введите число 3: ");
//     int num3 = Convert.ToInt32(Console.ReadLine());

//     if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2)
//     {
//         Console.WriteLine("Такой треугольник возможен");
//     }
//     else
//     {
//         Console.WriteLine("Такой треугольник не может существовать");
//     }
// }

// Triangle();

// Задача 42:
// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45
// --> 101101
// 3
// --> 11
// 2
// --> 10

// Console.WriteLine("Введите число для преобразования: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int count = 0;
// int temp = number;
// while (number != 0)
// {
//         number = number / 2;
//         count++;
// }

// int[] binArray = new int[count];
// count--;
// while (temp != 0)
// {
//     binArray[count] = temp%2;
//     temp = temp / 2;
//     count--;
// }
// Console.WriteLine(String.Join(" ", binArray));

// Решение через bool

// System.Console.WriteLine("Введите число: ");

// int num = Convert.ToInt32(Console.ReadLine());

// bool[] array = Num2(num);

// System.Console.WriteLine(String.Join("", array));
// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.Write(Convert.ToInt32(array[i]));
// }
// bool[] Num2 (int num)
// {

// int result = 0;
// bool[] arr = new bool[32];
// int i;
// for (i = 0; num > 0; i++)
// {
//     result = num%2;
//     num = num/2;
//     arr[arr.Length -1 -i] = Convert.ToBoolean(result);
// }
// return arr;
// }


// Решение в группах задач:
// Задача 44:
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5
// --> 0 1 1 2 3
// Если N = 3
// --> 0 1 1
// Если N = 7
// --> 0 1 1 2 3 5 8

// Console.WriteLine("Введите число для преобразования: ");
// int number = Convert.ToInt32(Console.ReadLine());



// Задача 45:
// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] newArray = new int[4];

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

FillArray(newArray);


