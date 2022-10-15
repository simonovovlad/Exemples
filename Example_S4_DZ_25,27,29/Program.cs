void Z24() //возводит число A в степень B
{
    /* Задача 25: Используя определение степени числа,
    напишите цикл, который принимает на вход два
    натуральных числа (A и B) и возводит число A в степень B. 
    a^b = a * a * .... a * a * a - b раз.
    3, 5 -> 243
    2, 4 -> 16
 
    */

    int a = 3;
    int b = 5;
    int result = 1;
    if (b < 0)
    {
        Console.WriteLine($"Power {b} is negative");
    }
    else if (b == 0)
    {
        Console.WriteLine($"Power is 0");
    }
    else
    {
        for (int i = 1; i <= b; i++)
        {
            result = result * a;
            //result = Math.Pow(a, b); 
        }
        Console.WriteLine($"Number {a} to the power {b} = {result}");
    }

}
Z24();

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
//Z29();