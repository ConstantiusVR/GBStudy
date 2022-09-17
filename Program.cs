// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// УРОК 3


// Задача 19 (Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.)


 int a = Console.Read();
 Console.Write("Введите пятизначное число a: ");

 Console.WriteLine(a);

 string Checker (int a)
 {
     if (10000 <= a; a<100000);
      { 
         string result = "Введено неверное число!";
      };
     int firstNum = a/10000;
     int lastNum = a%10;
     int firstStep = a%10000;
     int secondNum = firstStep/1000;
     int secondStep = a%100;
     int fourthNum = secondStep/10;


if(firstNum == lastNum, secondNum == fourthNum);
      { 
       string result = "Да";
      };
    
    string result = "Нет";
    
  }

// Задача 23 (Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N)


 int n = Console.Read();
 Console.Write("Введите целое число n: ");
 Console.WriteLine(n);
 int CubesOfNumber (int n)
 {
    for (int i = 1; i<=n; i++)
    {
        return i*i*i;
    }
 }



// Задача 21 (Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.)


int [] array a = {x1, y1, z1};
int [] array b = {x2, y2, z2};

int LengthCounter (array a, array b)
{   int lengthAB = 0;
    int m = 2;
    int first = x2-x1; 
     int x = Math.Pow(first, m);
    int second = y2-y1;
    int y = Math.Pow(second, m);
    int third = z2-z1;
    int z = Math.Pow(third, m);

  return lengthAB = Math.Sqrt(x + y + z);

}
 int array a = {1,2,6};
 int array b = {3,9,11}; 

 int c = LengthCounter();
 Console.WriteLine(c);

 // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Exponentiation (int a, int b)
{ 
    int i = 0;
    
    while (i<= b)
    {
        int result = 1;
        result = result*a;
        i++;
        
    }
    return result;
}
int a = 2;
int b = 3;

int c = Exponentiation(a,b);

Console.WriteLine(c);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int number = Console.Read();
 Console.Write("Введите целое число number: ");
 Console.WriteLine(number);

int SumOfNumbers(int number)
{
    while (number< a)
    {
        int a = 10;
        int result = 0;
        result = result + number % a;
        number = number/10;
    }
    return result;
}