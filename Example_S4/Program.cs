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
        Console.WriteLine(sum);
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
    int size = 5;//random.Next(4,9);
    int[] numbers = new int [size];
    Console.WriteLine(size);
    Console.WriteLine();

    //FillArray(numbers);
     for (int i = 0; i < numbers.Length; i++)
    { 
        Console.WriteLine($"Enter {i+1}-th element of erray: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    PritArray(numbers);
    
    
    void PritArray(int[] num)
    {
    for (int i = 0; i < size; i++)
    { 
        Console.Write(num[i] + "   ");
    }

    }
    

    void FillArray(int[] num)
    {
        Random random = new Random();
        for (int i = 0; i < size; i++)
    { 
        numbers[i] = random.Next (0, 2);
    }
    }
}
//Z30();

void Z24type2() //возводит число A в степень B
{
    /* Задача 25: Используя определение степени числа,
    напишите цикл, который принимает на вход два
    натуральных числа (A и B) и возводит число A в степень B. 
    a^b = a * a * .... a * a * a - b раз. 
    */

    int a = 2;
    int b = 10;
    int result = 1;
    if (b < 0)
    {
        Console.WriteLine($"Степень {b} являтется отрицательной или равна 0");
    }
    else if (b == 0)
    {
        Console.WriteLine($"Степень равна 0");
    }
    else
    {
        for (int i = 1; i <= b; i++)
        {
            result = result * a;
            //result = Math.Pow(a, b); 
        }
        Console.WriteLine($"число {a} в степени {b} = {result}");
    }

}
//Z24type2();

void Z27() // Выдаёт сумму цифр в числе.
{
    /* 
    Задача 27: Напишите программу, которая принимает на
    вход число и выдаёт сумму цифр в числе. 
    452 -> 11
    82 -> 10
    9012 -> 12
    */

    int number = 9012;
    int number2 = number;
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    Console.WriteLine($"The sum of the digits in a number {number2} = {sum}");

}
//Z27();

void Z29() //Выводит отсортированный по модулю массив.
{
    /* 
    Задача 29: Напишите программу, которая задаёт массив
    из 8 случайных целых чисел и выводит отсортированный
    по модулю массив. 
    -2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
    6, 1, -33 -> [1, 6, -33]
    */

    int size = 8;
    int[] numbers = new int[size];
    FillArray (numbers, -9, 9);
    for (int i = 1; i < size; i++)
    {
        for (int j =0; j < size - i; j++)
        {
            if (Math.Abs(numbers [j]) > Math.Abs(numbers [j + 1]))
            {
                int temp = numbers[j];
                numbers [j] = numbers [j+1];
                numbers [j+1] = temp;
            }
            
            
        }
        
    }
    PrintArray (numbers);

    void PrintArray(int[] num)
    {
        Console.Write("Array output: ");
        for (int i = 0; i < size; i++)
        { 
            Console.Write(num[i] + "   ");
            
        }
        
    }
    

    void FillArray(int[] num, int num1, int num2)
    {
        Random random = new Random();
        for (int i = 0; i < size; i++)
        { 
            numbers[i] = random.Next (-9, 9);
        }
    }
    
}
Z29();