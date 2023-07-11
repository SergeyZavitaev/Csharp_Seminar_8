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
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] SpiralMatrix4x4()
{
    int direction = 0; //0-right, 1-down, 2-left, 3-up, 4=0
    int x = 0; //x - [x,0] строки
    int y = -1; //y - [0,y] столбцы
    int[,] TempArray = new int[4, 4];

    for (int n = 1; n < TempArray.Length * 2; n++)
    {
        if (direction == 0)
        {
            if (y < (TempArray.GetLength(1))) //проверка можно ли идти в ту сторону
            {
                try
                {
                    if (TempArray[x, y + 1] == 0)
                    {
                        TempArray[x, y + 1] = n;
                        y++;
                    }
                    else
                        direction = 1;
                }
                catch
                {
                    direction = 1;
                }
            }
        }
        if (direction == 1)
        {
            try
            {
                if (TempArray[x + 1, y] == 0)
                {
                    TempArray[x + 1, y] = n;
                    x++;
                }
                else
                    direction = 2;
            }
            catch
            {
                direction = 2;
            }
        }
        if (direction == 2)
        {
            try
            {
                if (TempArray[x, y - 1] == 0)
                {
                    TempArray[x, y - 1] = n;
                    y = y - 1;
                }
                else
                    direction = 3;
            }
            catch
            {
                direction = 3;
            }
        }
        if (direction == 3)
        {
            try
            {
                if (TempArray[x - 1, y] == 0)
                {
                    TempArray[x - 1, y] = n;
                    x = x - 1;
                }
                else
                    direction = 4;
            }
            catch
            {
                direction = 4;
            }
        }
        if (direction == 4)
        {
            if (y < (TempArray.GetLength(1))) //проверка можно ли идти в ту сторону
            {
                try
                {
                    if (TempArray[x, y + 1] == 0)
                    {
                        TempArray[x, y + 1] = n;
                        y++;
                    }
                    else
                    {
                        direction = 1; y = y - 1; n = n - 1; x++;
                    }
                }
                catch
                {
                    direction = 1;
                }
            }
        }
    }

    return TempArray;
}

int[,] array = SpiralMatrix4x4();
PrintMatrix(array);
