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
    if (randomov > 99 && randomov < 1000)
    {
    Console.WriteLine ("There is the 2th number - " + randomov / 10 % 10);
    }
    else
    {
      Console.WriteLine ("non-three-digit number entered");
    }
}
//Z_10();
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

int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);  
if (number > 99)
{
  while (number > 999)
  {
      number /=10;
  }
  Console.WriteLine("Третья цифра числа" + number%10);
}
else 
{
  Console.WriteLine("- There is no third number");
}

}
//Z_13 ();
void Z_15 () 
//Z_13();

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
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
void NeedForSpeed()
{
DateTime lastTime = DateTime.Now;
int number = 123;
for (int i = 0; i < 100000000; i++)
{
  var n = Convert.ToString(number)[1]; //var n = number/10%10;
}
Console.WriteLine(DateTime.Now - lastTime);
}
//NeedForSpeed();
