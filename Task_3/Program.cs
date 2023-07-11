//Методы рабочие
Random rand = new Random();

void PrintMatrix(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
            Console.Write(table[i, j] + "\t");
        Console.WriteLine();
    }
}
int[,] FillMatrix(int row = 3, int col = 3, int minNum = -10, int maxNum = 10)
{
    int[,] tempMatrix = new int[row, col];
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
            tempMatrix[i, j] = rand.Next(minNum, maxNum + 1);
    return tempMatrix;
}
//Задача 58: Задайте две матрицы.
//Напишите программу, которая будет
//находить произведение двух матриц.
int[,] MatrixMultiplication(int[,] arr1, int[,] arr2)
{
    int[,] MultiplicatedMatrix = new int[2, 2];
    MultiplicatedMatrix[0, 0] = (arr1[0, 0] * arr2[0, 0]) + (arr1[0, 1] * arr2[1, 0]);
    MultiplicatedMatrix[0, 1] = (arr1[0, 0] * arr2[0, 1]) + (arr1[0, 1] * arr2[1, 1]);
    MultiplicatedMatrix[1, 0] = (arr1[1, 0] * arr2[0, 0]) + (arr1[1, 1] * arr2[1, 0]);
    MultiplicatedMatrix[1, 1] = (arr1[1, 0] * arr2[0, 1]) + (arr1[1, 1] * arr2[1, 1]);

    return MultiplicatedMatrix;
}

int[,] array = FillMatrix(2, 2);
PrintMatrix(array);
int[,] array2 = FillMatrix(2, 2);
PrintMatrix(array2);
Console.WriteLine("Результат:");
PrintMatrix(MatrixMultiplication(array, array2));
