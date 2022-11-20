// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
//
// 1 4 7 2
//5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
//с наименьшей суммой элементов: 1 строка

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
int[,] matrix = new int[3, 4];
FillMatrix(matrix);
PrintMatrix(matrix);
int min = int.MaxValue;
int index = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int summ = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        summ = summ + matrix[i, j];
    }
    //Console.WriteLine("сумма элементов строки " + (i + 1));
    //Console.WriteLine(summ);
    if (summ < min)
    {
        min = summ;
        index++;
    }
}
Console.Write("Минимальная сумма элементов в строке ");
Console.WriteLine(index);





