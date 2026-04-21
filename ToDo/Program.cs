using System.ComponentModel;
using System.Reflection;

public class ToDoItem
    {
        public string Title{get; set;}
        public bool IsCompleted{get; set;}
        public ToDoItem(string title)
    {
        Title = title;
        IsCompleted = false;
    }
    }
public class Program
{
    static List<ToDoItem> Todo_list = new List<ToDoItem>();

//入力1：リスト追加
    public static void Adding()
    {
        Console.WriteLine("選択：1");
        Console.Write("タイトルを入力してください：");
        string title = Console.ReadLine()!;
        Todo_list.Add(new ToDoItem(title));
        Console.WriteLine("追加しました。ID:"+ (Todo_list.Count - 1));
    }

//入力2：一覧表示
    public static void DisplayList()
    {
        Console.WriteLine("選択：2");
        foreach(var todo in Todo_list)
        {
            int id = Todo_list.IndexOf(todo);
            if(Todo_list[id].IsCompleted == true)
            {
                Console.WriteLine("[{0}]：{1} - 完了", Todo_list.IndexOf(todo), todo.Title);
            }
            else if(Todo_list[id].IsCompleted == false)
            {
                Console.WriteLine("[{0}]：{1} - 未完了", Todo_list.IndexOf(todo), todo.Title);
            }
            
        }
    }
    
//入力３：完了切替
    public static void CompleteEvent()
    {
        Console.Write("完了/未完了を切り替えたいIDを入力：");
        int id = int.Parse(Console.ReadLine()!);
        Todo_list[id].IsCompleted = !Todo_list[id].IsCompleted;
        if(Todo_list[id].IsCompleted == true)
        {
            Console.WriteLine("ID{0}のタスク[{1}]を完了に切り替えました", id, Todo_list[id].Title);
        }
        else if(Todo_list[id].IsCompleted == false)
        {
            Console.WriteLine("ID{0}のタスク[{1}]を未完了に切り替えました", id, Todo_list[id].Title);
        }
    }

//入力４：削除
    public static void DeleteEvent()
    {
        Console.WriteLine("削除したいIDを入力：");
        int deleteID = int.Parse(Console.ReadLine()!);
        string delete_task = Todo_list[deleteID].Title;
        Todo_list.RemoveAt(deleteID);
        Console.WriteLine("ID：{0}のタスク[{1}]を削除しました", deleteID, delete_task);
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

            case 3:
            CompleteEvent();
            Console.Write("選択：");
            user_input = int.Parse(Console.ReadLine()!);
            break;

            case 4:
            DeleteEvent();
            Console.WriteLine("選択：");
            user_input = int.Parse(Console.ReadLine()!);
            break;
            }        
        }
        Console.WriteLine("終了します。お疲れ様でした。");
    }
}