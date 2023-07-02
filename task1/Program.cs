/*Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B. Сделать через функции
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
int ReadInt(string message)
{
    System.Console.Write(message);              
    return Convert.ToInt32(Console.ReadLine()); 
}
int NatDegree(int a, int b)
{
    int degree = 1;
    for (int i = 1; i <= b; i++)
    {
        degree *= a;
    }
    return degree;
}
int a = ReadInt("Введите первое число => ");
int b = ReadInt("Введите второе число => ");
System.Console.WriteLine($"Число {a} в степени {b} равна {NatDegree(a, b)}");