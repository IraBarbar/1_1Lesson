// Напишите программу, которая определяет сумму всех чисел от 1 до N.
/*
int FindSum(int number)
{
    int sum = 0;
    for (int current = 1 ; current <= number ; current ++)
    sum += current;
    return sum;
}
 
Console.Write("Input a number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of between 1 and {a} is {FindSum(a)}");
*/

//№2 Напишите программу, которая принимае на вход число и возвращает кол-во цифр в чсисле.

/*
int FindNum(int n)
{
    int sum = 0;
    while (n !=0)
    {
        n = n / 10 ;
        sum++;
    }    
    return sum;
}
Console.Write("Input a number ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{FindNum(n)}");
*/

//№3 Написать программу, которая опредеяет произведене чисел от 1 до N.

int FindProduct(int n)
{
  int product = 1 ;
  for ( int current = 1 ; current <= n; current++)
  product = current * product;
  return product;
}

Console.Write("Input a number ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{FindProduct(n)}");
