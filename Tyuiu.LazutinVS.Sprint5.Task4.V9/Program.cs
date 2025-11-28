using Tyuiu.LazutinVS.Sprint5.Task4.V9.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string path = @"C:\DataSprint5\InPutDataFileTask4V9.txt";
        double res = ds.LoadFromDataFile(path);

        Console.WriteLine(res);
    }
}