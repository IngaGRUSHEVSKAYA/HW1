//Напишите программу, которая на входе принимает координатные точки (x,y),
//при чем x не равен 0, y не равен 0 и выдает номер четверти плоскости,
// в которой находится эта точка.
/*
int GetQuadrant(int x, int y)
{
    int quadNum = 0;
    if(x > 0 && y > 0) quadNum = 1;
    else if(x < 0 && y > 0) quadNum = 2;
    else if(x < 0 && y < 0) quadNum = 3;
    else if(x > 0 && y < 0) quadNum = 4;

    return quadNum;
}
/*
int GetQuadrant(int x, int y);

Console.Write("Input a first coordinate: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a sekond coordinate: ");
int yA = Convert.ToInt32(Console.ReadLine());
int result = GetQuadrant(xA, yA);
if(result == 0)
Console.WriteLine("Your point is on axes");
else
Console.WriteLine($"Your point is on {result} quadrant");
*/

/*
void GetQuadrant(int quadNum)
{
    if(quadNum == 1) Console.Write("x > 0 && y > 0");
    else if(quadNum == 2) Console.Write("x < 0 && y > 0");
    else if(quadNum == 3) Console.Write("x < 0 && y < 0");
    else if(quadNum == 4) Console.Write("x > 0 && y < 0");
}
Console.Write("Input a quadNum: ");
int quadNum = Convert.ToInt32(Console.ReadLine());

GetQuadrant(quadNum);
*/

// Напишите программу, которая на входе принимает число (N)
// и выдает квадраты чисел от 1 до N.
/*
void PrintSq(int N)
{
    int i = 1;
    while(i <= N)
    {
        Console.Write(i * i + " ");
        i++;
    }
}
Console.WriteLine("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintSq(N);
*/

// Напишите программу, которая принимает координаты двух точек и находит расстояние 
// между ними в 2Dпространстве.
/*
double LineLength(double x1, double y1, double x2, double y2)
{
    double L1 = x2 - x1;
    double L2 = y2 - y1;
    double result = Math.Sqrt(Math.Pow(L1, 2)) + Math.Sqrt(Math.Pow(L2, 2));
    return result;
}
Console.Write("Input the coordinate X a first point: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coordinate Y a first point: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coordinate X a second point: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the coordinate Y a second point: ");
double y2 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("LineLength: " + Math.Round(LineLength(x1, y1, x2, y2), 2));
Console.WriteLine(Math.Sqrt(Math.Pow(x2 - x1, 2)) + Math.Sqrt(Math.Pow(y2 - y1, 2)));

*/