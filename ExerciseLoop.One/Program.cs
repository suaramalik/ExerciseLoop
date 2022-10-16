// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello,Abdulmalik!");


//int[] arr = new int[] { 1, 3, 3, 3, 3, 3, 5 };

//for(int i = 0; i < arr.Length; i++)
//    Console.WriteLine(arr[i]);
//int[] arr = new int[] { 1, 2, 3, 4, 4, 5, 2, 4, 7, 9, 9, 3, 2, 3, 7, 8, 9, 5, 7, 6, 5 };
//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i] * 5);
//}

Console.WriteLine("Please Enter length of your array");
int len = int.Parse(Console.ReadLine());

int val = 0;

int[] arr2 = new int[len];

for (int i = 0; i < len; i++)
{
    Console.WriteLine($"Please Enter the value of your array at index {i} ");
    val = int.Parse(Console.ReadLine());
    arr2[i] = val;
}
Console.WriteLine("My array List Data below");
foreach (var item in arr2)
{
    Console.WriteLine($"{item} * 5 = {item * 5}");
}













