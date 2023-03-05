/*
// Вид 1
void Method1()
{
    System.Console.WriteLine();
}

Method1();
Method1;

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");


void Method21 (string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}
Method21(msg:"Текст сообщения", count:4); 

Вид 3
void Method3() 
{
    return DateTime.Now.Year;
}
 
int year = Method3();
Console.WriteLine(year);


Вид 4
string Method4(int count, string text) 
{
    int i =0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
}
string res = Method4(10, "sdf");
Console.WriteLine(res);


string Method4(int count, string text) 
{
    string result = String.Empty;
    for(int i =0; i < count; i++)
    {
        result = result + text;
    }
}
string res = Method4(10, "sdf");
Console.WriteLine(res);


for(int i = 2; i < = 10; i++)
{
  for(int j = 2; i < = 10; j++)
  {
    Console.WriteLine($"{i}x{j}={i*j}");
  }
  Console.WriteLine();
}
*/
//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

/*

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
                + "ежеле бы вас послали вместо нашего милого Винценгероде,"
                +"вы бы взяли приступом согласие прусского короля."
                + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             0123
// s[3] = r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text,' ','|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText,'к','К');
Console.WriteLine(newText);
*/
// Сортировка массива от мин до макс.
/*
int [] arr = {1,5,4,3,2,6,7,1,1};
void PrintArray(int[]array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;
    
       for(int j = i+1; j < array.Length; j++)
       {
        if(array[j] < array[minPosition]) minPosition = j;
       }
      
       int temporary = array[i];
       array[i] = array[minPosition];
       array[minPosition] = temporary;
    }

}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
*/
