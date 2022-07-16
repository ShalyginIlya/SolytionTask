// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.


int coordXPointA;
int coordXPointB;
int coordYPointA;
int coordYPointB;

double lengthAB;

//Считывает координаты точек А и В
void readDataOfPoint()
{
    Console.WriteLine("Введите координату Х точки А");
    coordXPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки А");
    coordYPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Х точки B");
    coordXPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки B");
    coordYPointB = int.Parse(Console.ReadLine());
}

//Вычисляет расстояние между точками А и В
void conculateLengthAB()
{
   lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2)); 
}

readDataOfPoint();
conculateLengthAB();

Console.WriteLine(lengthAB);




//Вариант без метода

// Console.WriteLine("Введите координату Х точки А");
// int coordXPointA = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите координату Y точки А");
// int coordYPointA = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите координату Х точки B");
// int coordXPointB = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите координату Y точки B");
// int coordYPointB = int.Parse(Console.ReadLine());

// double lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2));

// Console.WriteLine(lengthAB);