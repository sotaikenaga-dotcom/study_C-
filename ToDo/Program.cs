using System.ComponentModel;

public class Program
{
    static List<string> Todo_list = new List<string>();

    public static void Adding()
    {
        Console.WriteLine("選択：1");
        Console.Write("タイトルを入力してください：");
        string new_event = Console.ReadLine()!;
        Todo_list.Add(new_event);
        Console.WriteLine("追加しました。ID:"+ Todo_list.IndexOf(new_event));
    }

    public static void DisplayList()
    {
        Console.WriteLine("選択：2");
        foreach(var todo in Todo_list)
        {
            Console.WriteLine("[{0}]：{1}", Todo_list.IndexOf(todo), todo);
        }
    }

    public static void ToggleEvent()
    {
        
    }
    public static void Main()
    {
        Console.WriteLine("=== ToDo メニュー===");
        Console.WriteLine("1：追加");
        Console.WriteLine("2：一覧表示");
        Console.WriteLine("3：完了切り替え");
        Console.WriteLine("4：削除");
        Console.WriteLine("5：終了");
        Console.Write("選択："); 
        int user_input = int.Parse(Console.ReadLine()!);

        while(user_input != 5)
        {
            switch (user_input)
            {
            case 1:
            Adding();
            Console.Write("選択：");
            user_input = int.Parse(Console.ReadLine()!);
            break;

            case 2:
            DisplayList();
            Console.Write("選択：");
            user_input = int.Parse(Console.ReadLine()!);
            break;

            case 5:
            Console.WriteLine("終了します。お疲れ様でした。");
            break;
            }
        
        }

    }
     

}