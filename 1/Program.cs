// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// 1. создаем два двумерных массива 
// 2. создаем программу перемножения матриц тoчнее индексов
int[,] array=new int[2,2];
int[,] array2=new int[2,2];

void FillArray1(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]=new Random().Next(1,10);
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
FillArray1(array);
Console.WriteLine("----------------");
FillArray1(array2);

int[,] array3= new int[2,2];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array3[i,j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array3[i,j] += array[i, k] * array2[k, j];
            
        }
    }
}
Console.Write("Результирующая матрица будет:");
Console.WriteLine();
PrintArray2D(array3);

void PrintArray2D(int[,] array3)
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            Console.Write($"{array3[i, j] + "\t"} ");
        }
        Console.WriteLine();
    }
}
