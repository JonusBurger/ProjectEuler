// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Hello, World!");
maximumSum();
//LatticePaths(21);
//longestCollatzSequence();
//calcLargeSum();
//long[,] testArray = new long[20, 20] {
//{ 08, 02, 22, 97, 38, 15, 00, 40, 00, 75, 04, 05, 07, 78, 52, 12, 50, 77, 91, 08},
//{ 49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 04, 56, 62, 00},
//{ 81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 03, 49, 13, 36, 65},
//{ 52, 70, 95, 23, 04, 60, 11, 42, 69, 24, 68, 56, 01, 32, 56, 71, 37, 02, 36, 91},
//{ 22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80},
//{ 24, 47, 32, 60, 99, 03, 45, 02, 44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50},
//{ 32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70},
//{ 67, 26, 20, 68, 02, 62, 12, 20, 95, 63, 94, 39, 63, 08, 40, 91, 66, 49, 94, 21},
//{ 24, 55, 58, 05, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72},
//{ 21, 36, 23, 09, 75, 00, 76, 44, 20, 45, 35, 14, 00, 61, 33, 97, 34, 31, 33, 95},
//{ 78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 03, 80, 04, 62, 16, 14, 09, 53, 56, 92},
//{ 16, 39, 05, 42, 96, 35, 31, 47, 55, 58, 88, 24, 00, 17, 54, 24, 36, 29, 85, 57},
//{ 86, 56, 00, 48, 35, 71, 89, 07, 05, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58},
//{ 19, 80, 81, 68, 05, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 04, 89, 55, 40},
//{ 04, 52, 08, 83, 97, 35, 99, 16, 07, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66},
//{ 88, 36, 68, 87, 57, 62, 20, 72, 03, 46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69},
//{ 04, 42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 08, 46, 29, 32, 40, 62, 76, 36},
//{ 20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 04, 36, 16},
//{ 20, 73, 35, 29, 78, 31, 90, 01, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 05, 54},
//{ 01, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 01, 89, 19, 67, 48}
//};
//Console.WriteLine(calcProduct(testArray, 16, 16, 2));
//Console.WriteLine(testArray[5, 0]);
//findLargestProduct(testArray);
//findSum();
//findSizes();
//findLargestAdjacency();
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
bool isPrimePimped(int value, int[] array)
{
    int squareValue = (int) Math.Pow(value, 0.5);
    for (int i = 0; i <= squareValue; i++)
    {
        if (array[i] == 0)
        {
            if (value % squareValue == 0)
            {
                return false;
            }
            else
            {
                array[i] = value;
                return true;
            }
        }
        if (value % array[i] == 0)
        {
            return false;
        }
    }
    for (int i = squareValue; i < array.Length; i++)
    {
        if (array[i] == 0)
        {
            array[i] = value;
            return true;
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
// Problem 9
void findSizes()
{
    bool solved = false;
    for (int b = 0; b < 1000; b++)
    {
        for (int a = 0; a < b; a++)
        {
            if (a + b + Math.Pow(Math.Pow(a, 2)+ Math.Pow(b, 2), 0.5) == 1000)
            {
                Console.WriteLine($"a is {a} and b is {b}");
                solved = true;
                break;
            }
        }
        if (solved)
        {
            break;
        }
    }
}
// Problem 10
void findSum()
{
    long sum = 5;
    int[] array = new int[2000000];
    array[0] = 2;
    array[1] = 3;
    for (int i = 4; i < 2000000; i++)
    {
        if (isPrimePimped(i, array))
        {
            sum += i;
        }
    }
    Console.WriteLine("Answer is: " + sum);
    for (int i = 0; i < 20; i++)
    {
        Console.WriteLine($"The {i} prime Number is: {array[i]}");
    }
}
// Problem 11
void findLargestProduct(long[,] array)
{
    int counter = 0;
    long maxValue = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            long value = 0;
            if (i < array.GetLength(0) - 3)
            {
                value = calcProduct(array, i, j, 1);
                counter++;
                if (value > maxValue)
                {
                    maxValue = value;
                }
                if (j < array.GetLength(0) - 3)
                {
                    value = calcProduct(array, i, j, 2);
                    if (value > maxValue)
                    {
                        maxValue = value;
                    }
                    counter++;
                }
            }
            if (j < array.GetLength(0) - 3)
            {
                value = calcProduct(array, i, j, 0);
                counter++;
            }
            if (value > maxValue)
            {
                maxValue = value;
            }
        }
    }
    Console.WriteLine($"Maximum is {maxValue}");
    Console.WriteLine($"In total there are {counter} calculations performed");
}
long calcProduct(long[,] array, int row, int column, int operation)
{
    long result = 1;
    for (int i = 0; i < 4; i++)
    {
        if (operation == 2)
        {
            result = result * array[row + i, column + i];
        } else if( operation == 1)
        {
            result = result * array[row + i, column];
        }
        else
        {
            result = result * array[row, column + i];
        }
    }
    return result;
}

void triangleNumber()
{
    int[] array = new int[100000];
    array[0] = 1;
    array[1] = 3;
    int[] primeStore = new int[100000];
    primeStore[0] = 2;
    primeStore[1] = 3;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + i+1;
        if (getDivisor(array[i], primeStore) > 500)
        {
            Console.WriteLine("The Value of the Triangle number is: " + array[i]);
            break;
        }
    }
}
int getDivisor(int checkNumber, int[] primeStore)
{
    int counter = 1;
    if (isPrimePimped(checkNumber, primeStore))
    {
        counter++;
        return counter;
    }
    for (int i = 1; i < checkNumber / 2; i++)
    {
        if (checkNumber % i == 0) { counter++; }
    }
    return counter;
}
// Problem 13
void calcLargeSum()
{
    ulong value = 0;
    value = 371072875339021
+ 463769376774900
+ 743249861995247
+ 919422133635741
+ 230675882075393
+ 892616706966236
+ 281128798128499
+ 442742289174325
+ 474514457360013
+ 703864861058430
+ 621764571418565
+ 649063524627419
+ 925758677183372
+ 582035653253593
+ 801811993848262
+ 353986643728271
+ 865155060062958
+ 716938887077154
+ 543700705768266
+ 532826541087568
+ 361232725250002
+ 458765761724109
+ 174237069058518
+ 811426604180868
+ 519343254517283
+ 624672216484350
+ 157324443869081
+ 550376875256787
+ 183363848253301
+ 803862875928784
+ 781828337579931
+ 167263201004368
+ 484030981290777
+ 870869875513927
+ 599594068957565
+ 697939506796526
+ 410526847082990
+ 653786073615010
+ 358290353174347
+ 949537597651053
+ 889028025717332
+ 252676802760780
+ 362702185404977
+ 240744869082311
+ 914302881971032
+ 344130655780161
+ 230530811728164
+ 114876969321549
+ 637832994906362
+ 677201869716985
+ 955482553002635
+ 760853271322857
+ 377742425354112
+ 237019132757256
+ 297988602722583
+ 184957014548792
+ 382982037830314
+ 348295438291999
+ 409579530664052
+ 297461521855023
+ 416981162220729
+ 624679571944012
+ 231897067725479
+ 861880882258753
+ 113067397083047
+ 829591747671403
+ 976233310448183
+ 428462801835170
+ 551216035469812
+ 322381957343293
+ 755061649651847
+ 621778427521926
+ 329241857071473
+ 995186714302352
+ 732674608005915
+ 768418225246744
+ 971426179103425
+ 877836461827993
+ 108488025216746
+ 713296124747824
+ 621840735723997
+ 666278919814880
+ 606618262936828
+ 857869440895529
+ 660243964099053
+ 649139826800329
+ 167309393198727
+ 948093772450487
+ 786391670211874
+ 153687137119366
+ 407899231155355
+ 448899115014406
+ 415031288803395
+ 812348806732101
+ 826165707739483
+ 229188020587773
+ 771585425020165
+ 721078384350691
+ 208496039801340
+ 535035342264725;
    Console.WriteLine(value);
}

// Problem 14
void longestCollatzSequence()
{
    long[] storageArray = new long[100000000];
    long max = 0;
    int uberI = 0;
    for (int i = 1; i <= 1000000; i++)
    {
        long value = 0;
        value = longestCollatzSequenceRec(i, storageArray, value);
        storageArray[i] = value;
        if (value > max)
        {
            max = value;
            uberI = i;
        }
    }
    Console.WriteLine("Maximum is: " + max);
    Console.WriteLine("With the i: " + uberI);
}
long longestCollatzSequenceRec(long value, long[] storage, long max)
{
    if (value < storage.Length)
    {
        if (storage[value] != 0)
        {
            return storage[value];
        }
    }
    if (value == 1)
    {
        return 1;
    }
    if (value % 2 == 0)
    {
        return max + 1 + longestCollatzSequenceRec(value / 2, storage, max);
    }
    else
    {
        return max + 1 + longestCollatzSequenceRec((value * 3 + 1), storage, max);
    }
}
// Problem 15
void LatticePaths(int size)
{
    long[,] storage = new long[size, size];
    Console.WriteLine("Result is: "+ LatticePathsRec([0, 0], [size - 1, size - 1], storage, size));

}
long LatticePathsRec(int[] position, int[] target, long[,] storage, int size)
{
    if (position[0] >= size)
    {
        return 0;
    }
    if (position[1] >= size)
    {
        return 0;
    }
    if (storage[position[0], position[1]] != 0)
    {
        return storage[position[0], position[1]];
    }
    if (position[0] == target[0] && position[1] == target[1])
    {
        return 1;
    }

    long rightPath = LatticePathsRec([position[0] + 1, position[1]], target, storage, size);
    long leftPath = LatticePathsRec([position[0], position[1] + 1], target, storage, size);
    storage[position[0], position[1]] = rightPath + leftPath;
    return rightPath + leftPath;
}
// Problem 17
void NumberLetterCounts()
{
    int[] arrayLow = [3, 3, 5, 4, 4, 3, 5, 5, 4, 3, 6, 6, 8,8, 7,7,9,8,8];
    int[] arrayTenth = [6, 6, 5, 5, 5, 7, 6, 6];
    int result = 0;
    for (int i = 1; i < 1000; i++)
    {
        int reducedI = i;
        if (reducedI >= 100)
        {
            result += arrayLow[(reducedI / 100) - 1];
            result += 7;
            reducedI = reducedI % 100;
            if (reducedI != 0)
            {
                result += 3;
            } else
            {
                continue;
            }
        }
        if (reducedI < 20)
        {
            result += arrayLow[reducedI - 1];
        }
        else if (reducedI >= 20)
        {
            int tenth = reducedI / 10;
            result += arrayTenth[tenth - 2];
            if (reducedI % 10 != 0)
            {
                result += arrayLow[(reducedI % 10) - 1];
            }
        }
    }
    result += 11;
    Console.WriteLine("Total Value is: " + result);
}
// Problem 18
void maximumSum()
{
    int[] line1 = [75];
    int[] line2 = [95, 64];
    int[] line3 = [17, 47, 82];
    int[] line4 = [18, 35, 87, 10];
    int[] line5 = [20, 04, 82, 47, 65];
    int[] line6 = [19, 01, 23, 75, 03, 34];
    int[] line7 = [88, 02, 77, 73, 07, 63, 67];
    int[] line8 = [99, 65, 04, 28, 06, 16, 70, 92];
    int[] line9 = [41, 41, 26, 56, 83, 40, 80, 70, 33];
    int[] line10 = [41, 48, 72, 33, 47, 32, 37, 16, 94, 29];
    int[] line11 = [53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14];
    int[] line12 = [70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57];
    int[] line13 = [91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48];
    int[] line14 = [63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31];
    int[] line15 = [04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23];
    int[,] pyramid = new int[15, 15];
    int j = 0;
    for (int i = 0; i < line1.Length; i++)
    {
        pyramid[j, i] = line1[i];
    }
    j++;
    for (int i = 0; i < line2.Length; i++)
    {
        pyramid[j, i] = line2[i];
  
    }
    j++;
    for (int i = 0; i < line3.Length; i++)
    {
        pyramid[j, i] = line3[i];
        
    }
    j++;
    for (int i = 0; i < line4.Length; i++)
    {
        pyramid[j, i] = line4[i];
    }
    j++;
    for (int i = 0; i < line5.Length; i++)
    {
        pyramid[j, i] = line5[i];
    }
    j++;
    for (int i = 0; i < line6.Length; i++)
    {
        pyramid[j, i] = line6[i];
    }
    j++;
    for (int i = 0; i < line7.Length; i++)
    {
        pyramid[j, i] = line7[i];
    }
    j++;
    for (int i = 0; i < line8.Length; i++)
    {
        pyramid[j, i] = line8[i];
    }
    j++;
    for (int i = 0; i < line9.Length; i++)
    {
        pyramid[j, i] = line9[i];
    }
    j++;
    for (int i = 0; i < line10.Length; i++)
    {
        pyramid[j, i] = line10[i];
    }
    j++;
    for (int i = 0; i < line11.Length; i++)
    {
        pyramid[j, i] = line11[i];
    }
    j++;
    for (int i = 0; i < line12.Length; i++)
    {
        pyramid[j, i] = line12[i];
    }
    j++;
    for (int i = 0; i < line13.Length; i++)
    {
        pyramid[j, i] = line13[i];
    }
    j++;
    for (int i = 0; i < line14.Length; i++)
    {
        pyramid[j, i] = line14[i];
    }
    j++;
    for (int i = 0; i < line15.Length; i++)
    {
        pyramid[j, i] = line15[i];
    }
    int[,] storage = new int[15, 15];
    int result = MaxPoints(0, 0);
    int MaxPoints(int i, int j)
    {
        if (i >= pyramid.GetLength(0))
        {
            return 0;
        }
        if (pyramid[i,j] == 0)
        {
            return 0;
        }
        if (storage[i,j] != 0)
        {
            return storage[i, j];
        }
        int goDown = pyramid[i, j] + MaxPoints(i + 1, j);
        int goLeft = pyramid[i, j] + MaxPoints(i + 1, j + 1);
        if (goDown > goLeft)
        {
            storage[i, j] = goDown;
            return goDown;
        }
        storage[i, j] = goLeft;
        return goLeft;
    }
    Console.WriteLine("The Maximum path is " + result);
}
