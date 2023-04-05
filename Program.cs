// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

if (num <= 99999 && num > 9999)
{
  if (num % 10 == num / 10000 % 10 && num / 10 % 10 == num / 1000 % 10)
    {
         System.Console.WriteLine("Введенное число палиндром");
    }
     else{
         System.Console.WriteLine("Введенное число НЕ палиндром");
     }

 }
 else 
 {        
     System.Console.WriteLine("Вы ввели не пятизначное число");
 }

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


 System.Console.WriteLine("Введите координату X точки А: ");
 int x1 = int.Parse(Console.ReadLine());
 System.Console.WriteLine("Введите координату Y точки A: ");
 int y1 = int.Parse(Console.ReadLine());
 System.Console.WriteLine("Введите координату Z точки A: ");
 int z1 = int.Parse(Console.ReadLine());
 System.Console.WriteLine("Введите координату X точки B: ");
 int x2 = int.Parse(Console.ReadLine());
 System.Console.WriteLine("Введите координату Y точки B: ");
 int y2 = int.Parse(Console.ReadLine());
 System.Console.WriteLine("Введите координату Z точки B: ");
 int z2 = int.Parse(Console.ReadLine());

 double rastAB = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));

 Console.WriteLine($"Расстояние между точками АВ {rastAB}");

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

