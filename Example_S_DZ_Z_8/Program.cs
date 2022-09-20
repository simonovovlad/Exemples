//Напишите программу каторая на вход принимает одно число (N),
//а на выходе показывает все четные числа в промежутке от 1 до N.

Console.WriteLine("Enter the number ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);
int num2 = 2;
while (num2 <= num)
{
    Console.Write(num2 + ", ");
    num2 = num2 + 2;
}
