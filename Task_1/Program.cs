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
//Задача 54: Задайте двумерный массив.
//Напишите программу, которая упорядочит
//по убыванию элементы каждой строки
//двумерного массива.
int[,] SortMatrix(int[,] TempArray)
{
    for (int stringChanger = 0; stringChanger < TempArray.GetLength(0); stringChanger++)
    {
        List<int> NumbersList = new List<int>();
        for (int ColumnsChanger = TempArray.GetLength(1) - 1; ColumnsChanger > -1;
        ColumnsChanger = ColumnsChanger - 1)
            NumbersList.Add(TempArray[stringChanger, ColumnsChanger]);
        int[] massive = NumbersList.ToArray();
        bool sort = false; //переменная, которая сообщает нужно ли ещё сортировать или готово
        while (sort == false) //цикл пока не отсортирует
        {
            for (int i = 1; i < massive.Length; i++) //цикл на весь массив
                if (massive[i] > massive[i - 1]) //замена значений если одно больше другого от большего к меньшему
                {
                    int newValue = massive[i - 1];
                    massive[i - 1] = massive[i];
                    massive[i] = newValue;
                }
            bool error = false; //переменная на проверки есть ли ошибки или готово
            for (int i = 1; i < massive.Length; i++) //цикл на массив
                if (massive[i] > massive[i - 1]) //проверка значений
                    error = true; // если ли есть проблемы, то ставим что ошибка есть
            if (error == false) //если ошибок не найдено значит отсортировано
                sort = true;
        }
        for (int ColumnsChanger = TempArray.GetLength(1) - 1;
            ColumnsChanger > -1; ColumnsChanger = ColumnsChanger - 1) //занесение результата в массив
            TempArray[stringChanger, ColumnsChanger] = massive[ColumnsChanger];
    }
    return TempArray;
}

int[,] array = FillMatrix();
PrintMatrix(array);
PrintMatrix(SortMatrix(array));