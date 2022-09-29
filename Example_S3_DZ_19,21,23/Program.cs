void Z19()
{
    /*
    Задача 19
    Напишите программу, которая принимает на вход пятизначное число и проверяет, 
    является ли оно палиндромом.
    14212 -> нет
    12821 -> да
    23432 -> да
    */

    Console.WriteLine("Enter the number: ");
    string number = Console.ReadLine();
    int len = number.Length;

    if (len == 5)
    {
        if (number[3] == number[1] && number[4] == number[0])
        {
            Console.WriteLine(number + " - this number is a palindrome");
        }
        else
        {
            Console.WriteLine(number + " - this number is not a palindrome");
        }
    }
    else
    {
        Console.WriteLine( number + " - not a five digit number");
    }
}
Z19();
void Z21()
{
    /*
Задача 21 (branch task_2)
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int x1 = ReadInt("Enter the X coordinate of the first point: ");
int y1 = ReadInt("Enter the Y coordinate of the first point: ");
int z1 = ReadInt("Enter the Z coordinate of the first point: ");
int x2 = ReadInt("Enter the X coordinate of the second point: ");
int y2 = ReadInt("Enter the Y coordinate of the second point: ");
int z2 = ReadInt("Enter the Z coordinate of the second point: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine("Cut length: " + length);


// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

}
//Z21();
void Z23()
{
    /*
    Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.WriteLine("Enter the Number: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{ 
    //Console.Write(i*i*i + ",");
    Console.Write($"{i*i*i}, ");
}

}
//Z23();

