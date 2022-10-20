// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// Console.WriteLine("Введите целое число M:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите целое число N:");
// int n = Convert.ToInt32(Console.ReadLine());

// void SeriesOfNumbers (int m, int n)
// {
//    if (m>n || m==n) 
//    {
//        Console.WriteLine("Введите числа так, чтобы M было меньше N");
//    }
//    while (m<=n)
//    {
//        Console.WriteLine (m);
//        m++;
//    }
// }
// Console.WriteLine();
// SeriesOfNumbers(m,n); 

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.WriteLine("Введите целое число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число N:");
int n = Convert.ToInt32(Console.ReadLine());

int SumOfNumbers (int m, int n)
{ 

    if (m>n || m==n) 
    {
        Console.WriteLine("Введите числа так, чтобы M было меньше N");
    }
    int sum = 0;
    while (m<n)
    {
        sum = sum + m;
        
    }
    return sum;
}
Console.WriteLine();
SumOfNumbers(m, n);
