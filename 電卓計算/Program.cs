using System.IO.Pipelines;
using System.Numerics;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.Write("数字");
        double firstinput = double.Parse(Console.ReadLine()!);
        double total = firstinput;

        //リストの宣言
        List<string> stglist = new List<string>();
        stglist.Add(firstinput.ToString());

       
        string Operator = "";

        while(Operator != "=")
        {

            Console.Write("演算子の選択(+, -, ×, ÷)");
            Operator = Console.ReadLine();
            stglist.Add(Operator);
            if(Operator == "=")
            {
                break;
            }

            Console.Write("数字");
            double input = double.Parse(Console.ReadLine()!);
            stglist.Add(input.ToString());

            //÷0のエラー
            if (Operator == "÷" && input == 0)
            {
                Console.WriteLine("error");
                break;
            }
            if(Operator == "=")
            {
                break;
            }  
            switch(Operator)
            {
                case "+":
                total += input;
                break; 
                case "-":
                total -= input;
                break;
                case "×":
                total *= input;
                break;
                case "÷":
                total /= input;
                break;
            }            
        }
        string result = "";
        for(var i = 0; i < stglist.Count; i++)
        {
            result += stglist[i] + " ";
        }
        Console.WriteLine(result + total);
    }
}

