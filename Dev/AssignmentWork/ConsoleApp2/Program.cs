using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    static void Main(string[] args)
    {
        //sayıdan metne çevirme

        while (true)
        {
            string word = "";
            int num = 0;
            num = Convert.ToInt32(Console.ReadLine());
            word = NumberToWordsTR(num);

            Console.WriteLine(word);
        }
        

        //Console.WriteLine(int.MaxValue);
        //Console.WriteLine(int.MinValue);

        //2147483647
        //-2147483648

        //Console.WriteLine(test(1223));

        //Dictionary<int, string> dict = new Dictionary<int, string>{
        //  {1,"item1"},
        //  {2,"item2"},
        //  {3,"item3"},
        //};

        //int key = 2; // for example
        //string result = dict[key];
        //Console.WriteLine(result);

    }

    public static string NumberToWords(int number)
    {
        //ingilizce sayıdan metne çevirme kodu
        if (number == 0)
            return "zero";

        if (number < 0)
            return "minus " + NumberToWords(Math.Abs(number));

        string words = "";

        if ((number / 1000000) > 0)
        {
            words += NumberToWords(number / 1000000) + " million ";
            number %= 1000000;
        }

        if ((number / 1000) > 0)
        {
            words += NumberToWords(number / 1000) + " thousand ";
            number %= 1000;
        }

        if ((number / 100) > 0)
        {
            words += NumberToWords(number / 100) + " hundred ";
            number %= 100;
        }

        if (number > 0)
        {
            //if (words != "")
            //    words += "and ";

            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += "-" + unitsMap[number % 10];
            }
        }

        return words;
    }

    public static string NumberToWordsTR(int number)
    {
        //türkçe sayıdan metne çevirme kodu
        if (number == 0)
            return "sıfır";

        if (number < 0)
            return "eksi " + NumberToWordsTR(Math.Abs(number));

        string words = "";

        if(number / 1000000000>0)
        {
            words += NumberToWordsTR(number / 1000000000) + " milyar ";
            number %= 1000000000;
        }

        //if (number / 1000000000== 1)
        //{
        //    words += "milyar ";
        //    number %= 1000000000;
        //}

        if ((number / 1000000) > 0)
        {
            words += NumberToWordsTR(number / 1000000) + "milyon ";
            number %= 1000000;
        }


        if ((number / 1000) == 1)
        {
            words += "bin ";
            number %= 1000;
            
        }

        if ((number / 1000) > 1)
        {
            words += NumberToWordsTR(number / 1000) + "bin ";
            number %= 1000;
        }

        if ((number / 100) == 1)
        {
            words += "yüz ";
            number %= 100;
        }

        if ((number / 100) > 1)
        {
            words += NumberToWordsTR(number / 100) + " yüz ";
            number %= 100;
        }

        if (number > 0)
        {
            //if (words != "")
            //    words += "and ";

            var onesNumber = new[] { "sıfır", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz", "on", "on bir", "on iki", "on üç", "on dört", "on beş", "on altı", "on yedi", "on sekiz", "on dokuz" };
            var tensNumber = new[] { "sıfır", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan","yüz" };

            if (number < 20)
                words += onesNumber[number];
            else
            {
                words += tensNumber[number / 10];
                if ((number % 10) > 0)
                    words += " " + onesNumber[number % 10];
            }
        }

        return words;
    }

    public static string test(int number)
    {
        string[] Ones = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Ninteen" };
        string[] Tens = { "Ten", "Twenty", "Thirty", "Fourty", "Fift", "Sixty", "Seventy", "Eighty", "Ninty" };

        int no = number;
        string strWords = "";

        if (no > 999 && no < 10000)
        {
            int i = no / 1000;
            strWords = strWords + Ones[i - 1] + " Thousand ";
            no = no % 1000;
        }


        if (no > 99 && no < 1000)
        {
            int i = no / 100;
            strWords = strWords + Ones[i - 1] + " Hundred ";
            no = no % 100;
        }

        if (no > 19 && no < 100)
        {
            int i = no / 10;
            strWords = strWords + Tens[i - 1] + " ";
            no = no % 10;
        }

        if (no > 0 && no < 20)
        {
            strWords = strWords + Ones[no - 1];
        }

        return strWords;
    }
    
}