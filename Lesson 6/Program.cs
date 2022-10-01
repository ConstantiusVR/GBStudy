// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


void CreateArray (int[] Array)
{
    Console.Write("Введите количество чисел, которое хотите ввести: ");
    int numbers = int.Parse(Console.ReadLine());
    int[] Array = new int[numbers]; 
    for (int i = 0; i < Array.Length; i++) 
    {
        Console.Write($"Введите элемент массива с индексом {i}: ");
        Array[i] = int.Parse(Console.ReadLine());
    }
    Console.Write("Вы ввели: ");
    for (int i = 0; i < Array.Length; i++) 
    {  
        Console.Write(Array[i]);

    }
    Console.ReadLine();
} 


 
 int CountNumbers (int[] Array)
 {
    int counter = 0;
    for (int i = 0; i< Array.Length; i++)
    {
        Array[i]>0;
        counter = counter +1;

    }
    return counter;
 }

 
CreateArray(M);
Console.WriteLine();
int result = CountNumbers(M);
Console.WriteLine(result);
Console.WriteLine(); 



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.



Console.WriteLine("введите значение k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите значение k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());


double x = (b1-b2)/(k2-k1);
double y = k1 * x + b1;

Console.WriteLine($"Прямые пересекутся в точке A ({x},{y})");
