using Tyuiu.LazutinVS.Sprint5.Task3.V14.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 3;

        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("Файл" + res);
        Console.WriteLine("Создан");
        Console.ReadKey();
    }
}