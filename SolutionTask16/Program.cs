﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели,и проверяет, 
//является ли этот день выходным.

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    if ((inputNumber == 6)||(inputNumber == 7))
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}

