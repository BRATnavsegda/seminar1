// Задача 18: Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y).


// Console.WriteLine("Enter quater...");
// int quarterNumber = int.Parse(Console.ReadLine());

// if (quarterNumber == 1)
// {
//     Console.WriteLine("x>0, y>0");
// }

// else if (quarterNumber == 2)
// {
//     Console.WriteLine("x<0, y>0");
// }

// else if (quarterNumber == 3)
// {
//     Console.WriteLine("x<0, y<0");
// }
// else if (quarterNumber == 4)
// {
//     Console.WriteLine("x>0, y<0");
// }
// else 
// {
//     Console.WriteLine("Bug Error");
// }
// Задача 21: Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 2D пространстве.

// Console.WriteLine("Enter x1...");
// double x1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter y1...");
// double y1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter x2...");
// double x2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter y2...");
// double y2 = int.Parse(Console.ReadLine());

// double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));

// Console.WriteLine($"A ({x1},{y1}); B ({x2},{y2}) -> {result:f2}");

// Задача 22: Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine("Enter number...");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица квадратов");
for (int i = 1; i <= number; i++)

{

    Console.WriteLine(Math.Pow(i, 2));
}
