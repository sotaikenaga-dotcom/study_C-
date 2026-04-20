public class Program
{
    static void methodA()
    {
       Console.WriteLine("methodAが呼び出されました");
       methodB();
    }
    static void methodB()
    {
        Console.WriteLine("methodBが呼び出されました");
    }
    public static void Main()
    {
        methodA();
    }
}
