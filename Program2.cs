﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//-------------------- НАЧАЛО - Задача 10 ---------------------
int Task10(int num3)
{
    if (num3 < 100 && num3 > 999) 
        Console.WriteLine($"Число {num3} не трехзначное");
    else
    {
        strNum = ToString(num3);
        return strNum[1];
    }
}

//-------------------- ОКОНЧАНИЕ - Задача 10 ---------------------


//-------------------- НАЧАЛО - Задача 13 ---------------------

Console.WriteLine("Hello, World!");

//-------------------- ОКОНЧАНИЕ - Задача 13 ---------------------


//-------------------- НАЧАЛО - Задача 15 ---------------------

Console.WriteLine("Hello, World!");

//-------------------- ОКОНЧАНИЕ - Задача 15 ---------------------


Console.WriteLine("Задание № 10");
int num3 = Random.Next(100, 1000);
int char2 = Task10(num3);
