/*
Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
*/

int[,] GreatRandom2dArray(int rows, int colums, int minValue, int maxValue)  // rows- строки, colums столбцы
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Input a number of rows");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a number of columns");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a min possible value");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a max possible value");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = GreatRandom2dArray(m, n, min, max);
Show2dArray(myArray);

/*
№1 Задайте двумерный массив размера m на n,
 каждый элемент в массиве находится по формуле: Aij = i+j. 
 Выведите полученный массив на экран.
*/
/*
int [,] Great2dArray(int rows, int colums) 
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = i + j;
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

Console.WriteLine("Input a number of rows");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a number of columns");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Great2dArray(m, n);
Show2dArray(myArray);
*/
/*
№2 Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
 и замените эти элементы на их квадраты.
*/

void FindEven(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
}

FindEven(myArray);
Show2dArray(myArray);


/*
№3 Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/

/*
int FindSumElements(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            sum = sum + array[i,j];
        }
    return sum;
}

Console.WriteLine($"Sum of elements is {FindSumElements(myArray)}.");
*/