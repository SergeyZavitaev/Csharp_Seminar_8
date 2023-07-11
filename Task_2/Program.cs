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
//Задача 56: Задайте прямоугольный
//двумерный массив. Напишите программу,
//которая будет находить строку с
//наименьшей суммой элементов.
int FindMinStringMatrix(int[,] TempArray)
{
    int StringWithMinSum = 0;
    int OldMinSum = 0;
    for (int stringChanger = 0; stringChanger < TempArray.GetLength(0); stringChanger++)
    {
        int MinSum = 0;
        for (int ColumnsChanger = TempArray.GetLength(1) - 1; ColumnsChanger > -1; 
        ColumnsChanger = ColumnsChanger - 1)
            MinSum = MinSum + (TempArray[stringChanger, ColumnsChanger]);
        if (MinSum < OldMinSum)
            StringWithMinSum = stringChanger;
        OldMinSum = MinSum;
    }
    return (StringWithMinSum + 1);
}

int[,] array = FillMatrix();
PrintMatrix(array);
Console.WriteLine($"{FindMinStringMatrix(array)} строка");