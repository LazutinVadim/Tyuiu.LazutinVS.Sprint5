using Tyuiu.LazutinVS.Sprint5.Task0.V25.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        //int x = 3;
        //DataService ds = new DataService();
        //Console.WriteLine("Значение выражения: " + File.ReadAllText(ds.SaveToFileTextData(x)));

        int[,] array = { { 6, 9, 4 }, { 7, 2, 4 }, { 4, 8, 3 } };
        int rowSum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum += array[1, j];
        }

        File.WriteAllText("OutPutFileTask2.csv", rowSum.ToString());
        string fullPath = Path.GetFullPath("OutPutFileTask2.csv");
        Console.WriteLine(fullPath);
    }
}