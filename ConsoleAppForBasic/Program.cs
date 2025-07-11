//Debug need Find Root Cause!
using Tools;

namespace ConsoleAppForBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             數據結構
             - 通常都用下列兩種較多
             */

            //像是JS中的Array => 查詢、存放一堆資料
            List<string> OrderList = new List<string>{ "List1", "List2", "List3", "List4" };

            //請注意! foreach 是唯讀操作，你不能在裡面「改動集合本身」
            //要修改內容只能使用for迴圈+索引
            //看看foreach在List長怎樣
            foreach (var item in OrderList)
            {
                Console.WriteLine($"List Foreach => {item}");
            }

            //像是JS中的Map => 快速查 key 對應值（像狀態轉換、選單列表）
            Dictionary<int, string> MemberList = new Dictionary<int, string>
            {
                {0, "Dictionary1" },
                {1, "Dictionary2" },
                {2, "Dictionary3" },
            };
            
            //foreach in Dictionary
            foreach (var Checker in MemberList)
            {
                Console.WriteLine($"Dictionary Foreach => {Checker.Key + 1}\n{Checker.Value}");
            }

            //宣告MemberProfile<string> - MemberList[0 => "陳奕迅"]
            string MemberProfile = MemberList[0];

            //印出樣板文字
            //Console.WriteLine($"第一位成員: {MemberProfile}");

            //下列大概了解即可
            Queue<string> Queue = new Queue<string>(); //先進先出（排隊系統）
            Stack<string> Stack = new Stack<string>(); //後進先出（像瀏覽器歷史紀錄）
            HashSet<string> HashSet = new HashSet<string>(); //排除重複數值

            /*
            for (int i = 0; i < OrderList.Count; i++)
            {
                Console.WriteLine($"第{i + 1}部電影: {OrderList[i]}");
            }
             */

            double GetSum = Calculator.Add(1.5, 2.0);
            Console.WriteLine($"Add: {GetSum}");
            GetSum = Calculator.Sub(1.5, 2.0);
            Console.WriteLine($"Sub: {GetSum}");
            GetSum = Calculator.Mul(1.5, 2.0);
            Console.WriteLine($"Mul: {GetSum}");
            GetSum = Calculator.Div(1.5, 0);
            Console.WriteLine($"Div: {GetSum}");
        }
    }

    public class Counter : ICalculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public double Mul(double a, double b)
        {
            return a * b;
        }

        public double Div(double a, double b)
        {
            return a / b;
        }
    }
}

