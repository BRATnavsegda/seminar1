void LetsGo()
{
    while (true)
    {
    Console.WriteLine("Press Enter to continue... \n");
    Console.ReadLine();
    Console.Clear();
    
    Console.WriteLine("№ 41: Пользователь вводит с клавиатуры M чисел. \nПосчитайте, сколько чисел больше 0 ввёл пользователь.\n");
    Console.WriteLine("№ 43: Напишите программу, которая найдёт точку пересечения двух прямых, \nзаданных уравнениями y = k1 * x + b1, y = k2 * x + b2; \nзначения b1, k1, b2 и k2 задаются пользователем. \n");
    
    Console.WriteLine("Введите номер задачи выбранной для проверки, \n  или введите 0 для завершения... \n");
    int taskNumber = Convert.ToInt32(Console.ReadLine());
    if (taskNumber == 41)
    {
        CountingPositiveNumbers();
    }
    else if (taskNumber == 43) 
    {
        IntersectionTwoStraightLines();
    }
    else if (taskNumber == 0)
    {
        Console.WriteLine("Анекдот на последок: \n\nInstagram был заблокирован в России. \nКоличество пользователей из Нидерландов увеличилось на 59 млн. \n"); break;
    }
    else
    {
        Console.WriteLine("Необходимо ввести номер задачи или 0 для выхода. \n Попробуйте еще раз...");
    }
    }
}
int enterNumber()
{
    int userNumber = int.Parse(Console.ReadLine());
    return userNumber;
}
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void CountingPositiveNumbers()
{
Console.WriteLine("How many numbers would you like to check? \n");
int lengthArray = enterNumber();
int[] userArray = new int[lengthArray];
int userNumber = 0;
int count = 0;

Console.WriteLine($"Enter {lengthArray} numbers to check. \n \nAfter each number entered, press Enter");
for (int i = 0; i < lengthArray; i++)
{
    userNumber = enterNumber();
    userArray[i] = userNumber;
    if (userNumber > 0)
    {
        count++;
    }
}

Console.WriteLine($"\nYou numbers: {String.Join(", ", userArray)};");
Console.WriteLine($"The number of positive numbers is equal to {count};");
}



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectionTwoStraightLines()
{
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
}
LetsGo();