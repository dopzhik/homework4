/*Задача 3: Напишите программу, которая задаёт массив из 8 элементов
 и выводит их на экран. Сделать через функции
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
int[] CreateArray(int length, int min, int max)
{
    int[] Arrayone = new int[length];
    Random rd = new Random();
    for (int i = 0; i < Arrayone.Length; i++)
    {
        Arrayone[i] = rd.Next(min, max+1);
    }
    return Arrayone;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       System.Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int [] currentarray = CreateArray(8, 0, 9);
PrintArray(currentarray);