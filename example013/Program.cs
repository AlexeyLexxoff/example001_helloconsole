// // Двумерные массивы.
// string[,] table = new string[2,3];
// int[,]matrix = new int[5,8];

string[,] table = new string[2, 5];
// string.Empty
//  table [0,0] //  table [0,1]  table [0,2].....
//  table [1,0] //  table [1,1]  table [1,2]


table[1, 2] = "слово";


// for (int rows = 0; rows < 2; rows++)  // счетчик
// {
//     for (int columns = 0; columns < 5; columns++) // столбцы
//     {
//         System.Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }



void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // - внешний 3
    {
        for (int j = 0; j < matr.GetLength(1); j++) // - внутренний 4
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();

    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {   
        for (int j = 0; j < matr.GetLength(1); j++)
        {   
            matr[i,j] = new Random().Next(1,10); //  
        }
        
    }
}



int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);