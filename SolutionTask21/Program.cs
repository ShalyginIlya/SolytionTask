// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

int inputNumberA = int.Parse(Console.ReadLine()); //Считываем число 

int number1 = inputNumberA / 10000;  //Находим первую цифру от числа
int number2 = (inputNumberA / 1000) % 10;  //Находим вторую цифру от числа
int number3 = (inputNumberA / 100) % 10;  //Находим третью цифру от числа
int number4 = (inputNumberA / 10) % 10;  //Находим четвертую цифру от числа
int number5 = inputNumberA % 10;  //Находим пятую цифру от числа

if ((number1 == number5) && (number2 == number4)) //Если (первая и пятая) и (вторая и четвертая) числа от числа равны, то  
{
    Console.WriteLine("Палиндром"); //Выводим на консоль
}
else //Если не равны, то
{
    Console.WriteLine("Не палиндром"); //Выводим на консоль
}

