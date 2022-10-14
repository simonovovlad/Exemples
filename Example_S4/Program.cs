void Z24()//Выдаёт сумму чисел
{
    /* Задача 24: Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел */
int Number = 5;
int sum = 0;

for (int i = 1; i <= Number; i++)
    { 
        //Console.Write($"{i} + ");
        sum += i;
    }
    Console.Write(sum);
}
//Z24();

void Z26()//Выдаёт количество цифр в числе 
{
    /* Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе. */
    Console.WriteLine("Enter The Number: ");
    string Number = Console.ReadLine();
    Console.WriteLine(Number.Length);
    // int current = Number;
    // int count = 0;
    // for (count = 0; current > 0; count++)
    //     { 
    //         current = current / 10;
    //     }
    // Console.Write($"Number of digits in a number : {Number} = {count}");
}
//Z26();

void Z28()//Выдаёт произведение чисел от 1 до N.
{
    /* Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120 */

int Number = 7;
double Factorial = 1;

for (int i = 2; i <= Number; i++)
    { 
        Factorial = Factorial * i;
        Console.WriteLine(Factorial);
    }
    Console.Write($"Факториал числа: {Number} --> {Factorial}");
}
//Z28();

void Z30()// Рандомный массив.
{
    /* Задача 30: Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
Random random = new Random ();
int size = random.Next(4,9);
int[] numbers = new int [size];
Console.WriteLine(size);
Console.WriteLine();

for (int i = 0; i < size; i++)
    { 
        numbers[i] = random.Next (0, 2);
    }

for (int i = 0; i < size; i++)
    { 
        Console.Write(numbers[i] + "\t");
    }
    
}
Z30();