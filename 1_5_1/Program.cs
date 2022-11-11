int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random(). Next(minValue, maxValue + 1);
    }
    return array;
} 

void ShowArray ( int [] array)
{
    for ( int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    Console.WriteLine();    
}
/*
int FindNegativeSum(int [] array)
{
    int sum = 0;
    for (int i =0 ; i< array.Length; i++)
        if (array[i] < 0)
            sum += array[i];
    return sum;        
}

Console.WriteLine("Input a number of elements");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a min possible value");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a max possible value");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);

int negativeSum = FindNegativeSum(myArray);
Console.WriteLine("Sum of negative elements is " + (negativeSum));
*/

//№1 Напишите программу, которая определяет присуствует ли заданное число в массиве.

bool FindNumber( int [] array, int n )
{
   for (int i = 0 ; i < array.Length; i++)
        if ( array[i] == n)
            return true;
    return false;
}

Console.WriteLine("Input a number of elements");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a min possible value");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a max possible value");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input your number: ");
int a = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);

FindNumber(myArray, a);
if (FindNumber(myArray, a) == true)
    Console.WriteLine("Your number is in this array.");
    else
    Console.WriteLine("Your number is not in this array.");