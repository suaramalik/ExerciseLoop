// See https://aka.ms/new-console-template for more information


using System.ComponentModel.DataAnnotations;

Console.WriteLine("input length of array");
int lenght = int.Parse(Console.ReadLine());
int val = 0;
int flag = 0;
int[] arr2 = new int[lenght];
for (int i = 0; i < lenght; i++)
{
    Console.WriteLine($"input the value of your array at index {i}");

    val = int.Parse(Console.ReadLine());
    arr2[i] = val;
}
Console.WriteLine("Input length of array");
int lenght2 = int.Parse(Console.ReadLine());
int val2 = 0;
int[] arr3 = new int[lenght2];
for (int l = 0; l < lenght2; l++)
{
    Console.WriteLine($"Input the value of your array at index {l}");
    val2 = int.Parse(Console.ReadLine());
    arr3[l] = val2;
}
if (lenght==lenght2)
{
    for (int i = 0; i < lenght; i++)
    {
        if (arr2[i] == arr3[i])
        {
          flag = 1;
        }
        else
        {
            flag = 2;
           break;
        }

    }
    if(flag != 1)
    {
        Console.WriteLine("array is not equal");
    }
    else
    {
        Console.WriteLine("Array is equal");
    }
}


