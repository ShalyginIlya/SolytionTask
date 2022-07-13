//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого

string? inputLkneOne = Console.ReadLine();
string? inputLkneTwo = Console.ReadLine();
if(inputLkneOne != null && inputLkneTwo != null ){
    int inputNumberOne = Math.Abs(int.Parse(inputLkneOne));
    int inputNumberTwo = Math.Abs(int.Parse(inputLkneTwo));
    double sq = 0;

    if(inputNumberOne > inputNumberTwo){
        sq = Math.Sqrt(inputNumberOne);
    }else{
        sq = Math.Sqrt(inputNumberTwo);
    }

    if(sq == inputNumberOne ^ sq == inputNumberTwo){
        Console.WriteLine("Да");
    }else{
        Console.WriteLine("Нет");
    }
    
}

//Вариант2

Console.WriteLine("Введите первое число ");

string? inputOne = Console.ReadLine();
string? inputTwo = Console.ReadLine();

if (inputOne != null && inputTwo != null)
{
    int numOne = int.Parse(inputOne);   
    int numTwo = int.Parse(inputTwo);  

    if (Math.Sqrt(numOne) == numTwo) 
    {
        Console.WriteLine("Yes");
    } 
    else if (Math.Sqrt(numTwo) == numOne) 
    {
        Console.WriteLine("Yes");   
    }
    else
    {
        Console.WriteLine("No");
    }
}
