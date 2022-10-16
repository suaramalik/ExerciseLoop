// See https://aka.ms/new-console-template for more information
using System.Data;
Console.WriteLine("This is a 4x4 matrix");
int rows = 4; 
int cols = 4; 
int[,] matric = new int[rows, cols];
Console.WriteLine("enter the cells of the matrices");
for (int row= 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write("matrix[{0},{1}] = ", row, col);
        matric[row, col] = int.Parse(Console.ReadLine());
    }
}
for (int row= 0; row< matric.GetLength(0); row++)
{
    for (int col = 0; col< matric.GetLength(1); col++)
    {
        Console.Write(" " + matric[row, col]);
    }
    Console.WriteLine();
}


