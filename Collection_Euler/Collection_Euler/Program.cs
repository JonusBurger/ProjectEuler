// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Hello, World!");
findLargestAdjacency();
//specificPrime(10001);
// sumSquareBrute(100);
// smallestNumber();
//PalindromeProduct();
//PrimeFactor(600851475143);
//evenFibos(4000000);
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

// Sovle Problem 3
void PrimeFactor(long value)
{
    List<long> primeFactor = new List<long>();
    long number = 2;
    while (value != 1)
    {
        if (isPrime(number))
        {
            if (value % number == 0)
            {
                value = value / number;
                primeFactor.Add(number);
            }
        }
        number++;
    }
    Console.WriteLine("Resulting List: ");
    foreach (long entry in primeFactor)
    {
        Console.Write($", {entry}");
    }

}
bool isPrime(long value)
{
    if (value <= 2)
    {
        return false;
    }
    for (int i = 2; i < value / 2; i++)
    {
        if (value % i == 0)
        {
            return false;
        }
    }
    return true;
}

// Solve Problem 4
void PalindromeProduct()
{
    int firstFactor = 999;
    int secondFactor = 999;
    string maxPalindrom;
    long maxValPalindrom = 0;
    for (int i = firstFactor; i > 0; i--)
    {
        for (int j = secondFactor; j > 0; j--)
        {
            long currVal = i * j;
            string Palindrom = (currVal).ToString();
            if (Palindrom == ReverseString(Palindrom))
            {
                if (currVal > maxValPalindrom)
                {
                    maxPalindrom = Palindrom;
                    maxValPalindrom = currVal;
                }
                break;
            }
        }
    }

    Console.WriteLine("The Largest Palindrom is " + maxValPalindrom);
    Console.WriteLine($"As First Factor {firstFactor} was used and for second factor {secondFactor}");
}

string ReverseString(string s)
{
    char[] chararray = s.ToCharArray();
    Array.Reverse(chararray);

    return new string(chararray);
}

void smallestNumber()
{
    // Zahl / 20 ist auch durch / 10 und / 5 und / 2 Teilbar
    // 19
    // Zahl 18 / 9 / 3 Teilbar
    // 17
    // Zahl 16 / 8 / 4 Teilbar
    // Zahl 15
    // Zahl 14 / 7 teilbar
    // Zahl 13
    // Zahl 12 / 6
    // Zahl 11
    long findNumber = 20*11;
    while (findNumber % 20 != 0 || findNumber % 19 != 0 || findNumber % 18 != 0 || findNumber % 17 != 0 ||
        findNumber % 16 != 0 || findNumber % 15 != 0 || findNumber % 14 != 0 || findNumber % 13 != 0 || 
        findNumber % 12 != 0 || findNumber % 11 != 0)
    {
        findNumber += 22;
    }

    Console.WriteLine(findNumber);

}
void sumSquareBrute(int number)
{
    long sumSquare = 0;
    long squareSum = 0;

    for (long i = 1; i <= number; i++)
    {
        sumSquare += i * i;
        squareSum += i;
    }
    Console.WriteLine($"Sum of Squares is {sumSquare} and Square Sum is {squareSum * squareSum} with a difference of {squareSum * squareSum - sumSquare}");
}

void specificPrime(int value)
{
    long prime;
    int count = 1;
    long i = 3;
    while (count != value)
    {
        i++;
        if (isPrime(i))
        {
            count++;
        }
        
    }
    Console.WriteLine($"The 10001 Primenumber is {i}");
}

void findLargestAdjacency()
{
    int[] startArray = [7, 3, 1, 6, 7, 1, 7, 6, 5, 3, 1, 3, 3, 0, 6, 2, 4, 9, 1, 9, 2, 2, 5, 1, 1, 9, 6, 7, 4, 4, 2, 6, 5, 7, 4, 7, 4, 2, 3, 5, 5, 3, 4, 9, 1, 9, 4, 9, 3, 4,
                        9, 6, 9, 8, 3, 5, 2, 0, 3, 1, 2, 7, 7, 4, 5, 0, 6, 3, 2, 6, 2, 3, 9, 5, 7, 8, 3, 1, 8, 0, 1, 6, 9, 8, 4, 8, 0, 1, 8, 6, 9, 4, 7, 8, 8, 5, 1, 8, 4, 3,
                        8, 5, 8, 6, 1, 5, 6, 0, 7, 8, 9, 1, 1, 2, 9, 4, 9, 4, 9, 5, 4, 5, 9, 5, 0, 1, 7, 3, 7, 9, 5, 8, 3, 3, 1, 9, 5, 2, 8, 5, 3, 2, 0, 8, 8, 0, 5, 5, 1, 1,
                        1, 2, 5, 4, 0, 6, 9, 8, 7, 4, 7, 1, 5, 8, 5, 2, 3, 8, 6, 3, 0, 5, 0, 7, 1, 5, 6, 9, 3, 2, 9, 0, 9, 6, 3, 2, 9, 5, 2, 2, 7, 4, 4, 3, 0, 4, 3, 5, 5, 7,
                        6, 6, 8, 9, 6, 6, 4, 8, 9, 5, 0, 4, 4, 5, 2, 4, 4, 5, 2, 3, 1, 6, 1, 7, 3, 1, 8, 5, 6, 4, 0, 3, 0, 9, 8, 7, 1, 1, 1, 2, 1, 7, 2, 2, 3, 8, 3, 1, 1, 3,
                        6, 2, 2, 2, 9, 8, 9, 3, 4, 2, 3, 3, 8, 0, 3, 0, 8, 1, 3, 5, 3, 3, 6, 2, 7, 6, 6, 1, 4, 2, 8, 2, 8, 0, 6, 4, 4, 4, 4, 8, 6, 6, 4, 5, 2, 3, 8, 7, 4, 9,
                        3, 0, 3, 5, 8, 9, 0, 7, 2, 9, 6, 2, 9, 0, 4, 9, 1, 5, 6, 0, 4, 4, 0, 7, 7, 2, 3, 9, 0, 7, 1, 3, 8, 1, 0, 5, 1, 5, 8, 5, 9, 3, 0, 7, 9, 6, 0, 8, 6, 6,
                        7, 0, 1, 7, 2, 4, 2, 7, 1, 2, 1, 8, 8, 3, 9, 9, 8, 7, 9, 7, 9, 0, 8, 7, 9, 2, 2, 7, 4, 9, 2, 1, 9, 0, 1, 6, 9, 9, 7, 2, 0, 8, 8, 8, 0, 9, 3, 7, 7, 6,
                        6, 5, 7, 2, 7, 3, 3, 3, 0, 0, 1, 0, 5, 3, 3, 6, 7, 8, 8, 1, 2, 2, 0, 2, 3, 5, 4, 2, 1, 8, 0, 9, 7, 5, 1, 2, 5, 4, 5, 4, 0, 5, 9, 4, 7, 5, 2, 2, 4, 3,
                        5, 2, 5, 8, 4, 9, 0, 7, 7, 1, 1, 6, 7, 0, 5, 5, 6, 0, 1, 3, 6, 0, 4, 8, 3, 9, 5, 8, 6, 4, 4, 6, 7, 0, 6, 3, 2, 4, 4, 1, 5, 7, 2, 2, 1, 5, 5, 3, 9, 7,
                        5, 3, 6, 9, 7, 8, 1, 7, 9, 7, 7, 8, 4, 6, 1, 7, 4, 0, 6, 4, 9, 5, 5, 1, 4, 9, 2, 9, 0, 8, 6, 2, 5, 6, 9, 3, 2, 1, 9, 7, 8, 4, 6, 8, 6, 2, 2, 4, 8, 2,
                        8, 3, 9, 7, 2, 2, 4, 1, 3, 7, 5, 6, 5, 7, 0, 5, 6, 0, 5, 7, 4, 9, 0, 2, 6, 1, 4, 0, 7, 9, 7, 2, 9, 6, 8, 6, 5, 2, 4, 1, 4, 5, 3, 5, 1, 0, 0, 4, 7, 4,
                        8, 2, 1, 6, 6, 3, 7, 0, 4, 8, 4, 4, 0, 3, 1, 9, 9, 8, 9, 0, 0, 0, 8, 8, 9, 5, 2, 4, 3, 4, 5, 0, 6, 5, 8, 5, 4, 1, 2, 2, 7, 5, 8, 8, 6, 6, 6, 8, 8, 1,
                        1, 6, 4, 2, 7, 1, 7, 1, 4, 7, 9, 9, 2, 4, 4, 4, 2, 9, 2, 8, 2, 3, 0, 8, 6, 3, 4, 6, 5, 6, 7, 4, 8, 1, 3, 9, 1, 9, 1, 2, 3, 1, 6, 2, 8, 2, 4, 5, 8, 6,
                        1, 7, 8, 6, 6, 4, 5, 8, 3, 5, 9, 1, 2, 4, 5, 6, 6, 5, 2, 9, 4, 7, 6, 5, 4, 5, 6, 8, 2, 8, 4, 8, 9, 1, 2, 8, 8, 3, 1, 4, 2, 6, 0, 7, 6, 9, 0, 0, 4, 2,
                        2, 4, 2, 1, 9, 0, 2, 2, 6, 7, 1, 0, 5, 5, 6, 2, 6, 3, 2, 1, 1, 1, 1, 1, 0, 9, 3, 7, 0, 5, 4, 4, 2, 1, 7, 5, 0, 6, 9, 4, 1, 6, 5, 8, 9, 6, 0, 4, 0, 8,
                        0, 7, 1, 9, 8, 4, 0, 3, 8, 5, 0, 9, 6, 2, 4, 5, 5, 4, 4, 4, 3, 6, 2, 9, 8, 1, 2, 3, 0, 9, 8, 7, 8, 7, 9, 9, 2, 7, 2, 4, 4, 2, 8, 4, 9, 0, 9, 1, 8, 8,
                        8, 4, 5, 8, 0, 1, 5, 6, 1, 6, 6, 0, 9, 7, 9, 1, 9, 1, 3, 3, 8, 7, 5, 4, 9, 9, 2, 0, 0, 5, 2, 4, 0, 6, 3, 6, 8, 9, 9, 1, 2, 5, 6, 0, 7, 1, 7, 6, 0, 6,
                        0, 5, 8, 8, 6, 1, 1, 6, 4, 6, 7, 1, 0, 9, 4, 0, 5, 0, 7, 7, 5, 4, 1, 0, 0, 2, 2, 5, 6, 9, 8, 3, 1, 5, 5, 2, 0, 0, 0, 5, 5, 9, 3, 5, 7, 2, 9, 7, 2, 5,
                        7, 1, 6, 3, 6, 2, 6, 9, 5, 6, 1, 8, 8, 2, 6, 7, 0, 4, 2, 8, 2, 5, 2, 4, 8, 3, 6, 0, 0, 8, 2, 3, 2, 5, 7, 5, 3, 0, 4, 2, 0, 7, 5, 2, 9, 6, 3, 4, 5, 0];
    long max = 0;
    for (int i = 0; i < (startArray.Length - 13); i++)
    {
        long currVal = 1;
        int[] subArray = startArray.Skip(i).Take(13).ToArray();
        foreach(long val in subArray)
        {
            currVal *= val;
        }
        if (currVal > max)
        {
            max = currVal;
        }
    }

    Console.WriteLine("Resulting Number is: " + max);

}

void findSizes()
{

}

