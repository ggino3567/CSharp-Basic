//Debug need Find Root Cause!
//Formatter shortcut => Shift+Alt+F
using Tools;

namespace ConsoleAppForBasic
{
    //public(共用成員) private(私有成員)
    //internal class Name?
    class Program
    {
        public static void Main(string[] args)
        {
            //C# 數據類型
            /*
            int @int = 0;
            double @double = 4.0;
            char @char = 'a'; //單引號
            string @string = "string"; //雙引號
            bool @bool_true = true;
            bool @bool_false = false;
            float @float = 3.0F; //很少用
            byte @byte = 1;
            decimal @decimal = 10; //十進位?
            */

            /*
             數據結構
             - 通常都用下列兩種較多
             - 還有tuple等等
             */

            //像是JS中的Array => 查詢、存放一堆資料
            List<string> orderList = new List<string> { "List1", "List2", "List3", "List4" };
            //像是JS中的Map => 快速查 key 對應值（像狀態轉換、選單列表）
            Dictionary<int, string> memberList = new Dictionary<int, string>
            {
                {0, "Dictionary1" },
                {1, "Dictionary2" },
                {2, "Dictionary3" },
            };

            //請注意! foreach 是唯讀操作，你不能在裡面「改動集合本身」，要修改內容只能使用for迴圈+索引
            /*
            foreach (var item in orderList)
            {
                Console.WriteLine($"List Foreach => {item}");
            }
             */

            //宣告MemberProfile<string> - MemberList[0] => "陳奕迅"]
            string memberProfile = memberList[0];

            //下列大概了解即可
            Queue<string> @oueue = new Queue<string>(); //先進先出（排隊系統）
            Stack<string> @stack = new Stack<string>(); //後進先出（像瀏覽器歷史紀錄）
            HashSet<string> @hashSet = new HashSet<string>(); //排除重複數值

            //流程控制
            int myAge = 17;
            if (myAge <= 18 && myAge >= 30)
            {
                Console.WriteLine("你還算年輕?");
            }
            else if (myAge > 30)
            {
                Console.WriteLine("老很多ㄌ");
            }
            else
            {
                Console.WriteLine("乳臭未乾的屁孩");
            }
            //巢狀if-else
            //其實就多層嵌套判斷
            //可讀性下降
            int a, b, c, max;
            a = 10; b = 20; c = 30;
            if (a > b)
            {
                if (a > c)
                {
                    max = a;
                }
                else
                {
                    max = c;
                }
            }
            else
            {
                if (b > c)
                {
                    max = b;
                }
                else
                {
                    max = c;
                }
            }
            Console.WriteLine($"Max = {max}");

            //switchCase 與JS一樣
            string myName = "蔡英文";
            switch (myName)
            {
                case "Bean":
                    Console.WriteLine(false);
                    break;
                case "Gino":
                    Console.WriteLine(true);
                    break;
                default:
                    Console.WriteLine("NOT INJECT VALUE");
                    break;
            }

            //三元運算子 跟JS一樣
            string getResult = a > b ? "a>b" : "b>a";
            Console.WriteLine(getResult);

            /*
            for (int i = 0; i < orderList.Count; i++)
            {
                Console.WriteLine($"第{i + 1}部電影: {orderList[i]}");
            }
             */

            int whileParameter = 10;
            Console.WriteLine($"初始狀態: {whileParameter}");
            while (true)
            {
                if (whileParameter < 15)
                {
                    whileParameter++;
                }
                else
                {
                    Console.WriteLine($"whileParameter已經達到15!");
                    break;
                }
            }
            Console.WriteLine($"初始狀態: {whileParameter}");

            //後測迴圈 do-while
            //若第一次進入迴圈時不需要檢查是否滿足條件 直接進入迴圈將代碼先執行一遍 第二次才需要檢查是否滿足條件
            /*
            string optionResult = "";
            int score, sum, count;
            score = 0; sum = 0; count = 0;
            Console.WriteLine("=== 程式設計成績試算 ===");
            do //無論如何都將先執行一次
            {
                count += 1;
                Console.Write($"{count}. 請輸入第{count}位同學的成績 : ");
                score = int.Parse(Console.ReadLine());
                sum += score;
                Console.WriteLine("=== 是否繼續? (Y/N) : ");
                optionResult = Console.ReadLine();
            }
            while (optionResult == "Y" || optionResult == "y"); //第一次執行後若輸入Y/y的條件達成則繼續執行上述流程否則跳出迴圈

            Console.WriteLine($"共輸入了{count}位學生的成績, 學生成績總和為: {sum / count}");
             */

            //測試break和continue
            //Requirement: 輸入下列條件式的臨界值(限正整數)，由電腦求終值，再計算出總和
            int upperValue;
            int count = 0;
            int sum = 0;
            Console.WriteLine("== 求 1+2+3...+N <= Upper(臨界值)");
            Console.Write("請輸入 Upper(臨界值) : ");
            upperValue = int.Parse(Console.ReadLine());
            while (true)
            {
                //...break or continue
            }

            /*
            double getSum = Calculator.Add(1.5, 2.0);
            Console.WriteLine($"{getSum}");
             */

            /*
            double numberSqrt = Math.Pow(2, 4);
            Console.WriteLine($"(2, 4) => {numberSqrt}");
             */

            Counter counter = new Counter();
            //counter.PrintSum(2, 3); //void method
            //int result = counter.SumFromOneToX(3);
            /* 河內塔
            int hanoiCounter = counter.HanoiTower(3, 'A', 'B', 'C'); //2^3-1 => hanoiCounter = 7
            Console.WriteLine($"河內塔走了幾次: {hanoiCounter}");
            */

            //Console.WriteLine($"{(int)Weekdays.Monday}");
            Product cpu;
            cpu.number = "pc01";
            cpu.name = "i3-1215u";
            //Console.Write("請輸入cpu價格: ");
            cpu.price = 2500;
            //Console.WriteLine($"產品編號:{cpu.number}\n產品名稱:{cpu.name}\n產品單價:{cpu.price}");
        }
    }

    //列舉 enum 預設public
    enum Weekdays : int
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,
    }

    //結構 struct 預設private
    //需先定義再宣告 很像小型class類別但只用來儲存不同類型的資料
    struct Product
    {
        public string number, name;
        public int price;
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

        //遞迴
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
            // 結束條件為當n = 1時跳出
            // 過程如下
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

