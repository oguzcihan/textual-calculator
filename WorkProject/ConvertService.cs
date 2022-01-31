using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WorkProject
{
    public class ConvertService
    {
        /*
        - Uygulamanın temel amacı yazı olarak girilen iki sayı ile dört işlem yapmak ve sonucu yine yazılı olarak göstermektir.
        - Çarpma sonucunun gösterildiği bir örnek hayal edilerek kabaca yapılmış bir ekran tasarımını ekte verilmiştir.
        - Uygulamanın Türkçe ve İngilizce dil desteği olmalıdır.
        - Varsayılan dil Türkçe olmalıdır.
        - Yazıları sayıya ve sayıları yazıya çevirmek bir servisin işi olmalıdır.
        - Diğer servis ilk servisi kullanarak tanımladığımız kullanıcı arayüzünü ve işlemleri sunmalıdır.
        - İşlemler tam sayı işlemler olmalıdır.
        - Uygulamanın Visual Studio 19 community üzerinden çalıştırılması yeterlidir.
        - Kullanıcı arayüzü için Winforms kullanılması bir bonustur.*/

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

        public long ConvertToNumbers(string numberString)
        {
            var numbers = Regex.Matches(numberString, @"\w+").Cast<Match>()
                    .Select(m => m.Value.ToLowerInvariant())
                    .Where(v => numberTableTr.ContainsKey(v))
                    .Select(v => numberTableTr[v]);
            long acc = 0, total = 0L;

            foreach (var n in numbers)
            {
                acc += n;
                /*
                if (n >= 1000)
                {
                    total += acc * n;
                    acc = 0;
                }
                else if (n >= 100)
                {
                    acc *= n;
                }
                else acc += n;*/
            }
            return (total + acc) * (numberString.StartsWith("eksi",
                    StringComparison.InvariantCultureIgnoreCase) ? -1 : 1);
        }

        public long ConvertToNumber(string numberString)
        {
            Hashtable liste = new Hashtable();
            liste.Add("bir", "1");
            liste.Add("iki", "2");
            liste.Add("üç", "3");
            liste.Add("dört", "4");
            liste.Add("beş", "5");
            liste.Add("altı", "6");
            liste.Add("yedi", "7");
            liste.Add("sekiz", "8");
            liste.Add("dokuz", "9");
            liste.Add("on", "10");
            liste.Add("yirmi", "20");
            liste.Add("otuz", "30");
            liste.Add("kırk", "40");
            liste.Add("elli", "50");
            liste.Add("altmış", "60");
            liste.Add("yetmiş", "70");
            liste.Add("seksen", "80");
            liste.Add("doksan", "90");
            liste.Add("yüz", "100");
            liste.Add("ikiyüz", "200");
            liste.Add("üçyüz", "300");
            liste.Add("dörtyüz", "400");
            liste.Add("beşyüz", "500");
            liste.Add("altıyüz", "600");
            liste.Add("yediyüz", "700");
            liste.Add("sekizyüz", "800");
            liste.Add("dokuzyüz", "900");
            liste.Add("bin", "1000");
            //string yeni = textBox1.Text.ToLower();
            string[] bol = numberString.Split(' ');
            int sayi = 0;
            for (int i = 1; i <= bol.Length; i++)
            {

                sayi = int.Parse(liste[bol[i - 1]].ToString()) + sayi;
            }
            
            return sayi;
        }

        public String ConvertToWord(int number)
        {
            string numberString = "";
            try
            {
                //number = Convert.ToInt32(textBox1.Text.ToString());

                switch (number / 1000)
                {
                    case 9: numberString += ("Dokuz bin "); break;
                    case 8: numberString += ("Sekiz bin "); break;
                    case 7: numberString += ("Yedi bin "); break;
                    case 6: numberString += ("Altı bin "); break;
                    case 5: numberString += ("Beş bin "); break;
                    case 4: numberString += ("Dört bin "); break;
                    case 3: numberString += ("Üç bin "); break;
                    case 2: numberString += ("İki bin "); break;
                    case 1: numberString += ("Bin "); break;
                }
                switch (number % 1000 / 100)
                {
                    case 9: numberString += ("Dokuz yüz "); break;
                    case 8: numberString += ("Sekiz yüz "); break;
                    case 7: numberString += ("Yedi yüz "); break;
                    case 6: numberString += ("Altı yüz "); break;
                    case 5: numberString += ("Beş yüz "); break;
                    case 4: numberString += ("Dört yüz "); break;
                    case 3: numberString += ("Üç yüz "); break;
                    case 2: numberString += ("İki yüz "); break;
                    case 1: numberString += ("Yüz "); break;
                }
                switch ((number % 100) / 10)
                {
                    case 9: numberString += ("Doksan "); break;
                    case 8: numberString += ("Seksen "); break;
                    case 7: numberString += ("Yetmiş "); break;
                    case 6: numberString += ("Altmış "); break;
                    case 5: numberString += ("Elli "); break;
                    case 4: numberString += ("Kırk "); break;
                    case 3: numberString += ("Otuz "); break;
                    case 2: numberString += ("Yirmi "); break;
                    case 1: numberString += ("On "); break;
                }
                switch ((number % 10))
                {
                    case 9: numberString += ("Dokuz "); break;
                    case 8: numberString += ("Sekiz "); break;
                    case 7: numberString += ("Yedi "); break;
                    case 6: numberString += ("Altı "); break;
                    case 5: numberString += ("Beş "); break;
                    case 4: numberString += ("Dört "); break;
                    case 3: numberString += ("Üç "); break;
                    case 2: numberString += ("İki "); break;
                    case 1: numberString += ("Bir "); break;
                }
                // textBox2.Text = numberString;

               

            }

            catch

            {

            }

            return numberString;

        }


    }
}
