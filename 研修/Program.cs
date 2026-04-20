public class Program
{
    static bool IsPositivenumber(int i)
    {
        return i > 0;
    }
    static void Main()
    {
       int i = -10;
       if(IsPositivenumber(i))
        {
            Console.WriteLine("iの値は正です");
        }
        else
        {
            Console.WriteLine("iの値は0または負です");
        }
    }
}