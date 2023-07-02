/* Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
int ReadInt(string message)
{
    System.Console.Write(message);              
    return Convert.ToInt32(Console.ReadLine()); 
}
int SumDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number /= 10;
    }
    return sum;
}
int number = ReadInt("Введите число => ");
System.Console.WriteLine($"Сумма цифр в числе {number} равна {SumDigits(number)}");