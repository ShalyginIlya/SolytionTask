// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// Вариант 1
string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int NumberN = int.Parse(inputLineN);

    string lineN = "";
    string lineNN = string.Empty; // = "";
    int s = 1;
    while (s <= NumberN)
    {
        lineN = lineN + s+ " ";
        lineNN = lineNN + (s * s).ToString() + " ";
        s++;
    }

    Console.WriteLine(lineN);
    Console.WriteLine(lineNN);
}


//Вариант 2

// List<int> listGen(int number)
// {
//     List<int> numbers = new List<int>();
//     for (int i = 1; i <= number; i++)
//     {
//         numbers.Add(i);
//     }
//     return numbers;
// }

// string? inputLine = Console.ReadLine();

// if (inputLine != null)
// {
//     int inputNumber = int.Parse(inputLine);
//     List<int> nums = listGen(inputNumber);
//     foreach (var i in nums)
//     {
//         Console.Write(i);
//         Console.Write(" ");
//     }
//     Console.WriteLine();
//     foreach (var i in nums)
//     {
//         Console.Write(Math.Pow(i, 2));
//         Console.Write(" ");
//     }
// }