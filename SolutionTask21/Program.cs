// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

int inputNumberA = int.Parse(Console.ReadLine());

int number1 = inputNumberA / 10000;
int number2 = (inputNumberA / 1000) % 10;
int number3 = (inputNumberA / 100) % 10;
int number4 = (inputNumberA / 10) % 10;
int number5 = inputNumberA % 10;

if ((number1 == number5) && (number2 == number4))
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("Не палиндром");
}

