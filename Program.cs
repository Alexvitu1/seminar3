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

System.Console.WriteLine("Введите координату X точки А: ");
int korXA = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату Y точки A: ");
int korYA = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату X точки B: ");
int korXB = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату Y точки B: ");
int korYB = int.Parse(Console.ReadLine());

double rastAB = Math.Sqrt((korXB - korXA)*(korXB - korXA) + (korYB - korYA)*(korYB - korYA));

Console.WriteLine($"Расстояние между точками АВ {rastAB}");

