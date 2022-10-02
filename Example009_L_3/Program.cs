/*Виды методов
Вид 1 - ничего не принимают, ничего не возвращают.
*/
void Method1()
{
    Console.WriteLine("Первый тип - ничего не принимают, ничего не возвращают");
}
//Method1();

/*Вид метода 2
Что-то принимают, ничего не возвращают.
Пример 1: Выводит текст.
*/
void Method2(string msg)//В скобках указывает аргументы метода - Method2.
{
    Console.WriteLine(msg);
}
//Method2(msg:"Текст сообщения");

//Пример 2: Выводит текст определенное колличество раз.
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Message", 4);

/*Вид метода 3
Ничего не принимает, что-то возвращает.
Пример 1:
*/
void A()
{
    int Method3()// Выдает текущий год.
    {
        return DateTime.Now.Year;
    }
    int year = Method3();
    Console.WriteLine($"Сейчас Год: {year}.");
}
//A();

/*Вид метода 4
Что-то принимает, что-то возвращает.
Пример 1: Выводит текст несколько раз. 
*/
void B()
{
    string Method4(int count, string text)
    {
        int i = 0;
        string result = String.Empty;
        while (i < count)
        {
            result = result + text;
            i++;

        }
        return result;
    }
    string res = Method4(5, "Simple text, ");
    Console.WriteLine(res);
}
//B();
void C()//Вывод текста опред. кол-во раз. 
{
    string Method4(int count, string text)
    {
        string reasult = String.Empty;
        for (int i = 0; i < count; i++)
        {
            reasult = reasult + text;

        }
        return reasult;
    }
    string res = Method4(5, "Simple text, ");
    Console.WriteLine(res);
}
//C();
void D()//Таблица умножения.
{

    for (int i = 2; i <= 10; i++)
    {
        for (int j = 2; j <= 10; j++)
        {
            Console.WriteLine($"{i}x{j}={i * j}");
        }
        Console.WriteLine();
    }


}
//D();
void E()
{
/*
Задание:
Дан текст. В тексте нужно все пробелы заменить черточками,
маленькие буквы “к” заменить большими “К”, а большие “С” заменить
маленькими “с”.

Задать вопросы с уточнениями к заданию:
Что значит “Дан текст”?.
Что значит “черточками”?
Какого алфавита?
Маленькие буквы “к” заменить большими “К”, а большие “С” заменить
маленькими “с”.

Текст:
— Я думаю, — сказал князь, улыбаясь, — что,
ежели бы вас послали вместо нашего милого
Винценгероде, вы бы взяли приступом согласие
прусского короля. Вы так красноречивы. Вы
дадите мне чаю?
string stroka = "simple text"
                 012345
например буква m будет под индексом [2].   

*/

string text = "— Я думаю, — Сказал князь, улыбаясь, — что, "
                + "ежели бы ваС послали вместо нашего милого "
                + "Винценгероде, вы бы взяли приступом Согласие прусского короля."
                + "Вы так красноречивы."
                + "Выдадите мне чаю?";
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int Length = text.Length;
    for (int i = 0; i < Length; i++)
    {
        if (text[i] == oldValue) 
        {
        result = result + $"{newValue}";
        }
        else 
        {
        result = result + $"{text[i]}";
        }
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'С', 'с');
Console.WriteLine(newText);
}
//E();
void F()//Методы печати и сортировки от малого к большому масива чисел.
{
int[] arr = {10,9,8,5,7,6,4,3,2,1};

void PrintArray(int[] array)
{
int count = array.Length;
for (int i = 0; i < count; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}
void SelectionSort(int[] array)
{
 for (int i = 0; i < array.Length - 1; i++)
 {
 int minPosition = i;
 for (int j = i + 1; j < array.Length; j++)
 {
 if (array[j] < array[minPosition])
 {
 minPosition = j;
 }
 }
 int temporary = array[i];
 array[i] = array[minPosition];
 array[minPosition] = temporary;
 }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
}
F();