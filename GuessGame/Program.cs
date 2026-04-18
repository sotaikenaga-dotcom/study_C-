using System.Globalization;

public class Program
{
    public static void Main()
    {
        Random rnd = new Random();
        int num_ans = rnd.Next(1, 100);
        // 答え作成
        Console.Write("1~100から数を予想してね");
        var num = int.Parse(Console.ReadLine()!);
        var count = 0
        while(num_ans != num)
        {
            if(num_ans > num)
            {
                Console.WriteLine("もっと大きいよ");
                Console.Write("もう一回入力してみて");
                num = int.Parse(Console.ReadLine()!);
            }
            else
            {
                Console.WriteLine("もっと小さいよ");
                Console.Write("もう一回入力してみて");
                num = int.Parse(Console.ReadLine()!);
            }
        }
        Console.WriteLine("正解！");
    }
    
}