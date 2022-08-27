// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.WriteLine("Укажите любое пятизначное число для проверки - является ли оно палиндромом.");
// string insertNum = Convert.ToString(Console.ReadLine());

// char[] reverseNum = insertNum.ToArray<char>();

// Array.Reverse(reverseNum);

// string reverseText = new string(reverseNum);

// //Console.WriteLine(reverseText);
// if (reverseText == insertNum)
// {
//     Console.WriteLine("Введенное число является палиндромом.");
// }
// else
// {
//     Console.WriteLine("Это не число-палиндром.");
// }




// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Enter x1...");
// double x1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter y1...");
// double y1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter z1...");
// double z1 = int.Parse(Console.ReadLine());


// Console.WriteLine("Enter x2...");
// double x2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter y2...");
// double y2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter z2...");
// double z2 = int.Parse(Console.ReadLine());

// double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)+ Math.Pow((z2 - z1), 2));

// Console.WriteLine($"Координаты точки A ({x1},{y1},{z1});");
// Console.WriteLine($"Координаты точки B ({x2},{y2},{z2});");
// Console.WriteLine($"Расстояние между точками А и В в 3D пространстве {result:f2}.");





// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число...");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Таблица кубов чисел от 1 до {number}");
for (int i = 1; i <= number; i++)

{

    Console.Write($"{Math.Pow(i, 3)}, ");
}
