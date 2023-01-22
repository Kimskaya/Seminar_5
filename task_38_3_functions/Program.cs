//task 38: create an array of rational numbers and find the diffrence 
// between the max and the min number in this array
//[3 7 22 2 78] -> 76
int [] GetRandomArray (int Length)
{
    int [] array = new int [Length];
    for (int i = 0;i < Length; i ++)
    {
         array [i] = new Random().Next(-100, 100);
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

int GetMaxNumber (int [] Array)
{
    int i = 0;
    int Max = Array[i];
    while (i <Array.Length)
    {
        if (Array[i]>Max)
        {
         Max = Array[i];
         i ++;
        }
        else 
        {
            i ++;
        }
    }
return Max;
}
int MaxResult = GetMaxNumber (Array);

int GetMinNumber (int [] Array)
{
int i = 0;
int Min = Array[i];

     while (i<Array.Length)
     {
      if (Array[i]<Min)
      {
      Min= Array[i];
      i++;
      }
      else 
      {
        i++;
      }
     }
return Min;
}
int MinResult = GetMinNumber (Array);
int FindMAxMinDiff (int MaxResult, int MinResult)
{
 int Diff = MaxResult-MinResult;
return Diff;
}
int difference = FindMAxMinDiff (MaxResult, MinResult);
Console.WriteLine();
Console.WriteLine ($"The difference between Max and Min numbers is {difference}"!);   