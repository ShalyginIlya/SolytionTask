System.Random numberSintezator = new Random();

int number = numberSintezator.Next(10, 100);

Console.WriteLine(number);

int firstNumber = number/10;
int secondNumber = number%10;

if(firstNumber > secondNumber)
{ 
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(secondNumber);
}

//вариант 2

// int number = new Random().Next(10, 100);
// Console.Write("The random number is: ");
// Console.WriteLine(number);
// string stringNum = number.ToString();
// Console.Write("The biggest digit is : ");
// if (stringNum[0] > stringNum[1]){
//     Console.WriteLine(stringNum[0]);
// } else {
//     Console.WriteLine(stringNum[1]);
//}

// if (number%10 > number/10){
//     Console.WriteLine(number%10);
// } else {
//     Console.WriteLine(number/10);
// }

