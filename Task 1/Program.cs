/* Задача 1: Задайте двумерный массив.
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. */

int[,] array = GenerateArray(6, 6);
System.Console.WriteLine("Чистый массив");
PrintArray(array);

System.Console.WriteLine("Упорядоченый массив");
array = Check(array);
PrintArray (array);

int[,] Check (int[,] array) //повторная проверка массива по количеству знаков в строке
{     
     for (int i = 1; i < array.GetLength(1); i++)
     {
            findMax(array);
    }
    return array;
}


int[,] findMax(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (array[i, j] <= array[i, j + 1]) //пузырьковая сортировка
            {
                temp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;
            }
        }
    }
    return array;
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
