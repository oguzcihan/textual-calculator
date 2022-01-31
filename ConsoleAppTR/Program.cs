using System.Text.RegularExpressions;

namespace Program
{
    public class Program
    {

        private static Dictionary<string, long> numberTableTr = new Dictionary<string, long>{
        {"sıfır",0},{"bir",1},{"iki",2},{"üç",3},{"dört",4},{"beş",5},{"altı",6},
        {"yedi",7},{"sekiz",8},{"dokuz",9},{"on",10},{"on bir",11},{"on iki",12},
        {"on üç",13},{"on dört",14},{"on beş",15},{"on altı",16},{"on yedi",17},
        {"on sekiz",18},{"on dokuz",19},{"yirmi",20},{"otuz",30},{"kırk",40},
        {"elli",50},{"altmış",60},{"yetmiş",70},{"seksen",80},{"doksan",90},
        {"yüz",100},{"bin",1000},{"yüz bin",100000},{"milyon",1000000},
        {"milyar",1000000000},{"trilyon",1000000000000},{"katrilyon",1000000000000000},
        {"kentilyon",1000000000000000000}
        };

        private static Dictionary<string, long> numberTableEn = new Dictionary<string, long>{
        {"zero",0},{"one",1},{"two",2},{"three",3},{"four",4},{"five",5},{"six",6},
        {"seven",7},{"eight",8},{"nine",9},{"ten",10},{"eleven",11},{"twelve",12},
        {"thirteen",13},{"fourteen",14},{"fifteen",15},{"sixteen",16},{"seventeen",17},
        {"eighteen",18},{"nineteen",19},{"twenty",20},{"thirty",30},{"forty",40},
        {"fifty",50},{"sixty",60},{"seventy",70},{"eighty",80},{"ninety",90},
        {"hundred",100},{"thousand",1000},{"lakh",100000},{"million",1000000},
        {"billion",1000000000},{"trillion",1000000000000},{"quadrillion",1000000000000000},
        {"quintillion",1000000000000000000}
        };

        private static long ConvertToNumbers(string numberString)
        {
            var numbers = Regex.Matches(numberString, @"\w+").Cast<Match>()
                    .Select(m => m.Value.ToLowerInvariant())
                    .Where(v => numberTableTr.ContainsKey(v))
                    .Select(v => numberTableTr[v]);
            
            long acc = 0, total = 0L;

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
            return (total + acc) * (numberString.StartsWith("eksi",
                    StringComparison.InvariantCultureIgnoreCase) ? -1 : 1);
        }

        /*****************************************/

        public static ulong WordsToNumbers(string words)
        {
            if (string.IsNullOrEmpty(words)) return 0;

            words = words.Trim();
            words += ' ';

            ulong number = 0;
            string[] singles = new string[] { "sıfır", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] teens = new string[] { "on", "on bir", "on iki", "on üç", "on dört", "on beş", "on altı", "on yedi", "on sekiz", "on dokuz" };
            string[] tens = new string[] { "", "", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
            string[] powers = new string[] { "", "bin", "milyon", "milyar", "trilyon", "katrilyon", "kentilyon" };

            for (int i = powers.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(powers[i]))
                {
                    int index = words.IndexOf(powers[i]);

                    if (index >= 0 && words[index + powers[i].Length] == ' ')
                    {
                        ulong count = WordsToNumbers(words.Substring(0, index));
                        number += count * (ulong)Math.Pow(1000, i);
                        words = words.Remove(0, index);
                    }
                }
            }

            {
                int index = words.IndexOf("yüz");

                if (index >= 0 && words[index + "yüz".Length] == ' ')
                {
                    ulong count = WordsToNumbers(words.Substring(0, index));
                    number += count * 100;
                    words = words.Remove(0, index);
                }
            }

            for (int i = tens.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(tens[i]))
                {
                    int index = words.IndexOf(tens[i]);

                    if (index >= 0 && words[index + tens[i].Length] == ' ')
                    {
                        number += (uint)(i * 10);
                        words = words.Remove(0, index);
                    }
                }
            }

            for (int i = teens.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(teens[i]))
                {
                    int index = words.IndexOf(teens[i]);

                    if (index >= 0 && words[index + teens[i].Length] == ' ')
                    {
                        number += (uint)(i + 10);
                        words = words.Remove(0, index);
                    }
                }
            }

            for (int i = singles.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(singles[i]))
                {
                    int index = words.IndexOf(singles[i] + ' ');

                    if (index >= 0 && words[index + singles[i].Length] == ' ')
                    {
                        number += (uint)(i);
                        words = words.Remove(0, index);
                    }
                }
            }

            return number;
        }

        static void Main(string[] args)
        {
            //try
            //{

            //    string strNumber = Console.ReadLine();
            //    string rtnNumber = ConvertToNumbers(strNumber).ToString();

            //    Console.WriteLine("Sayı: {0}", rtnNumber);
            //    Console.ReadKey();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            string data = "";
            ulong value = WordsToNumbers(data);
            Console.WriteLine(value);


        }
    }
}