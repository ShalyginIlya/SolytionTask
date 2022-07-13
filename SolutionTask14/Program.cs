// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

string? inputLine = Console.ReadLine();

int inputNumber = int.Parse(inputLine);

int number = (inputNumber % 100) / 10;

Console.WriteLine(number);