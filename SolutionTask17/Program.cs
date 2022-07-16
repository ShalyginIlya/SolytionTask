// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
//выдаёт номер четверти плоскости, в которой находится эта точка.


//Метод считывает точки и возвращает массив с ними
int[,] readPoint()
{
    string inputLine = Console.ReadLine();

    //x=34; y=-30 -> 4

    string coordXLine = inputLine.Substring(0,inputLine.IndexOf(";"));
    //x=34
    coordXLine = coordXLine.Substring(coordXLine.IndexOf("=")+1);
    //34

    string coordYLine = inputLine.Substring(inputLine.IndexOf(";")+1);
    //y=-30
    coordYLine = coordYLine.Substring(coordYLine.IndexOf("=")+1);
    //-30

    //Console.WriteLine(coordX+" "+coordY);

    int coordX = int.Parse(coordXLine);
    int coordY = int.Parse(coordYLine);

    int[,] arrayOut = new int[1,2];
    arrayOut[0,0] = coordX;   
    arrayOut[0,1] = coordY; 

    return arrayOut;
}

//Печатает номер четверти
void printQuter(int[,] arrayPoint)
{
    if(arrayPoint[0,0]>0&&arrayPoint[0,1]>0)
    Console.WriteLine("1 четверть");

    if(arrayPoint[0,0]<0&&arrayPoint[0,1]>0)
    Console.WriteLine("2 четверть");

    if(arrayPoint[0,0]<0&&arrayPoint[0,1]<0)
    Console.WriteLine("3 четверть");

    if(arrayPoint[0,0]>0&&arrayPoint[0,1]<0)
    Console.WriteLine("4 четверть");
}

int [,] arrayPoint = readPoint();

printQuter(arrayPoint);
//printQuter(readPoint());


