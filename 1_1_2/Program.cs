/*
// Задача 1. Напришите программу, которая...

Console.Write("Imput the first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput the second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2 * n2;

if(n1 == quad2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/

/*
// Задача2

Console.Write ("Ведите целое число ");
int n = Convert.ToInt32(Console.ReadLine());

int current = -n;

while(current <= n)
{
    Console.Write(current + " ");
    current++;
    
}
*/

// Задаача 3 

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 10;
Console.WriteLine($"Lust digit of {num} is {result}");
