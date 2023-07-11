//Задача 60. ...
//Сформируйте трёхмерный массив из двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
Random rand = new Random();

int[,,] Fill3dArray(int m, int n, int k)
{
    int[,,] TempArray = new int[m, n, k];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            for (int h = 0; h < k; h++)
                TempArray[i, j, h] = rand.Next(-100, 100);
    return TempArray;
}
void Print3dArrayWithIndex(int[,,] TempArray)
{
    for (int i = 0; i < TempArray.GetLength(0); i++)
        for (int j = 0; j < TempArray.GetLength(1); j++)
        {
            for (int h = 0; h < TempArray.GetLength(2); h++)
                Console.Write($"{TempArray[i, j, h]}({j},{h},{i}) ");
            Console.WriteLine("");
        }
}

int[,,] array = Fill3dArray(2, 2, 2);
Print3dArrayWithIndex(array);

