public class Program
{
    public static void Main()
    {
        Console.Write("1つ目の数字を入力してね");
        var num_a = int.Parse(Console.ReadLine()!);
        Console.Write("2つ目の数字を入力してね");
        var num_b = int.Parse(Console.ReadLine()!);
        if(num_a == 1 && num_b == 1)
        {
            Console.WriteLine("どちらの数も1です");
        }
        else if(num_a == 1 || num_b ==1)
        {
            Console.WriteLine("どちらかの数は１です");
        }
        else if(!(num_a == num_b))
        {
            Console.WriteLine("二つの数は一致しません");
        }
        else
        {
            Console.WriteLine("1じゃないところで一致してるね");
        }
    }
}