﻿
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


/*  Ввод исходных данных
int a1 = 112125;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 13;
int b3 = 23111;
int c3 = 313;
*/
//              0   1   2   3   4   5   6   7   8
int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 }; //Ввели данные массивом
//array[0] = 12;                                        //Ввели значение 12 в 0-й индекс массива 
//Console.WriteLine(array[4]);                          //Вывели в терминал значение 0-го индекса


// int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)); 

int result = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));
Console.WriteLine(result);
