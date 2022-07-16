﻿// Напишите программу, которая принимает на вход координаты двух точек и находитрасстояние между ними в 3D пространстве.


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
    Console.WriteLine("Введите координату Х точки А");
    coordXPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки А");
    coordYPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Z точки А");
    coordZPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Х точки B");
    coordXPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки B");
    coordYPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Z точки B");
    coordZPointB = int.Parse(Console.ReadLine());
}

//Вычисляет расстояние между точками А и В
void conculateLengthAB()
{
    lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2) + Math.Pow((coordZPointA - coordZPointB), 2));
}

readDataOfPoint();
conculateLengthAB();

Console.WriteLine(lengthAB);