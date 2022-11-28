/*
Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N.
*/
/*
void ShowNumbers(int n)
{
    if (n>1) ShowNumbers(n-1);
    Console.Write(n+ " ");
}

ShowNumbers(5);
*/
/*
Напишите программу, которая будет принимать 
на вход число и возвращать сумму его цифр.
*/
/*
int SumOfDigits(int num)
{
 if(num != 0) return SumOfDigits(num/10) + num % 10;
 return 0 ;
}

Console.WriteLine(SumOfDigits(1234));
*/
/*
Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
*/
/*
void ShowNum(int m, int n)
{
    if (m > n) ShowNum(m - 1, n);
    Console.Write(m + " ");
    if (n > m) ShowNum(m + 1, n);
}

ShowNum(8, 5);
*/
/*
Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B.
*/

double DegreeAB(double a, double b)
{
    if (b > 0) return DegreeAB(a, b - 1) * a;
    if (b < 0) return DegreeAB(a, b + 1) * 1 / a;
    else  return 1;
}

Console.WriteLine(DegreeAB(20, -2));
