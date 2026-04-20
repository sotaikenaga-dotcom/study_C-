public class Program
{
    static void Countdown()
    {
        Console.WriteLine("カウントダウンします");
        for(int i = 5; i >= 0; i--)
        {
            Console.WriteLine(i);
        } 
    }
    public static void Main()
    {
        Countdown();
        Countdown();
    }
}
