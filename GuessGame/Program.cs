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
        // 数予想
        var count = 0;
        while(num_ans != num)
        {
            if(num_ans > num)
            {
                Console.WriteLine("もっと大きいよ");
                Console.Write("もう一回入力してみて");
                num = int.Parse(Console.ReadLine()!);
                count += 1;
            }
            else
            {
                Console.WriteLine("もっと小さいよ");
                Console.Write("もう一回入力してみて");
                num = int.Parse(Console.ReadLine()!);
                count += 1;
            }
        }
        var score = 10 - count;
        Console.WriteLine("正解！スコアは{0}/10点です！", score);
    }
    
}