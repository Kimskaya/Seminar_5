//  34 Create an array with random positive three digit numbers 
// write the programm which shows the quantity of positive ordinary numbers 
// [345, 897, 568, 234] -> 2
int [] GetRandomArray (int Length)
{
    int [] array = new int [Length];
    for (int i = 0;i < Length; i ++)
    {
         array [i] = new Random().Next(99, 1000);
    }
    return array;
}
int [] Array = GetRandomArray (5); 

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
int CountPositiveOrdinary (int []Array)
{
int Count =0;
   for (int i = 0;i < Array.Length; i++)
   {
    
    if (Array[i]%2 ==0)
    {
        Count=Count+1; 
    }
    
   }
   return Count;
}
int Result = CountPositiveOrdinary (Array);
if (Result<2 && Result>0)
{
Console.WriteLine();
Console.WriteLine($"There is {Result} ordinary number in this array");
}
else
Console.WriteLine();
Console.WriteLine($"There are {Result} positive ordinary numbers in this array");
