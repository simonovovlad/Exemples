void Z41()
{
/* 
Задача 41:Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223 -> 4
*/

Console.WriteLine("Enter the numbers separated by commas: ");
string? input = Console.ReadLine();
int[] numbers = Array(input);
PrintArray(numbers);

 
int Comparison(int[] Numbers)
{
  int count = 0;
  for (int i = 0; i < numbers.Length; i++)
  {
    if(Numbers[i] > 0 ) count += 1; 
  }
  return count;
}
 
Console.WriteLine($"Entered numbers greater than zero >> {Comparison(numbers)} ");

int[] Array(string input)
{
    int countNumbers = Count(input);
    int[] numbers = new int[countNumbers];
    int indexNumber = 0;
    string substring = string.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ',')
        {
            substring += input[i];
        }
        else
        {
            numbers[indexNumber] = Convert.ToInt32(substring);
            indexNumber++;
            substring = string.Empty;
        }
    }
    if(input[input.Length - 1] != ',')
        numbers[indexNumber] = Convert.ToInt32(substring);
    return numbers;
}
int Count(string input) 
{
    int count;
    if(input[input.Length - 1] == ',')
        count = 0;
    else
        count = 1;

    for(int i = 0; i < input.Length; i++)
    {
        if(input[i] == ',')
            count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
}
Z41();


void Z43()
{
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.WriteLine("Enter the number b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double numberX = (b2 - b1)/(k1 - k2);
double numberY = k2 * numberX + b2;

Console.WriteLine($"The point of intersection of two straight lines: {numberX},{numberY}");
}
//Z43();