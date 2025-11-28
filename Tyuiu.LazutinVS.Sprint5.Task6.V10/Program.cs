using Tyuiu.LazutinVS.Sprint5.Task6.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string path = @"C:\DataSprint5\InPutDataFileTask6V10.txt";
        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);

    }
}