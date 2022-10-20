void Z64()
{
    /*
    Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который
    выведет все натуральные числа кратные 3-ём в промежутке от M до N.
    M = 1; N = 9. -> "3, 6, 9"
    M = 13; N = 20. -> "15, 18"
    */

    Console.Write("Enter the M number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the N number: ");
    int count = Convert.ToInt32(Console.ReadLine());
    OnThree(number, count);


    void OnThree(int m, int n)
    {
        if (m > n)
            return;
        else if (m % 3 == 0)
            Console.Write(" " + m);
        m = m + 1;
        OnThree(m, n);
    }
}
Z64();

void Z66()
    {
        /*
        Задача 66: Задайте значения M и N. Напишите программу, 
        которая найдёт сумму натуральных элементов в промежутке от M до N.
        M = 1; N = 15 -> 120
        M = 4; N = 8. -> 30
        */

        Console.Write("Enter the M number: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the N number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        SumFromMToN(m, n);

        // вызов функции "сумма чисел от M до N"
        void SumFromMToN(int m, int n)
        {
            Console.Write(SumMandN(m - 1, n));
        }

        // Метод суммы чисел от M до N
        int SumMandN(int m, int n)
        {
            int res = m;
            if (m == n)
                return 0;
            else
            {
                m++;
                res = m + SumMandN(m, n);
                return res;
            }
        }
    }
//Z66();

void Z68()
{
    /*
     Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
     Даны два неотрицательных числа m и n.
     m = 2, n = 3 -> A(m,n) = 9
     m = 3, n = 2 -> A(m,n) = 29
     */

    Console.Write("Enter the M number: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the N number: ");
    int n = Convert.ToInt32(Console.ReadLine());

    AkkermanMethod(m, n);


    // вызов функции Аккермана
    void AkkermanMethod(int m, int n)
    {
        Console.Write(Akkerman(m, n));
    }

    // функция Аккермана
    int Akkerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0 && m > 0)
        {
            return Akkerman(m - 1, 1);
        }
        else
        {
            return (Akkerman(m - 1, Akkerman(m, n - 1)));
        }
    }
}
//Z68();