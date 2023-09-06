int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}//

int[] arrey = { 11, 21, 31, 41, 15, 61, 17, 18, 19 };

int max = Max(
    Max(arrey[0], arrey[1], arrey[2]),
    Max(arrey[3], arrey[4], arrey[5]),
    Max(arrey[6], arrey[6], arrey[8])
);
Console.WriteLine(max);

//int max = Max(
  //  Max(a1, b1, c1),
    //Max(a2, b2, c2),
   // Max(a3, b3, c3));



//Console.WriteLine(max);
