using Tyuiu.LazutinVS.Sprint5.Task0.V25.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        //int x = 3;
        //DataService ds = new DataService();
        //Console.WriteLine("Значение выражения: " + File.ReadAllText(ds.SaveToFileTextData(x)));

        string content = File.ReadAllText(@"C:\DataSprint5\InPutDataFileTask4V0.txt");
        content = content.Replace("h", "#");
        Console.WriteLine(String.Join("\n", content));

        //using (BinaryReader reader = new BinaryReader(File.OpenRead(outputFile)))
        //{
        //    double valueFromFile = reader.ReadDouble();
        //    Console.WriteLine($"Значение из файла: {valueFromFile}");  // ← будет 4
        //}

        //string fullPath = Path.GetFullPath("OutPutFileTask3.bin");
        //Console.WriteLine(fullPath);
    }
}