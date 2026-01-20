// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Hello, World!");
evenFibos(4000000);
//Multiplesof3or5(1000);
//solveZero(764000);
// Solve Problem 0
void solveZero(Int64 value)
{
    value = value / 2;
    Int64 countSum = 0;
    for (Int64 i = 1; i <= value; i++)
    {
        Int64 square = (2*i-1)* (2 * i - 1);
        countSum += square;
    }
    Console.WriteLine($"Resulting Square is: {countSum}");
}

// Solve Problem 1
void Multiplesof3or5(long value)
{
    long sum = 0;
    for (long i = 1; i < value; i++)
    {
        if (i % 5 == 0)
        {
            sum += i;
        } else if (i % 3 == 0)
        {
            sum += i;
        }
    }
    Console.WriteLine("Resulting Sum is: ");
    Console.Write(sum);
}

// Solve Problem 2
void evenFibos(int value)
{
    long[] fiboStorage = new long[value];
    long fiboValue = 1;
    long sumEven = 0;
    int i = 1;
    while (fiboValue < value)
    {
        if (i == 1 || i == 2)
        {
            fiboStorage[i] = fiboValue;
        } else
        {
            fiboValue = fiboStorage[i - 1] + fiboStorage[i - 2];
            fiboStorage[i] = fiboValue;
        }
        if (fiboValue % 2 == 0)
        {
            sumEven += fiboValue;
        }
        i++;
    }

    Console.WriteLine($"Sum of all the even fibonacci Numbers that don´t exceed {value} is {sumEven}");
}
