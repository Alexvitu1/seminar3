// System.Console.Write("Введите Х : ");
// int numX = int.Parse(Console.ReadLine());

// System.Console.Write("Введите Y : ");
// int numY = int.Parse(Console.ReadLine());

// if (numX > 0 && numY > 0)
// {
// System.Console.WriteLine("Секция 1");
// }
// else if (numX < 0 && numY > 0)
// {
// System.Console.WriteLine("Секция 2");
//  }
// else if (numX < 0 && numY < 0)
// {
// System.Console.WriteLine("Секция 3");
// }
// else if (numX > 0 && numY > 0)
// {
// System.Console.WriteLine("Секция 4");
// }

// System.Console.Write("Введите номер секции : ");
// int section = int.Parse(Console.ReadLine());

// if (section == 1)
// {
//     System.Console.Write("X > 0 и Y > 0");
// }
// else if (section == 2)
// {
//     System.Console.Write("X < 0 и Y > 0");
// }
// else if (section == 3)
// {
//     System.Console.Write("X < 0 и Y < 0");
// }
// else if (section == 4)
// {
//     System.Console.Write("X > 0 и Y > 0");
// }
// else{
//     System.Console.Write("Вы ввели неправильный номер секции");
// }
//  System.Console.Write("Введите номер секции : ");
//  int section = int.Parse(Console.ReadLine());

// switch (section)
// {
//     case 1:
//     System.Console.WriteLine("X > 0 и Y > 0");
//     break;
//     case 2:
//     System.Console.WriteLine("X < 0 и Y > 0");
//     break;    
//     case 3:
//     System.Console.WriteLine("X < 0 и Y < 0");
//     break;    
//     case 4:
//     System.Console.WriteLine("X > 0 и Y < 0");
//     break;
//     default:
//     System.Console.WriteLine("Вы ввели неправильный номер секции");
//     break;
// }

// System.Console.WriteLine("Введите сумму вклада: ");
// double sum = Convert.ToDouble(Console.ReadLine());
// if (sum <= 100)
// {
//     sum = sum*1.05;

// System.Console.WriteLine($"Итоговая сумма {sum}");
// }
// else if (sum > 100 && sum < 200)
// {
//      sum = sum*1.07;

// System.Console.WriteLine($"Итоговая сумма {sum}");   
// }
// else if (sum >= 200)
// {
//      sum = sum*1.1;

// System.Console.WriteLine($"Итоговая сумма {sum}");   
// }

// задача 3

// System.Console.WriteLine("Введите координату X точки А: ");
// int korXA = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите координату Y точки A: ");
// int korYA = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите координату X точки B: ");
// int korXB = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите координату Y точки B: ");
// int korYB = int.Parse(Console.ReadLine());

// double rastAB = Math.Sqrt((korXB - korXA)*(korXB - korXA) + (korYB - korYA)*(korYB - korYA));

// Console.WriteLine($"Расстояние между точками АВ {rastAB}");


// задача 4

// System.Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// for (int i = 1; i <= num; i++)
// {
//     Console.Write($" {i*i}");
// }

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// System.Console.WriteLine("Введите пятизначное число: ");
// int num = int.Parse(Console.ReadLine());

// if (num <= 99999 && num > 9999)
// {
//     if (num % 10 == num / 10000 % 10 && num / 10 % 10 == num / 1000 % 10)
//     {
//         System.Console.WriteLine("Введенное число палиндром");
//     }
//     else{
//         System.Console.WriteLine("Введенное число НЕ палиндром");

//     }

// }
// else 
// {        
//     System.Console.WriteLine("Вы ввели не пятизначное число");
// }

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// System.Console.WriteLine("Введите координату X точки А: ");
// int x1 = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите координату Y точки A: ");
// int y1 = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите координату Z точки A: ");
// int z1 = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите координату X точки B: ");
// int x2 = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите координату Y точки B: ");
// int y2 = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите координату Z точки B: ");
// int z2 = int.Parse(Console.ReadLine());

// double rastAB = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));

// Console.WriteLine($"Расстояние между точками АВ {rastAB}");

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.Write($" {i*i*i}");
}

