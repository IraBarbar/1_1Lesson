/*
void ShowRange( int quart)
{
    if (quart == 1)
        Console.WriteLine("x > 0 and y > 0");
    else if (quart == 2)
        Console.WriteLine("x < 0 and y > 0");
    else if (quart == 3)
        Console.WriteLine("x < 0 and y < 0");
    else if (quart == 4)
        Console.WriteLine("x > 0 and y < 0");  
    else 
        Console.WriteLine("Wrong number");         
}

Console.WriteLine("Input a number of quart");
int quartNum = Convert.ToInt32(Console.ReadLine());

ShowRange(quartNum);
*/

// Задача 2 . Напишите программу, которая принимает на входе координатные точки
// (X, Y) причем X и Y  не равно 0 и выдает номер четверти плоскости , в которой находится эта точка.

/*
int ShowRange(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    else if (x < 0 && y > 0) return 2;
    else if (x < 0 && y < 0) return 3;
    else if (x > 0 && y < 0) return 4;
        else return 0;
}

Console.WriteLine("Input a number X of quart");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a number Y of quart");
int y = Convert.ToInt32(Console.ReadLine());

int resalt = ShowRange( x, y);
Console.WriteLine(resalt);
*/

// Задача 3 . Напишите программу, которая принимает на вход координаты 2 точек и находит расстояние между 
// ними в 2д пространстве.

/*
double FindLength(double x1, double y1, double x2, double y2)
{
    double a = (x2 - x1);
    double b = (y2 - y1);
    double c = Math.Sqrt(a*a + b*b);
           return c;   
}
Console.WriteLine("Input a number X1 of quart");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a number Y of quart");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a number X2 of quart");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a number Y2 of quart");
int y2 = Convert.ToInt32(Console.ReadLine());

double resalt = Math.Round((FindLength(x1, y1, x2, y2)), 2);

Console.WriteLine(resalt);
*/

//Задача 4. Напиште программу, которая принимает на вход число N  и выводит квадраты чисел
// от 1 до N.

void SquaNum(int n)
{
    int i = 1;
    while( i <= n)
    {
       Console.Write( (i * i) + " ");
       i++;
    }
}

Console.WriteLine("Input a number N");
int n = Convert.ToInt32(Console.ReadLine());

SquaNum(n);
