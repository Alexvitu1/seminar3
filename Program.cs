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

System.Console.Write("Введите номер секции : ");
int section = int.Parse(Console.ReadLine());

if (section == 1)
{
    System.Console.Write("X > 0 и Y > 0");
}
else if (section == 2)
{
    System.Console.Write("X < 0 и Y > 0");
}
else if (section == 3)
{
    System.Console.Write("X < 0 и Y < 0");
}
else if (section == 4)
{
    System.Console.Write("X > 0 и Y > 0");
}
else{
    System.Console.Write("Вы ввели неправильный номер секции");


}






