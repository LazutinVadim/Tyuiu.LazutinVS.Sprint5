using Tyuiu.LazutinVS.Sprint5.Task0.V25.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        //int x = 3;
        //DataService ds = new DataService();
        //Console.WriteLine("Значение выражения: " + File.ReadAllText(ds.SaveToFileTextData(x)));

        double start = -11, end = -9, step = 1;
        string outputFile = "OutPutFileTask1.txt";
        for (double x = start; x <= end; x += step)
        {
            double result = 2 * x - 3 * Math.Pow(x, 2) - 24;
            if (double.IsInfinity(result) || double.IsNaN(result)) 
            {
                result = 0;
            }
            result = Math.Round(result,2);
            File.AppendAllText(outputFile, $"{result}\n");
            Console.WriteLine($"{result}");
        }

    }
}