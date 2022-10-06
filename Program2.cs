//-------------------- НАЧАЛО - Задача 10 ---------------------
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
string Task10(int inputNum)
{
    if (inputNum < 100 || inputNum > 999) 
    {
        Console.WriteLine($"Ошибка: число {inputNum} не трехзначное!");
        return "-1";
    }
    else
    {
        // string strNum = inputNum.ToString();
        // Console.WriteLine($"Число в виде строки {strNum} ; strNum[1] = {strNum[1]}");
        return inputNum.ToString()[1].ToString();
    }
}
//-------------------- ОКОНЧАНИЕ - Задача 10 ---------------------


//-------------------- НАЧАЛО - Задача 13 ---------------------
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
string Task13(int inputNum)
{
    if (inputNum.ToString().Length < 3) 
        return "-1";
    else
    {
        return inputNum.ToString()[2].ToString();
    }
}
//-------------------- ОКОНЧАНИЕ - Задача 13 ---------------------


//-------------------- НАЧАЛО - Задача 15 ---------------------
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
string Task15(int inputNum, ref string inOutWeekend)
{
    inOutWeekend = "Нет";
    if (inputNum == 1)
        return "Понедельник";
    else if (inputNum == 2)
        return "Вторник";
    else if (inputNum == 3)
        return "Среда";
    else if (inputNum == 4)
        return "Четверг";
    else if (inputNum == 5)
        return "Пятница";
    else if (inputNum == 6)
    {
        inOutWeekend = "Да";
        return "Суббота";
    }
    else if (inputNum == 7)
    {
        inOutWeekend = "Да";
        return "Воскресенье";
    }
    else
        return "-1";
}
//-------------------- ОКОНЧАНИЕ - Задача 15 ---------------------


Console.WriteLine("Задание № 10. Получить 2-ую цифру трехзначного числа");
int num_task10 = new Random().Next(100, 1000);
string cifra2 = Task10(num_task10);
if (cifra2 != "-1") 
    Console.WriteLine($"    {num_task10} -> {cifra2}");
else
    Console.WriteLine($"    Ошибка: число {num_task10} не является трехзначным!");


Console.WriteLine("Задание № 13. Получить третью цифру заданного числа или сообщить, что третьей цифры нет");
int num_task13 = new Random().Next(1, 1200);
string cifra3 = Task13(num_task13);
if (cifra3 != "-1") 
    Console.WriteLine($"    {num_task13} -> {cifra3}");
else
    Console.WriteLine($"    {num_task13} -> третьей цифры нет");


Console.Write("Задание № 15. Для поиска дня недели по его номеру введите число от 1 до 7: ");
int num_task15 = int.Parse(Console.ReadLine());
string weekend = ""; 
string denNed = Task15(num_task15, ref weekend);
if (denNed != "-1") 
    Console.WriteLine($"    {num_task15} -> {denNed} -> {weekend}");
else
    Console.WriteLine($"    Ошибка: {num_task15} не в диапазоне от 1 до 7");

