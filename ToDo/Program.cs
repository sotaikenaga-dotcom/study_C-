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

    //入力0：メニュー表示
    public static void Menu()
    {
        Console.WriteLine("=== ToDo メニュー===");
        Console.WriteLine("0：メニュー表示");
        Console.WriteLine("1：追加");
        Console.WriteLine("2：一覧表示");
        Console.WriteLine("3：完了切り替え");
        Console.WriteLine("4：削除");
        Console.WriteLine("5：終了");
    }

//入力1：リスト追加
    public static void Adding()
    {
        Console.Write("追加するタスクのタイトルを入力してください：");
        string title = Console.ReadLine()!;
        Todo_list.Add(new ToDoItem(title));
        Console.WriteLine("追加しました。ID:"+ (Todo_list.Count - 1));
    }

//入力2：一覧表示
    public static void DisplayList()
    {
        foreach(var todo in Todo_list)
        {
            int id = Todo_list.IndexOf(todo);
            if(Todo_list[id].IsCompleted)
            {
                Console.WriteLine("[{0}]：{1} - 完了", Todo_list.IndexOf(todo), todo.Title);
            }
            else
            {
                Console.WriteLine("[{0}]：{1} - 未完了", Todo_list.IndexOf(todo), todo.Title);
            }
            
        }
    }
    
//入力３：完了切替
    public static void CompleteTask()
    {
        int id = 0;
        int W = 0;
        Console.Write("完了/未完了を切り替えたいIDを入力：");
        while(W != 1)
        {
             if(!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("不正な入力です。");
                Console.Write("完了/未完了を切り替えたいIDを入力：");
            }
            else if(id < Todo_list.Count && id >= 0)
            {
                Todo_list[id].IsCompleted = !Todo_list[id].IsCompleted;
                if(Todo_list[id].IsCompleted == true)
                {
                    Console.WriteLine("ID：{0}のタスク[{1}]を完了に切り替えました", id, Todo_list[id].Title);
                }
                    else if(Todo_list[id].IsCompleted == false)
                {
                    Console.WriteLine("ID：{0}のタスク[{1}]を未完了に切り替えました", id, Todo_list[id].Title);
                }
                W = 1;
            
            }
            else
            {
                Console.WriteLine("存在しないIDです。");
                Console.Write("完了/未完了を切り替えたいIDを入力：");
            } 
        }
        Console.WriteLine("現在のIDは以下の通りです。");
        DisplayList();
    
    }

//入力４：削除
    public static void DeleteTask()
    {
        int deleteID = 0;
        int W = 0;
        Console.WriteLine("削除したいIDを入力：");
        while(W != 1)
        {
            if(!int.TryParse(Console.ReadLine(), out deleteID))
            {
                Console.WriteLine("不正な入力です。");
                Console.Write("削除したいIDを入力：");
            }
            else if(deleteID < Todo_list.Count && deleteID >= 0)
            {
                string delete_task = Todo_list[deleteID].Title;
                Todo_list.RemoveAt(deleteID);
                Console.WriteLine("ID：{0}のタスク[{1}]を削除しました。", deleteID, delete_task);
                W = 1;
            }
            else
            {
                Console.WriteLine("存在しないIDです。");
                Console.Write("削除したいIDを入力：");
            }
        }
        Console.WriteLine("現在のIDは以下の通りです。");
        DisplayList();
    }

    public static void Main()
    {
        int user_input = 0;
        Console.WriteLine("=== ToDo メニュー===");
        Console.WriteLine("0：メニュー表示");
        Console.WriteLine("1：追加");
        Console.WriteLine("2：一覧表示");
        Console.WriteLine("3：完了切り替え");
        Console.WriteLine("4：削除");
        Console.WriteLine("5：終了");

        Console.Write("最初に追加するタスクのタイトルを入力してください：");
        string title = Console.ReadLine()!;
        Todo_list.Add(new ToDoItem(title));
        Console.WriteLine("追加しました。ID:0");

        Console.Write("選択："); 
       
        while(user_input != 5)
        {
            if (!int.TryParse(Console.ReadLine(), out user_input))
            {
                Console.WriteLine("不正な入力です");
            }

            else if(user_input >= 0 && user_input <= 5)
            {
                switch (user_input)
                {
                    case 0:
                    Menu();
                    break;

                    case 1:
                    Adding();
                    break;

                    case 2:
                    DisplayList();
                    break;

                    case 3:
                    CompleteTask();
                    break;

                    case 4:
                    DeleteTask();
                    break;
                }
            }
            else
            {
                Console.WriteLine("0~5で入力してください");
            }

            Console.Write("選択：");    
        }
        Console.WriteLine("終了します。お疲れ様でした。");
    }
}