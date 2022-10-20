/*
int CutNumber(int number)
{
    int ed = number % 10;
    int so = number /100;

    number = so * 10 + ed; // так как имя намбе уже нигде не используется
    return number; // cтрого однго типа

}



int num = new Random().Next(100, 1000); // последнее не включается.

int result = CutNumber(num);

Console.WriteLine($"New version of a number {num} is {result}");

*/
/*
int FindMax(int N)
{
    int ed = N % 10;
    int dec = N / 10;
    if( ed > dec) return ed;
    else return dec;
}
int n = new Random().Next(10, 100);
int result = FindMax(n);

Console.WriteLine($"In number {n} {result} is the biggest.");
*/
/*
bool MultN(int n1, int n2)
{
 if ( n2 % n1 == 0) return true;
 else return false;
}
Console.WriteLine("Please, enter the number1");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please, enter the number2");
int n2 = Convert.ToInt32(Console.ReadLine());

bool result = MultN(n1, n2);
Console.WriteLine($" Do is the number {n2} to the number {n1} multiple? - {result}.");
*/

//Задач 3. Напишите программу , которая
// принимает на входе два числа  и проверяет является ли одно число квадратом второго.

 bool SquNum(int n1, int n2)
 {
    if(n1 * n1 == n2 || n2 * n2 == n1) 
       return true;
    else
       return false; 
 }
 Console.WriteLine("Please, enter the number1");
 int n1 = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("Please, enter the number2");
 int n2 = Convert.ToInt32(Console.ReadLine());
  bool result = SquNum(n1, n2);
  Console.WriteLine(result);