//Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] firstMatrix = GenerateArray(3, 3);
System.Console.Write($"Первая матрица");
PrintArray(firstMatrix);

int[,] secondMatrix = GenerateArray(3, 3);
System.Console.Write($"Вторая матрица");
PrintArray(secondMatrix);

int[,] resultMatrix = FindMultiplyMatrix(firstMatrix, secondMatrix);
System.Console.Write($"Результат умножения");
PrintArray(resultMatrix);


int[,] FindMultiplyMatrix(int[,] a, int[,] b)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < a.GetLength(0); k++)
            {
                resultMatrix[i, j] += (a[i, k] * b[k, j]);
            }
        }
    }
    System.Console.WriteLine();

    return resultMatrix;
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

