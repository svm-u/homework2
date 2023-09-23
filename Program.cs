/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    
Console.Write("num = ");
int num = Convert.ToInt32(Console.ReadLine());
num = (num/10)%10;
Console.WriteLine(num);
*/
/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    
Console.Write("num = ");
int num = Convert.ToInt32(Console.ReadLine());
{
if (num > 100 || num < (-100))
{
  while (num > 999 || num < (-999))
    num /= 10;
  Console.Write(num%10);
}
else 
  Console.Write("третьей цифры нет");
}
*/
/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day>0 && day<6)
  Console.Write("рабочий");
else if (day<8 && day>5)
  Console.Write("выходной");  
else
  Console.Write("дней недели 7");
*/
