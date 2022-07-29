/* Задача 2: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов. */

int[,] array = GenerateArray(3, 2);
PrintArray(array);

int[] arrayFindMin = FindSum(array);
int result = FindMinumum(arrayFindMin);

System.Console.WriteLine($"Строка с наименьшей суммой {result}");

int FindMinumum(int[] array)
{
    int row = 0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++) // находим минимальное число
    {
       
            if (min > array[i])
            {
                min = array[i];
            }
    }

    for (int i = 0; i < array.Length; i++) // находим индекс минимального числа
    {
        if (min == array[i])
            row = i;
    }
    return row;
}

int[] FindSum(int[,] array) // поиск суммы сохраненного в виде массива
{
    int[] compareArray = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }

        compareArray[i] = sum;
    }

    return compareArray;
}

int[,] GenerateArray(int rows, int columns)
{
    int[,] answer = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answer[i, j] = rnd.Next(0, 9 + 1);
        }
    }
    return answer;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}
