// See https://aka.ms/new-console-template for more information
int Min = 0;
int Max = 100;

// this declares an integer array with 5 elements
// and initializes all of them to their default value
// which is zero
int[] array = new int[10];

Random randNum = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = randNum.Next(Min, Max);
}
foreach (var item in array)
{
    Console.WriteLine(item.ToString());
}
Array.Sort(array);
foreach (var item in array)
{
    Console.WriteLine(item.ToString());
}
Array.Reverse(array);
foreach (var item in array)
{
    Console.WriteLine(item.ToString());
}
int[,] array3by3 = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
int[][] jaggedarray = new int[3][];