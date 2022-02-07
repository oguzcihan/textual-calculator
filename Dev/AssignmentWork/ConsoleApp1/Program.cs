using System.Text.RegularExpressions;

namespace Program
{
    //metinden sayıya çevirme kodu
    public class Program
    {
        static void Main(string[] args)
        {

            //try
            //{

            //    string strNumber = Console.ReadLine();
            //    string rtnNumber = ConvertToNumbers(strNumber).ToString();

            //    Console.WriteLine("Number is {0}", rtnNumber);
            //    Console.ReadKey();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            while (true)
            {
                try
                {


                    string rtnNumber = ConvertToNumbersTR(Console.ReadLine()).ToString();

                    Console.WriteLine("{0}", rtnNumber);
                    //Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            



        }
        private static Dictionary<string, int> numberTableTR = new Dictionary<string, int>{
            {"sıfır",0},{"bir",1},{"iki",2},{"üç",3},{"dört",4},{"beş",5},{"altı",6},
            {"yedi",7},{"sekiz",8},{"dokuz",9},{"on",10},{"on bir",11},{"on iki",12},
            {"on üç",13},{"on dört",14},{"on beş",15},{"on altı",16},{"on yedi",17},
            {"on sekiz",18},{"on dokuz",19},{"yirmi",20},{"otuz",30},{"kırk",40},
            {"elli",50},{"altmış",60},{"yetmiş",70},{"seksen",80},{"doksan",90},
            {"yüz",100},{"bin",1000},{"on bin",100000},{"milyon",1000000},
            {"milyar",1000000000}

        };
        private static long ConvertToNumbersTR(string numberString)
        {
            var numbers = Regex.Matches(numberString, @"\w+").Cast<Match>()
                .Select(m => m.Value.ToLowerInvariant())
                .Where(v => numberTableTR.ContainsKey(v))
                .Select(v => numberTableTR[v]);
            long acc = 0, total = 0L;
            foreach (var n in numbers)
            {
                if (n >= 1000)
                {
                    if (n == 1000 && acc == 0)
                    {
                        acc = 1;
                    }

                    total += acc * n;
                    acc = 0;
                }
                else if (n >= 100)
                {
                    if (n == 100 && acc == 0)
                    {
                        acc = 1;
                    }
                    acc *= n;
                }
               
                else acc += n;
            }
            return (total + acc) * (numberString.StartsWith("minus",
                StringComparison.InvariantCultureIgnoreCase) ? -1 : 1);
        }

        private static Dictionary<string, int> numberTable = new Dictionary<string, int>{
        {"zero",0},{"one",1},{"two",2},{"three",3},{"four",4},{"five",5},{"six",6},
        {"seven",7},{"eight",8},{"nine",9},{"ten",10},{"eleven",11},{"twelve",12},
        {"thirteen",13},{"fourteen",14},{"fifteen",15},{"sixteen",16},{"seventeen",17},
        {"eighteen",18},{"nineteen",19},{"twenty",20},{"thirty",30},{"forty",40},
        {"fifty",50},{"sixty",60},{"seventy",70},{"eighty",80},{"ninety",90},
        {"hundred",100},{"thousand",1000},{"lakh",100000},{"million",1000000},
        {"billion",1000000000}
        };

        private static int ConvertToNumbers(string numberString)
        {
            var numbers = Regex.Matches(numberString, @"\w+").Cast<Match>()
                    .Select(m => m.Value.ToLowerInvariant())
                    .Where(v => numberTable.ContainsKey(v))
                    .Select(v => numberTable[v]);
            int acc = 0, total = 0;
            foreach (var n in numbers)
            {
                if (n >= 1000)
                {
                    total += acc * n;
                    acc = 0;
                }
                else if (n >= 100)
                {
                    acc *= n;
                }
                else acc += n;
            }
            return (total + acc) * (numberString.StartsWith("minus",
                    StringComparison.InvariantCultureIgnoreCase) ? -1 : 1);
        }
        

    }

}
