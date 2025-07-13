//Debug need Find Root Cause!
//Formatter shortcut => Shift+Alt+F
using Tools;

namespace ConsoleAppForBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //CSharp中的數據類型
            int @int = 0;
            double @double = 4.0;
            float @float = 3.0F; //很少用
            char @char = 'a'; //單引號
            string @string = "string"; //雙引號
            bool @bool_true = true;
            bool @bool_false = false;

            /*
             數據結構
             - 通常都用下列兩種較多
             - 還有tuple等等
             */

            //像是JS中的Array => 查詢、存放一堆資料
            List<string> orderList = new List<string> { "List1", "List2", "List3", "List4" };

            //請注意! foreach 是唯讀操作，你不能在裡面「改動集合本身」，要修改內容只能使用for迴圈+索引
            /*
            foreach (var item in orderList)
            {
                Console.WriteLine($"List Foreach => {item}");
            }
             */

            //像是JS中的Map => 快速查 key 對應值（像狀態轉換、選單列表）
            Dictionary<int, string> memberList = new Dictionary<int, string>
            {
                {0, "Dictionary1" },
                {1, "Dictionary2" },
                {2, "Dictionary3" },
            };

            /*
            foreach (var Checker in MemberList)
            {
                Console.WriteLine($"Dictionary Foreach => {Checker.Key + 1}\n{Checker.Value}");
            }
             */

            //宣告MemberProfile<string> - MemberList[0] => "陳奕迅"]
            string memberProfile = memberList[0];

            //下列大概了解即可
            Queue<string> @oueue = new Queue<string>(); //先進先出（排隊系統）
            Stack<string> @stack = new Stack<string>(); //後進先出（像瀏覽器歷史紀錄）
            HashSet<string> @hashSet = new HashSet<string>(); //排除重複數值

            /*
            for (int i = 0; i < orderList.Count; i++)
            {
                Console.WriteLine($"第{i + 1}部電影: {orderList[i]}");
            }
             */

            /*
            double getSum = Calculator.Add(1.5, 2.0);
            getSum = Calculator.Sub(1.5, 2.0);
            getSum = Calculator.Mul(1.5, 2.0);
            getSum = Calculator.Div(1.5, 0);
            Console.WriteLine($"Div: {getSum}");
             */

            /*
            double numberSqrt = Math.Pow(2, 4);
            Console.WriteLine($"(2, 4) => {numberSqrt}");
             */

            Counter counter = new Counter();
            //counter.PrintSum(2, 3); //void method
            //counter.PrintXToOne(3);
            //counter.PrintOneAddToAHandred();
            //int result = counter.SumFromOneToX(3);
            //int newResult = counter.SumFromOneToXX(3);

            int hanoiCounter = counter.HanoiTower(3, 'A', 'B', 'C'); //2^3-1 => hanoiCounter = 7
            Console.WriteLine($"HanoiTower Run Time: {hanoiCounter}");
        }
    }

    //Method
    class Counter
    {
        //return => int & double & string...etc
        //no-return => void
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public string GetToday()
        {
            int today = DateTime.Now.Day;
            return today.ToString();
        }

        public void PrintSum(int a, int b)
        {
            int reuslt = a + b;
            Console.WriteLine(reuslt);
        }

        public void PrintXToOne(int x) //x = 10
        {
            //for (int i = x; i > 0; i--)
            //{
            //    //when i no equal 0 than break
            //    Console.WriteLine(i);
            //}

            if (x == 1)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(x);
                PrintXToOne(x - 1); //call self
            }
        }

        public void PrintOneAddToAHandred()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                //run 100 times
                sum += i;
            }
            Console.WriteLine(sum);
        }

        //遞歸
        public int GetGaussian(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            else
            {
                //堆疊結構 + 回傳鏈式相加
                //初始值 = 3
                //=> N(3) = result = 3 + #N(3 - 1)從這裡開始展開
                //=> #N(3 - 1 = x = 2) = result = 2 + N(2 - 1)
                //=> #N(2 - 1 = x = 1) = result = 1
                //=> return 1
                //接下來向上遞歸, 順序為: 
                int result = x + GetGaussian(x - 1);
                return result;
            }
        }

        //直接抓高斯的手來寫公式return求和
        public int GetGaussianX(int x)
        {
            //以防自己忘記:
            //參數:100 => (1 + 100) * 100 / 2;
            return (1 + x) * x / 2;
        }

        // HanoiTower 問題（河內塔）
        // 最少搬動次數 F(n) = 2^n - 1
        /*
            三個步驟（以 A → C 為例）：
            Step 1：將 n-1 個圓盤從 A 移到 B（透過 C）
            Step 2：將最大的第 n 個盤從 A 移到 C
            Step 3：將 n-1 個圓盤從 B 移到 C（透過 A）
        */
        private int moved = 0;

        public int HanoiTower(int n, char fromPeg, char viaPeg, char toPeg)
        {
            if (n == 1)
            {
                Console.WriteLine($"Move disk from {fromPeg} to {toPeg}");
                moved++;
            }
            else
            {
                // Step 1：將 n-1 個盤從 fromPeg 移到 viaPeg（使用 toPeg 作為中介）
                HanoiTower(n - 1, fromPeg, toPeg, viaPeg);

                // Step 2：將第 n 個盤從 fromPeg 移到 toPeg
                HanoiTower(1, fromPeg, viaPeg, toPeg);

                // Step 3：將 n-1 個盤從 viaPeg 移到 toPeg（使用 fromPeg 作為中介）
                HanoiTower(n - 1, viaPeg, fromPeg, toPeg);
            }

            return moved;
        }

    }
}

