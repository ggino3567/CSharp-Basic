namespace ConsoleAppForBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             數據結構
             - 通常都用下列兩種較多
             */

            // 像是JS中的Array => 查詢、存放一堆資料
            List<string> OrderList = new List<string>{ "哈利波特", "魔戒", "沉默之丘", "惡靈古堡" };

            // 請注意! foreach 是唯讀操作，你不能在裡面「改動集合本身」
            // 要修改內容只能使用for迴圈+索引
            // 看看foreach在List長怎樣
            foreach (var item in OrderList)
            {
                Console.WriteLine($"List Foreach => {item}");
            }

            // 像是JS中的Map => 快速查 key 對應值（像狀態轉換、選單列表）
            Dictionary<int, string> MemberList = new Dictionary<int, string>
            {
                {0, "陳奕迅" },
                {1, "周杰倫" },
                {2, "范逸臣" },
            };
            
            // foreach in Dictionary
            foreach (var Checker in MemberList)
            {
                Console.WriteLine($"Dictionary Foreach => {Checker.Key + 1}\n{Checker.Value}");
            }

            // 宣告MemberProfile<string> - MemberList[0 => "陳奕迅"]
            string MemberProfile = MemberList[0];

            // 印出樣板文字
            //Console.WriteLine($"第一位成員: {MemberProfile}");

            // 下列大概了解即可
            Queue<string> Queue = new Queue<string>(); // 先進先出（排隊系統）
            Stack<string> Stack = new Stack<string>(); // 後進先出（像瀏覽器歷史紀錄）
            HashSet<string> HashSet = new HashSet<string>(); // 排除重複數值

            /*
            for (int i = 0; i < OrderList.Count; i++)
            {
                Console.WriteLine($"第{i + 1}部電影: {OrderList[i]}");
            }
             */
        }
    }
}
