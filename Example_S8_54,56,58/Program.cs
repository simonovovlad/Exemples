void Z54()
{
    /*
     Задача 54: Задайте двумерный массив. Напишите программу, 
     которая упорядочит по убыванию элементы каждой строки двумерного массива.
     Например, задан массив:
     1 4 7 2
     5 9 2 3
     8 4 2 4
     В итоге получается вот такой массив:
     7 4 2 1
     9 5 3 2
     8 4 4 2
     */

    int[,] table = new int[3, 4];
    FillArrayRandom(table);
    PrintArray(table);
    SortToLower(table);
    Console.WriteLine();
    PrintArray(table);


    // Функция заполнения массива рандомно числами от 1 до 9
    void FillArrayRandom(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 10);
            }
        }
    }

    // Функция сортировки элементов в строке двумерного массива, по убыванию
    void SortToLower(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(1) - 1; k++)
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                        int temp = array[i, k + 1];
                        array[i, k + 1] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }
    }

    // Функция вывода двумерного массива
    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
Z54();


void Z56()
{
    /*
 Задача 56: Задайте прямоугольный двумерный массив. 
 Напишите программу, которая будет находить строку с наименьшей суммой элементов.
 Например, задан массив:
 1 4 7 2
 5 9 2 3
 8 4 2 4
 5 2 6 7
 Программа считает сумму элементов в каждой строке 
 и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 */

    int[,] table = new int[4, 4];
    FillArrayRandom(table);
    PrintArray(table);
    Console.WriteLine();
    NumberRowMinSumElements(table);


    // Функция вывода номера строки (не индекса) с наименьшей суммой элементов 
    void NumberRowMinSumElements(int[,] array)
    {
        int minRow = 0;
        int minSumRow = 0;
        int sumRow = 0;
        for (int i = 0; i < table.GetLength(1); i++)
        {
            minRow += table[0, i];
        }
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j];
            if (sumRow < minRow)
            {
                minRow = sumRow;
                minSumRow = i;
            }
            sumRow = 0;
        }
        Console.Write($"{minSumRow + 1} row");
    }

    // Функция вывода двумерного массива
    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    // Функция заполнения массива рандомно числами от 1 до 9
    void FillArrayRandom(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 10);
            }
        }
    }


}
//Z56();


void Z58()
{
    /*
 Задача 58: Задайте две матрицы. Напишите программу, 
 которая будет находить произведение двух матриц.
 Например, даны 2 матрицы:
 2 4 | 3 4
 3 2 | 3 3
 Результирующая матрица будет:
 18 20
 15 18
 */


    int rows = ReadInt("Enter the number of lines: ");
    int columns = ReadInt("Enter number of columns: ");
    int[,] array = new int[rows, columns];
    int[,] secondArray = new int[rows, columns];
    int[,] resultArray = new int[rows, columns];

    FillArrayRandom(array);
    PrintArray2D(array);

    Console.WriteLine();

    FillArrayRandom(secondArray);
    PrintArray2D(secondArray);

    Console.WriteLine();

    if (array.GetLength(0) != secondArray.GetLength(1))
    {
        Console.WriteLine(" Can't be multiplied ");
        return;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                resultArray[i, j] += array[i, k] * secondArray[k, j];
            }
        }
    }

    PrintArray2D(resultArray);



    // Функция ввода
    int ReadInt(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }

    // Функция заполнения массива рандомными числами от 1 до 9
    void FillArrayRandom(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 10);
            }
        }
    }
    //  Функция вывода двумерного массива в терминал
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
}
//Z58();

