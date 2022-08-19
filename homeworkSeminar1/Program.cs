// >>>>>>>>>Задача 2<<<<<<<<<: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// System.Console.Write("Enter first number : ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter second number : ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if( number1 > number2)
// {
// Console.WriteLine( "First number more than second number");
// }
// else
// {
// Console.WriteLine( "Second number more than first number");
// }






//  >>>>>>>>Задача 4<<<<<<<<<: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// System.Console.Write("Enter first number : ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter second number : ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Enter third number : ");
// int number3 = Convert.ToInt32(Console.ReadLine());

// if( number1 > number2 && number1 > number3)
// {
// Console.WriteLine( number1 );
// }

// else if( number2 > number1 && number2 > number3)
// {
//     Console.WriteLine( number2 );
// }
// else
// {
// Console.WriteLine( number3);
// }





// >>>>>>>>>Задача 6<<<<<<<<<: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// System.Console.Write("Enter the number");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 2 == 0)
// {
//     System.Console.WriteLine("Yes, the entered number is even");
// }

// else
// {
//     System.Console.WriteLine("No, the entered number is not even");
// }




// >>>>>>>>>Задача 8<<<<<<<<<: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());

int step = 0;

while ((step < number) && (step < (number - 2)))
{
    step += 2;
    System.Console.Write($"{step}," );
}
if ( step == (number-2) )
{
    System.Console.Write(step+2);
}
