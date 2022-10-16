// See https://aka.ms/new-console-template for more information
using System;
char[] myArray = { 'a','b', 'c', 'd' };
char[] myArray2 = { 'a', 'f', 'c','e' };
int L1 = myArray.Length;
int L2 = myArray2.Length;
if (L1 > L2)
{
    Console.WriteLine("L1 is lexicographyically first");
}
else
{
    Console.WriteLine("l2 is lexicographyically first");
}


