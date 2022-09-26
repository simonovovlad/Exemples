void Z_9()
{
    // Random randomov = new Random();
    // int number = randomov.Next(10, 100);
    Console.WriteLine("Enter the number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int tens = number / 10;
    int ones = number % 10;

    Console.WriteLine(tens);
    Console.WriteLine(ones);

    int max = tens;
    int min = tens;

    if (ones > max) max = ones;
    if (ones < max) min = ones;
    if (Convert.ToBoolean(max == min)) Console.WriteLine("Числа равны");
    else
    {
    Console.Write("Большее: ");
    Console.WriteLine(max);
    Console.Write("Меньшее: ");
    Console.WriteLine(min);
    }
}
//Z_9();

void Z_11()
{
    int randomov = new Random().Next(100, 1000);
    // int number1 = randomov / 100;
    // int number2 = randomov % 10;
    // String number3 = Convert.ToString(number1) + Convert.ToString(number2);
    // Console.WriteLine(randomov);
    // Console.WriteLine(number3);
    int randomov1 = randomov / 100;
    int randomov2 = randomov / 10 % 10;
    int randomov3 = randomov % 10;
    Console.WriteLine(randomov);
    Console.WriteLine ("" + randomov1 + "," + randomov3);
}
//Z_11();

void Z_12()
// Напишите программу, которая будет принимать
// на вход два числа и выводить, является ли второе
// число кратным первому. Если число 2 не кратно числу
// 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
{
Console.WriteLine("Введите делимое: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите делитель: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = number1 % number2;
if (number1 % number2 == 0)
    {
    Console.WriteLine(number1 + " - кратно " + number2);
    }
else
    {
    Console.WriteLine(number1 + " - не кратно " + number2);
    Console.WriteLine(number3 + " - остаток ");
    }

}
Z_12();