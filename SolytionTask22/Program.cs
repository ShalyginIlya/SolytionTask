// Напишите программу, которая принимает на вход координаты двух точек и находитрасстояние между ними в 3D пространстве.

// Глобальные переменные:
int coordXPointA; 
int coordXPointB;
int coordYPointA;
int coordYPointB;
int coordZPointA;
int coordZPointB;

double lengthAB;

//Считывает координаты точек А и В
void readDataOfPoint()
{
    Console.WriteLine("Введите координату Х точки А"); //Сообщение для пользователя
    coordXPointA = int.Parse(Console.ReadLine()); //Вводим переменную и превращаем ее в целочисленную

    Console.WriteLine("Введите координату Y точки А"); //Сообщение для пользователя
    coordYPointA = int.Parse(Console.ReadLine()); //Вводим переменную и превращаем ее в целочисленную

    Console.WriteLine("Введите координату Z точки А"); //Сообщение для пользователя
    coordZPointA = int.Parse(Console.ReadLine()); //Вводим переменную и превращаем ее в целочисленную

    Console.WriteLine("Введите координату Х точки B"); //Сообщение для пользователя
    coordXPointB = int.Parse(Console.ReadLine()); //Вводим переменную и превращаем ее в целочисленную

    Console.WriteLine("Введите координату Y точки B"); //Сообщение для пользователя
    coordYPointB = int.Parse(Console.ReadLine()); //Вводим переменную и превращаем ее в целочисленную

    Console.WriteLine("Введите координату Z точки B"); //Сообщение для пользователя
    coordZPointB = int.Parse(Console.ReadLine()); //Вводим переменную и превращаем ее в целочисленную
}

//Вычисляет расстояние между точками А и В
void conculateLengthAB()
{
    lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2) + Math.Pow((coordZPointA - coordZPointB), 2)); // Считаем по формуле
}

readDataOfPoint(); // Вызываем метод
conculateLengthAB(); // Вызываем метод

Console.WriteLine(lengthAB); //Выводим на консоль