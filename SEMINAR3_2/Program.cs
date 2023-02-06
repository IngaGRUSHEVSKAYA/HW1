// Напишите программу, которая принимает число и посчитает сумму чисел от 1 до A.
/*
int GetSum(int num)
{
    int sum = 0;

    for(int current = 1; current <= num; current++)
        sum += current;

    return sum;
}

Console.Write("Input a positiv number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetSum(a);
Console.WriteLine($"Sum of elements from 1 to {a} is {GetSum(a)}");
*/

// Написать программу, которая выдает количество цифр в числе.
/*
int DigitCount(int number)
{
    int count = 0;
    while(number > 0)
    {
        count++;
        number /=10;
    }
    return count;
}
Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number of digits is: " + DigitCount(num));

*/
/*
int DigitCount(int number)
{
    int count = 0;
    while(number != 0)
    {
        count++;
        number /=10;
    }
    return count;
}
Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number of digits is: " + DigitCount(num));
*/







// Найти факториал !N.
/*
int Factorial(int number)
{
    int result = 1;
    for(int i = 1; i <= number; i++)
        result *= i;
    return result;
}
Console.Write("Enter number N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Factorial is: " + Factorial(numN));
*/

/*
int Factorial(int number)
{
    int result = 1;
    while(number > 1)
    {
        result *= number;
        number--;
    }
    return result;
}
Console.Write("Enter number N: ");
//int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Factorial is: " + Factorial(Convert.ToInt32(Console.ReadLine())));
*/


