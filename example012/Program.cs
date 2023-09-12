// //методы
// //  вид 1 - метод без возрата 

// void Method1()
// {
//     System.Console.WriteLine("автор...");
// }
// Method1();

// //вид 2  - без возрата но с аргументами
// void Method2(string msg)
// {
//     System.Console.WriteLine(msg);
// }
// Method2("Текст сообщения");
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         System.Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "текст", count 4);

// //вид 3 - метод приема но не возрата

// int Method3()
// {
//     return DateTime.Now.Year;    
// }
// int year = Method3();
// System.Console.WriteLine(year);



// //вид 4 - метод приёма и возрата 
// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "asdf");
// System.Console.WriteLine(res);


// прием  возраст с циклом FOR

// string Method4(int count, string c)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "asdf");
// System.Console.WriteLine(res);
// 
//цикл for двойной ( таблица  умножения )
// for (int i = 2; i < 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//        System.Console.WriteLine($"{i} x {j} = {i*j}");       
//     }
//     System.Console.WriteLine();
// }


//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,

//string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//          + "ежели бы вас послали вместо нашего милого Винценгероде,"
//         + "вы бы взяли приступом согласие прусского короля."
//         + "Вы так красноречивы. Вы дадите мне чаю?";

//string s = "qwerty'
//            012   
//s[3]// -  r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

// int length = text.Length;
// for (int i = 0; i < length; i++)
// {
//     if (text[i] == oldValue) result = result + $"{newValue}";
//     else result = result + $"{text[i]}";
// }

// return result;
// }
// string newText = Replace(text, ' ', '|');

// System.Console.WriteLine(newText);
// System.Console.WriteLine();
// newText = Replace(text, 'к', 'К');
// System.Console.WriteLine(newText);


// сортировка массива

int[] arr = { 1, 5, 4, 3, 2, 6, 7 };

void PrintArray(int[] arrey)
{
    int count = arrey.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{arrey[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] arrey)
{
//поиск
    for (int i = 0; i < arrey.Length - 1; i++)
    {
        int minPossition = i;
        for (int j = i + 1; j < arrey.Length; j++)
        {
            if (arrey[j] < arrey[minPossition]) minPossition = j;
        }
        int temporary = arrey[i];
        arrey[i] = arrey[minPossition];
        arrey[minPossition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
