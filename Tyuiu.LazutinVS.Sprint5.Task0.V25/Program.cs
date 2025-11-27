using Tyuiu.LazutinVS.Sprint5.Task0.V25.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        int x = 3;
        DataService ds = new DataService();

        Console.WriteLine("Значение выражения: " + File.ReadAllText(ds.SaveToFileTextData(x)));
    }
}