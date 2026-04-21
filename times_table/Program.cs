using System.ComponentModel;

public class Program
{
    public static string TimeTable(int i)
    {
        string stgresult = "";
        int intresult = 0;
        for(int j = 1; j < 10; j++)
        {
            intresult = j * i;
            stgresult += $"{intresult, 3}";
        }
        return i.ToString() + " |" + stgresult;
    }

    public static void Main()
    {
        Console.WriteLine("  |  1  2  3  4  5  6  7  8  9  ");
        for(int i = 1; i < 10; i++)
        {
             Console.WriteLine(TimeTable(i));
        }
       
    }
}
