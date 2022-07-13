// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

//Вариант 1
string? inputLine = Console.ReadLine(); //Считываем строковую переменную

int inputNumber = int.Parse(inputLine); //Превращаем строковую переменную в целочисленную

int number = (inputNumber % 100) / 10;  // (Получаем остаток от числа) полученный результат делим на 10

Console.WriteLine(number); // Выводим на консоль результат

//Вариант 2
string? inputLine1 = Console.ReadLine(); //Считываем строковую переменную

char[] array = inputLine1.ToCharArray(); //Создаем массив array

Console.WriteLine(array[1]); // Выводим на консоль число под индексом 1