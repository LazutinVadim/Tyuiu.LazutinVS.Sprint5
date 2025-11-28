using Tyuiu.LazutinVS.Sprint5.Task7.V30.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string path = Path.Combine(Path.GetTempPath(), "DataSprint5", "InPutDataFileTask7V30.txt");
        Console.WriteLine($"Путь: {path}");
        string res = ds.LoadDataAndSave(path);
        Console.WriteLine("Ответ:" + res);

    }
}