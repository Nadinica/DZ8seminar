// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.
//Например, задан массив:              В итоге получается вот такой массив:
//1 4 7 2                              7 4 2 1
//5 9 2 3                              9 5 3 2
//8 4 2 4                              8 4 4 2

// matrix [0,0]  matrix [0,1]  matrix [0,2]  matrix [0,3] 
// matrix [1,0]  matrix [1,1]  matrix [1,2]  matrix [1,3] 
// matrix [2,0]  matrix [2,1]  matrix [2,2]  matrix [2,3] 
//
//1 Задать и напечатать двумерный массив рандомных чисел;
//2 сортировать и переместить элементы строки
//3 вывести на печать новый массив
//
void FillMatrix(int[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = matr[i, j] = rnd.Next(1, 20);
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


int[,] Selectionsort(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = j + 1; k < matr.GetLength(1); k++)
            {
                if (matr[i, j] < matr[i, k])
                {
                    int temporary = 0;
                    temporary = matr[i, j];
                    matr[i, j] = matr[i, k];
                    matr[i, k] = temporary;
                }
            }
        }


    }
    return matr;

}
int[,] matrix = new int[3, 4];
FillMatrix(matrix);
PrintMatrix(matrix);
matrix = Selectionsort(matrix);
Console.WriteLine();
PrintMatrix(matrix);
