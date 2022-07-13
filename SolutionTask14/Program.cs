// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

//Вариант 1
string? inputLine = Console.ReadLine();

int inputNumber = int.Parse(inputLine);

int number = (inputNumber % 100) / 10;

Console.WriteLine(number);

//Вариант 2
string? inputLine1 = Console.ReadLine();

char[] array = inputLine1.ToCharArray();

Console.WriteLine(array[1]);