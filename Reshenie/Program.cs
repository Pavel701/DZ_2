﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5, 782 -> 8, 918 -> 1

    Console.Write("Введите трёхзначное число: ");
    int number = int.Parse(Console.ReadLine());
    int secondDigit = (number / 10) % 10;
    Console.WriteLine($"Вторая цифра числа {number} равна {secondDigit}");
  


    //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    //645 -> 5, 78 -> третьей цифры нет, 32679 -> 6
    
Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
// Если число меньше 100 то третьей цифры нет
if (number < 100) 
{
Console.WriteLine("Третьей цифры нет.");
} 
else if (number > 999)
{
// Вычисляем третью цифру числа
int result = (number / 100) % 10;
Console.WriteLine("Третья цифра числа: " + result);
}
else 
{
// Вычисляем третью цифру числа
int result = (number / 1) % 10;
Console.WriteLine("Третья цифра числа: " + result);
}


  //Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да, 7 -> да, 1 -> нет
Console.Write("Введите цифру дня недели: ");
int day = int.Parse(Console.ReadLine());
if (day == 6 || day == 7) 
{
Console.WriteLine("Это выходной день.");
} 
else 
{
Console.WriteLine("Этот невыходной день.");
}


// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5, 782 -> 8, 918 -> 1

    Console.Write("Введите трёхзначное число: ");
    int number = int.Parse(Console.ReadLine());
    int secondDigit = (number / 10) % 10;
    Console.WriteLine($"Вторая цифра числа {number} равна {secondDigit}");

