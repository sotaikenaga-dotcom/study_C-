public class Program
{
    public static void Main()
    {
        var a = new List<string>();
        a.Add("Apple");
        a.Add("Orange");
        a.Add("Banana");
        a.Add("grape");

        foreach(string s in a)
        {
            Console.WriteLine(s);
        }
    }
}
