// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

string? inputLine = Console.ReadLine();

char[] array = inputLine.ToCharArray();

if (array.Length >= 3)
    Console.WriteLine(array[2]);
else
    Console.WriteLine("Третьей цифры нет");




