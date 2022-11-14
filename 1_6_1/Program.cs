
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
void ReverseArray(int[] array)
{
    for (int i = 1 ; i < array.Length / 2 ; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length -1 - i];
        array[array.Length - 1 - i] = temp;
    }
}
*/
/*
void ReverseArray(int[] array)
{
    for (int i = 1, j = array.Length -1  ; i < j ; i++ , j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
*/

Console.WriteLine("Input a number of elements");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a min possible value");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a max possible value");
int max = Convert.ToInt32(Console.ReadLine());
/*
int [] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);

ReverseArray(myArray);
ShowArray(myArray);
*/
// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: a и b.
/*
int [] Fibonatty (int a, int b, int n)
{
    int [] array = new int [n];
    array [0] = a;
    array[1] = b;
    for (int i = 2 ; i < n ; i++)
    {
        array[i] = array[i - 1] + array[i-2];
    }
return array;
}

Console.WriteLine("Input a number N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a  number a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a number b: ");
int b = Convert.ToInt32(Console.ReadLine());

ShowArray(Fibonatty (a, b, n));
*/


//Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования.

int [] CopyArray (int [] array)
{
    int [] copyArray = new int [array.Length];
    for (int i = 0 ; i < array.Length; i++ )
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}

int [] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
ShowArray(CopyArray(myArray));



