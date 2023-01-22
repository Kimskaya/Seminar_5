//  36: Create an array, filled with random numbers. 
// Find the sum of the numbers in odd positions
// [3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
int [] GetRandomArray (int Length)
{
    int [] array = new int [Length];
    for (int i = 0;i < Length; i ++)
    {
         array [i] = new Random().Next(-10, 10);
    }
    return array;
}
int [] Array = GetRandomArray (10); 

void ArrayOutput (int [] Array)
{
    Console.Write ($"[");
    for(int i = 0; i <Array.Length; i ++)
    {
        if (i != Array.Length-1)
        {
            Console.Write($"{Array[i]}, ");
        }
        else
        {
            Console.Write($"{Array[i]}]");
        }
    }
}
ArrayOutput (Array);
int GetOddNumbersSum (int []Array)
{
    int Sum=Array[1];
    int i = 1;
    while  ( i < Array.Length-1)
    {
    i = i+2;
    Sum=Sum + Array[i];   
    }
    return Sum;
}
int Result = GetOddNumbersSum(Array);
Console.WriteLine();
Console.WriteLine($" The Sum of the Numbers in odd positions is {Result}");