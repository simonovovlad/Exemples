void Fmax()//Функция на примере нахождения максимума из 3.
{
  int Max(int arg1,int arg2,int arg3)
  {
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
  }
  int a1 = 15;
  int b1 = 16;
  int c1 = 17;

  int a2 = 18;
  int b2 = 19;
  int c2 = 20;

  int a3 = 21;
  int b3 = 22;
  int c3 = 23;

  // int max1 = Max(a1,b1,c1);
  // int max2 = Max(a2,b2,c2);
  // int max3 = Max(a3,b3,c3);
  // int max = Max(max1,max2,max3);

  // Console.WriteLine(max1);
  // Console.WriteLine(max2);
  // Console.WriteLine(max3);
  Console.WriteLine(Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3)));
}
//Fmax();
void Array1()//Массив с поиском по функции мак на 3 аргумента.
{
  int[] array = {11, 21, 31, 41, 15, 61, 17, 18, 19};
  
  array[0] = 12;
  int result = Max(Max(array[0],array[1],array[2]),
  Max(array[3],array[4],array[5]),
  Max(array[6],array[7],array[8]));
  Console.WriteLine(result);
  
  int Max(int arg1, int arg2, int arg3)
  {
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
  }
}
//Array1();
void Array2()//Массив с поиском индекса по числу.
{
int[] banana = {11, 21, 31, 41, 15, 61, 17, 18, 19};
int n = banana.Length;
Console.Write("Enter the number: ");
int find = Convert.ToInt32(Console.ReadLine());
int index = 0;
while (index < banana.Length)
{
  if (banana[index]==find)
  {
    Console.WriteLine("Индекс этого числа: " + index);
    break;
  }
  index++;
}
}
//Array2();
void FillArray(int[] collection)//Функция рандомного перемешивания для массива "на 10".

{
int Length = collection.Length;
int index = 0;
while (index < collection.Length)
{
  collection[index] = new Random().Next(1, 10);
  index++;
}
}

void PrintArray(int[] col)//Распечатка рандомного массива FillArray.
{
  int count = col.Length;
  int position = 0;
  while( position < count )
  {
    Console.Write (col[position] + ", ");
    
    position++;
  }
}

// int indexOf (int [] collection, int find);
// int count = collection.Length;
// int index = 0;
// position = 0;
// while(index<count)
// {
//   if (Collection[index] == find)
//   {
//     position = index;
//   }
//   index++;
//   return position;
// }

int [] array = new int[10];

FillArray(array);
PrintArray(array);

// int pos = indexOf(array, 4);
// console.WriteLine(pos);