// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void CreateArray (int [] array)
{
    int length = array.Length;
    int i = 0;
    while (i< length)
    {
        array[i] = new Random().Next (100,1000);
        i++;
    }
}

int [] a = new int[3];

void Print(int[] arr)
{
    int count = arr.Length;
    int number = 0;
    while (number< count)
    {
        Console.WriteLine(arr [number]);
        number++;
    }
}

int CountNums (int[] a)
{
    int count = a.Length;
    int ind = 0;
    int num = 0;
    while (ind< count)
    {
        if (a[ind]%2 == 0) 
        {
            num = num + 1;
        }
        ind++;
    }
    return num;
}

CreateArray(a);
Print(a);
Console.WriteLine();

int result = CountNums(a);
Console.WriteLine(result);
Console.WriteLine();


//  Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

void CreateNewArray (int [] array)
{
    int length = array.Length;
    int i = 0;
    while (i< length)
    {
        array[i] = new Random().Next (1,100);
        i++;
    }
}

int [] b = new int[9];

void PrintArr(int[] arr)
{
    int count = arr.Length;
    int number = 0;
    while (number< count)
    {
        Console.WriteLine(arr [number]);
        number++;
    }
}

int CountSum (int[] b)
{
    int counter = b.Length;
    int j = 0;
    int s = 0;
    while (j< counter)
    {
        
        if(j%2 ==1)
        {
            s = s + b[j];

        }
        j++;
    }
    return s;

}

CreateNewArray(b);
PrintArr(b);
Console.WriteLine();

int calculation = CountSum(b);
Console.WriteLine(calculation);
Console.WriteLine();


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void CreateRealArray (double [] array)
{
    int length = array.Length;
    int i = 0;
    while (i< length)
    {
        array[i] = new Random().Next (-100,100);
        i++;
    }
}

double [] c = new double[4];

void PrintRealArr(double[] arr)
{
    int count = arr.Length;
    int number = 0;
    while (number< count)
    {
        Console.WriteLine(arr [number]);
        number++;
    }
}

double CountDiff (double[] c)
{
    int quantity = c.Length;
    int index = 0;
    double max = c[0];
    double min = c[0];
    double diff = max - min;
    while (index< quantity)
    {
        if (c[index]>max)
        {
            c[index] = max;
            index++;
        } 
        if (c[index]<min)
        {
            c[index] = min;
            index++;
        }
        

    }
     return diff;

}

CreateRealArray(c);
PrintRealArr(c);
Console.WriteLine();

double difference = CountDiff(c);
Console.WriteLine(difference);