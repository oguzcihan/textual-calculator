using System.Text.RegularExpressions;

namespace Program
{
    public class Program
    {
        private static Dictionary<string, long> numberTable = new Dictionary<string, long>{
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
                    .Where(v => numberTable.ContainsKey(v))
                    .Select(v => numberTable[v]);
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
            return (total + acc) * (numberString.StartsWith("minus",
                    StringComparison.InvariantCultureIgnoreCase) ? -1 : 1);
        }
        static void Main(string[] args)
        {
            try
            {
                
                string strNumber = Console.ReadLine();
                string rtnNumber = ConvertToNumbers(strNumber).ToString();

                Console.WriteLine("Number is {0}", rtnNumber);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void test()
        {
            int sayi, i = 0;
            do
            {
                Console.Write("Lütfen Bir Sayı Giriniz = ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi==9999 || sayi==0)
                    Console.WriteLine("Girdiğiniz Sayı 0 İle 9999 Arasında Olmalıdır !!!");
                else
                    break;
            } while (i == 1);
            Console.WriteLine("{0} Sayısı", sayi);
            switch (sayi / 1000)
            {
                case 9: Console.Write("Dokuzbin "); break;
                case 8: Console.Write("Sekizbin "); break;
                case 7: Console.Write("Yedibin "); break;
                case 6: Console.Write("Altıbin "); break;
                case 5: Console.Write("Beşbin "); break;
                case 4: Console.Write("Dörtbin "); break;
                case 3: Console.Write("Üçbin "); break;
                case 2: Console.Write("İkibin "); break;
                case 1: Console.Write("Bin "); break;
            }
            switch (sayi % 1000 / 100)
            {
                case 9: Console.Write("Dokuzyüz "); break;
                case 8: Console.Write("Sekizyüz "); break;
                case 7: Console.Write("Yediyüz "); break;
                case 6: Console.Write("Altıyüz "); break;
                case 5: Console.Write("Beşyüz "); break;
                case 4: Console.Write("Dörtyüz "); break;
                case 3: Console.Write("Üçyüz "); break;
                case 2: Console.Write("İkiyüz "); break;
                case 1: Console.Write("Yüz "); break;
            }
            switch ((sayi % 100) / 10)
            {
                case 9: Console.Write("Doksan "); break;
                case 8: Console.Write("Seksen "); break;
                case 7: Console.Write("Yetmiş "); break;
                case 6: Console.Write("Altmış "); break;
                case 5: Console.Write("Elli "); break;
                case 4: Console.Write("Kırk "); break;
                case 3: Console.Write("Otuz "); break;
                case 2: Console.Write("Yirmi "); break;
                case 1: Console.Write("On "); break;
            }
            switch ((sayi % 10))
            {
                case 9: Console.Write("Dokuz "); break;
                case 8: Console.Write("Sekiz "); break;
                case 7: Console.Write("Yedi "); break;
                case 6: Console.Write("Altı "); break;
                case 5: Console.Write("Beş "); break;
                case 4: Console.Write("Dört "); break;
                case 3: Console.Write("Üç "); break;
                case 2: Console.Write("İki "); break;
                case 1: Console.Write("Bir "); break;
            }
            if (sayi == 0)
                Console.WriteLine("Sıfır ");
            Console.Write("Şeklinde Okunur");
            Console.ReadKey();
        }
    }
    
}