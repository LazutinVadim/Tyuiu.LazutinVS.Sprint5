using Tyuiu.LazutinVS.Sprint5.Task1.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        var result = ds.SaveToFileTextData(-5, 5);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}