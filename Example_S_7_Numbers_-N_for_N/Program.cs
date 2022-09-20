//Напишите программу каторая на вход принимает одно число (N),
//а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Enter the number ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);
int num2 = -num;
while (num2 <= num)
{
    Console.Write(num2 + ", ");
    num2 = num2 + 1;
}

