public class Program
{
    public static void Main()
    {
        Console.Write("第1項");
        double a = double.Parse(Console.ReadLine()!);
        Console.Write("演算子の選択(+,-,×, ÷)");
        string Operator = Console.ReadLine()!;
        Console.Write("第2項");
        double b = double.Parse(Console.ReadLine()!);

        if(Operator == "+")
        {
            Console.WriteLine("{0} + {1} = {2}",a, b, a + b);
        }
        else if(Operator == "-")
        {
            Console.WriteLine("{0} - {1} = {2}",a, b, a - b);
        }
        else if(Operator == "×")
        {
            Console.WriteLine("{0} × {1} = {2}",a, b, a * b);
        }
        else if(Operator == "÷")
        {
            if(b == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("{0} ÷ {1} = {2}",a, b, a / b);
            }

        }
    }
}
