//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа

//Вариант 1
System.Random numberSintezator = new Random();

int number = numberSintezator.Next(100, 1000);

Console.WriteLine(number);

int firstNumber = number/100;
int secondNumber = number%10;
int result = (firstNumber + secondNumber);

Console.WriteLine(firstNumber * 10 + secondNumber);

//Вариант 2
int number1 = new Random().Next(100,1000);
Console.WriteLine("Число:" + number1);
int numberSecondDigit = number1/100;
int numberThirdDigit = number1%10;
Console.WriteLine("Число после удаления второй цифры: " + numberSecondDigit + numberThirdDigit);


//Вариант 3
void middleDigitCutter()
{
    int number = new Random().Next(100, 1000);
    Console.Write("The random number is : ");
    Console.WriteLine(number);
    string stringNum = number.ToString();
    Console.Write("The modified num is : ");
    Console.Write(stringNum[0]);
    Console.WriteLine(stringNum[2]);
}

//Вариант 4
void middleDigitCutter2() 
{
    int number = new Random().Next(100, 1000);
    Console.Write("The random number is : ");
    Console.WriteLine(number);

    int num1 = number / 100;
    int num2 = number % 10;

    Console.Write("The modified num is : ");
    Console.Write(num1*10 + num2);        
}

middleDigitCutter();
middleDigitCutter2();

