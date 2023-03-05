/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2> result) result = arg2;
    if (arg3> result) result = arg3;
    return result;
}
int a1=15;
int b1=21;
int c1=39;
int a2=12;
int b2=23;
int c2=33;
int a3=13;
int b3=23;
int c3=33;

int max1 = Max(a1,b1,c1); // Можно в одну строку  int max = Max (Max(a1,b1,c1), Max(a2,b2,c2), Max(a3,b3,c3));
int max2 = Max(a2,b2,c2);
int max3 = Max(a3,b3,c3);
int max = Max(max1,max2,max3);
Console.WriteLine(max);
*/

/*
int a1=15;
int b1=21;
int c1=39;
int a2=12;
int b2=23;
int c2=33;
int a3=13;
int b3=23;
int c3=33;


int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);
*/

/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2> result) result = arg2;
    if (arg3> result) result = arg3;
    return result;
}
//              0   1  2  3  4  5  6  7  8 
int[] array = {11,21,31,41,15,61,17,18,19}; // Array Массив
//array [0] = 12; // присвоить нулевому эллементу массива значение 12
//Console.WriteLine (array[0]);
int max = Max(Max(array[0],array[1],array[2]),(array[3],array[4],array[5]),(array[6],array[7],array[8]));
Console.WriteLine(max);
*/

/*
int [] array = {1,12,31,4,15,16,17,18,};
int n = array.Length; // длинна 
int find = 18;  // искомое число 

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // прерви 
    }
    index++; // index = index+1;
}
*/
void FillArray(int[] collection)
{
    int lenght = collection.Length; // получить длинну массива
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1,10); // заполнить массив случайными числами 
        index++;
    }
} 
void PrintArray(int[] col)
{
    int count = col.Length; // метод печати массива
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
   int count = collection.Length;
   int index = 0;
   int position = -1; // если элемента нет элемента будет -1
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
   
int [] array = new int [10]; // заполнить массив 10 элементами будут 0
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array,4);
Console.WriteLine(pos);
