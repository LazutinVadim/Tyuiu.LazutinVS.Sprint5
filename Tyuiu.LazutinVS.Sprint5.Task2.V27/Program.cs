using Tyuiu.LazutinVS.Sprint5.Task2.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matrix = new int[3, 3]
            {{1, 4, 3 },
             {1, 1, 4 },
             {4, 3, 8 },
                        };
        int rows = matrix.GetUpperBound(0) + 1;
        int columns = matrix.Length / rows;

        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(matrix);
        Console.WriteLine("Файл " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}