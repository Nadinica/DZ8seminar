// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4                
//3 2 | 3 3
//Результирующая матрица будет:
//18 20             c11=a11*b11+a12*b21=2*3+4*3
//15 18             c12=a11*b12+a12*b22=2*4+4*3
//                  c21=a21*b11+a22*b21=3*3+2*3
//                  c22=a21*b12+a22*b22=3*4+2*3

void FillMatrix(int[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(1, 10);
        }
    }
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите размер матрицы ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[size, size];
FillMatrix(matrix1);
int[,] matrix2 = new int[size, size];
FillMatrix(matrix2);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);

int[,] matrix3 = new int[size, size];
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int h = 0; h < size; h++)
        {
            matrix3[i, j] = matrix3[i, j] + (matrix1[i, h] * matrix2[h, j]);
        }
    }
}
Console.WriteLine("Произведение матриц получается ");
PrintMatrix(matrix3);
