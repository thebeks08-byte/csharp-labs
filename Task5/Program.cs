using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int nomer = 3;
        int n = 5;
        int[,] matrix = new int[n, n];
        Random rnd = new Random(nomer);

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                matrix[i, j] = rnd.Next(-10, 11);

        Console.WriteLine("Матрица:");
        PrintMatrix(matrix);

        int rowNumber = FindMaxSumRow(matrix, out int maxSum);
        Console.WriteLine($"Қосындысы ең үлкeн жол: №{rowNumber}, қосындысы = {maxSum}");
    }

    static void PrintMatrix(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
                Console.Write($"{m[i, j],5}");
            Console.WriteLine();
        }
    }

    static int RowSum(int[,] m, int row)
    {
        int sum = 0;
        for (int j = 0; j < m.GetLength(1); j++)
            sum += m[row, j];
        return sum;
    }

    static int FindMaxSumRow(int[,] m, out int maxSum)
    {
        maxSum = RowSum(m, 0); // бастапқы мән: бірінші жолдың қосындысы
        int bestRow = 0;
        for (int i = 1; i < m.GetLength(0); i++)
        {
            int sum = RowSum(m, i);
            if (sum > maxSum) // қатаң ">" болғандықтан, тең болса бірінші жол қалады
            {
                maxSum = sum;
                bestRow = i;
            }
        }
        return bestRow + 1; // 1-ден бастап нөмірлеу
    }
}
