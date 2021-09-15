using System;
using System.IO;

class consoleapp3
{
    public static void Main()
    {
        string fileName = @"mytest.txt";
        try
        {
            Console.Write("\n\n A file created with name mytest.txt\n");
            using (FileStream fileStr = File.Create(fileName))
            {
                Console.WriteLine("A file created with name mytest.txt");
            }
        }
        catch (Exception MyExcep)
        {
            Console.WriteLine(MyExcep.ToString());
        }
    }
}
