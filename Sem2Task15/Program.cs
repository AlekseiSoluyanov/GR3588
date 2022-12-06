﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

int dayOfWeek = int.Parse(Console.ReadLine()??"0");

//Создаем два уловия: первое из которых проверяет на ввод числа в диапазоне от 1 до 7
//Второе на разделение будних и выходных дней, выводим результат в консоль.
if(dayOfWeek > 0 && dayOfWeek < 8)
{
    if(dayOfWeek > 5) Console.WriteLine("Выходной");
    else Console.WriteLine("Рабочий день");
}
else Console.WriteLine("День недели не введён");