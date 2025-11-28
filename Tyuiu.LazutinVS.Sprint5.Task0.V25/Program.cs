using Tyuiu.LazutinVS.Sprint5.Task0.V25.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        //int x = 3;
        //DataService ds = new DataService();
        //Console.WriteLine("Значение выражения: " + File.ReadAllText(ds.SaveToFileTextData(x)));

        string outputFile = "OutPutFileTask3.bin";
        double x1 = 0;
        double result1 = Math.Pow(x1,4) - 2 * Math.Pow(x1,3) + 3 * Math.Pow(x1,2) - 4 * x1 + 5;

        using (BinaryWriter writer = new BinaryWriter(File.Open(outputFile, FileMode.Create))) {
            writer.Write(result1);
        }

        using (BinaryReader reader = new BinaryReader(File.OpenRead(outputFile)))
        {
            double valueFromFile = reader.ReadDouble();
            Console.WriteLine($"Значение из файла: {valueFromFile}");  // ← будет 4
        }

        //string fullPath = Path.GetFullPath("OutPutFileTask3.bin");
        //Console.WriteLine(fullPath);
    }
}