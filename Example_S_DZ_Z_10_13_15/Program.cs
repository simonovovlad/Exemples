void Z_10()
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
{
    Console.WriteLine("Enter the number: ");
    int randomov = Convert.ToInt32(Console.ReadLine());
    //int randomov = new Random().Next(100, 1000);
    int randomov2 = randomov / 10 % 10;
    Console.WriteLine(randomov);
    Console.WriteLine (randomov2);
}
Z_10();
void Z_13()
{
// Задача 13: Напишите программу, которая с помощью деления выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 3267432979 -> 6

// Console.WriteLine("Enter the number: ");
// int randomov = Convert.ToInt32(Console.ReadLine());
// int randomov3 = randomov % 10;

Console.Write("Введи число: ");
int randomov = Convert.ToInt32(Console.ReadLine());
string randomov3 = Convert.ToString(randomov);
if (randomov3.Length > 2)
{
  Console.WriteLine("third - " + randomov3[2]);
}
else 
{
  Console.WriteLine("- There is no third number");
}
}
//Z_13();

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void Z_15 () 
{
  Console.WriteLine("Введите номер деня недели: ");
  int day = Convert.ToInt32(Console.ReadLine());
  
  if (day == 6 || day == 7) 
  {
  Console.WriteLine("это выходной");
  }
  else if (day < 1 || day > 7) 
  {
    Console.WriteLine("не является днем недели");
  }
  else Console.WriteLine("не выходной");
}
//Z_15 ();