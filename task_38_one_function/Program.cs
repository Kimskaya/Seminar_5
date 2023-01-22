//task 38: create an array of rational numbers and find the diffrence 
// between the max and the min number in this array
// [3 7 22 2 78] -> 76
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

int MinMaxdiff(int[] Array)
{
    int result = 0;
    int i =0;
    int Min = Array[0];
    int Max = Array[0];
    for (i = 0; i < Array.Length; i ++)
        {
            if (Array[i] >= Max)
            {
             Max = Array [i];
            }
            else if (Array[i] < Min)
            {
             Min = Array[i];
            }
         }
result = (Max - Min);
return result;         
}
int Difference = MinMaxdiff(Array);
Console.WriteLine();
Console.WriteLine($"The difference between max and min elements is {Difference}");