using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AssignmentProject.Services
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
        - Kullanıcı arayüzü için Winforms kullanılması bir bonustur.
        
        *******************************************************************
        -İlk servis yalnız dönüşümlerden sorumlu iken, diğer sevis arayüz 
        fonksiyonalitesi ve matematiksel işlemlerden sorumlu olmalı. 

        Diğer servisi tüm fonksiyonaliteyi sağlayan servis, 
        ilk servisi de diğer servisin kullandığı dönüştürücü servisi olarak düşünebilirsin. 

         int max=2147483647
         iki milyar yüz kırk yedi milyon dört yüz seksen üçbin altı yüz kırk yedi
         int min=-2147483648
         */

        private static Dictionary<string, int> numberTableEn = new()
        {
            //İngilizce dili için bir Dictionary oluşturuldu.
            { "zero", 0 },
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 },
            { "ten", 10 },
            { "eleven", 11 },
            { "twelve", 12 },
            { "thirteen", 13 },
            { "fourteen", 14 },
            { "fifteen", 15 },
            { "sixteen", 16 },
            { "seventeen", 17 },
            { "eighteen", 18 },
            { "nineteen", 19 },
            { "twenty", 20 },
            { "thirty", 30 },
            { "forty", 40 },
            { "fifty", 50 },
            { "sixty", 60 },
            { "seventy", 70 },
            { "eighty", 80 },
            { "ninety", 90 },
            { "hundred", 100 },
            { "thousand", 1000 },
            { "lakh", 100000 },
            { "million", 1000000 },
            { "billion", 1000000000 }
        };

        private static Dictionary<string, int> numberTableTr = new()
        {
            //Türkçe dili için Dictionary oluşturuldu
            { "sıfır", 0 },
            { "bir", 1 },
            { "iki", 2 },
            { "üç", 3 },
            { "dört", 4 },
            { "beş", 5 },
            { "altı", 6 },
            { "yedi", 7 },
            { "sekiz", 8 },
            { "dokuz", 9 },
            { "on", 10 },
            { "on bir", 11 },
            { "on iki", 12 },
            { "on üç", 13 },
            { "on dört", 14 },
            { "on beş", 15 },
            { "on altı", 16 },
            { "on yedi", 17 },
            { "on sekiz", 18 },
            { "on dokuz", 19 },
            { "yirmi", 20 },
            { "otuz", 30 },
            { "kırk", 40 },
            { "elli", 50 },
            { "altmış", 60 },
            { "yetmiş", 70 },
            { "seksen", 80 },
            { "doksan", 90 },
            { "yüz", 100 },
            { "bin", 1000 },
            { "on bin", 100000 },
            { "milyon", 1000000 },
            { "milyar", 1000000000 }

        };
        public static int ConvertToNumbersTr(string numberString)
        {

            /*
             * FunctionalityService'den gelen numberString değeri Regex.Matches ile numberTableTR Dictionary sinde aratıldı.
             * Select ile gönderilen metin m.Value.ToLowerInvariant() büyük küçük harfa karşı duyarsız hale getirildi.
             * Where ile numberTableTR Dictionary sinde ContainsKey özelliği ile yazılan metne ait sayı arandı.
             * Bulunan değer Select ile numbers değişkeni içine atıldı.
             *
            */

            //Ardışık gelen sayıların kontrolü yapıldı. Ardışık gelirse Exception fırlatır.
            string[] words = numberString.Split(" ");
            if (words.Length > 1)
            {
                for (int i = 0; i < words.Length - 1; i++)
                {

                    if (words[i] == words[i + 1])
                    {
                        //exception
                        throw new Exception("Lütfen geçerli bir sözdizimi giriniz.");

                    }

                }

            }

            //Dictionary içindeki sayılar kontrol ettirildi. Sayı yoksa Exception fırlatır.
            for (int a = 0; a < words.Length; a++)
            {
                int value;
                bool keyExists = numberTableTr.TryGetValue(words[a], out value);
                if (!keyExists)
                {
                    throw new Exception("Lütfen geçerli bir metin giriniz!");
                }
            }



            try
            {
                //w+ kuralı ile bir veya daha fazla kelime ile eşleşme elde edildi.
                var numbers = Regex.Matches(numberString, @"\w+").Cast<Match>()
                    .Select(e => e.Value.ToLowerInvariant())
                    .Where(o => numberTableTr.ContainsKey(o))
                    .Select(o => numberTableTr[o]);

                int accumulator = 0, totalNumber = 0; //Hesaplamalar için iki değişken oluşturuldu.
                foreach (var number in numbers) //numbers içindeki metnini tek tek almak için bir foreach döngüsü kullanıldı.
                {
                    checked
                    {
                        if (number >= 1000) //ilk kelimede olan sayı 1000'e eşit veya büyük ise if bloğu çalıştırıldı.
                        {
                            if (number == 1000 && accumulator == 0)
                            {
                                //number değişkeni 1000'e eşit ise be accumulator sıfıra eşit ise bin metnini bulmak için accumulatore 1 değeri verildi.
                                accumulator = 1;
                            }
                            //if içinde ki şartlardan sonra buradan devam edecek.
                            totalNumber += accumulator * number; //accumalator ile number değeri çarpıldı ve totalNumber değişkenine atıldı
                            accumulator = 0; //accumulator değişkeni diğer işlemler için tekrardan sıfır değeri atıldı
                        }
                        else if (number >= 100) //ilk kelimede olan sayı 100'e eşit veya büyük ise if bloğu çalıştırıldı.
                        {
                            if (number == 100 && accumulator == 0)
                            {
                                //number değişkeni 100'e eşit ise be accumulator sıfıra eşit ise yüz metnini bulmak için accumulatore 1 değeri verildi.
                                accumulator = 1;
                            }
                            accumulator *= number; //accumulator ile number değeri çarpıldı accumulator içine atıldı.
                        }

                        else
                            accumulator += number; //farklı gelen sayılar için accumulator ve number değeri toplantı accumulator içine atıldı.
                    }
                }
                return (totalNumber + accumulator) * (numberString.StartsWith("eksi",
                    StringComparison.InvariantCultureIgnoreCase) ? -1 : 1);

                /*
                 * return olarak ise total değişkeni ve accumulator değişkeni toplandı daha sonra
                 * metnin ilk kelimesi eksi ile başlıyorsa sayı -1 ile çarpıldı.
                 * minus ifadesi yok ise sayı 1 ile çarpılıp geriye int olarak gönderildi.
                 * StringComparison.InvariantCultureIgnoreCase ile eksi ifadesi büyük küçük harfe duyarsız hale getirildi.
                 */



            }
            catch (Exception e)
            {
                throw new Exception("Error " + e.Message);
            }

        }
        public static string NumberToWordsTr(int number)
        {
            /*
             * NumberToWordsEn metodunda olan işlemler ile aynı işlemleri yapmaktadır.
             * Burada sayıların Türkçe metinleri bulunmaktadır.
             * number ile gelen değerler Türkçe metne çevrilip geriye bir string göndermektedir.
             *
             */
            try
            {
                //türkçe sayıdan metne çevirme kodu
                if (number == 0)
                    return "sıfır";

                if (number < 0)
                    return "eksi " + NumberToWordsTr(Math.Abs(number));

                var stringNumbers = "";

                if (number / 1000000000 > 0)
                {
                    stringNumbers += NumberToWordsTr(number / 1000000000) + " milyar ";
                    number %= 1000000000;
                }
                if ((number / 1000000) > 0)
                {
                    stringNumbers += NumberToWordsTr(number / 1000000) + " milyon ";
                    number %= 1000000;
                }

                if ((number / 1000) == 1)
                {
                    /*
                     * Eğer sayının bine bölümünden sonuç 1 çıkarsa bu blog çalışır ve stringNumbers değişkenine bin yazılır.
                     * number içindeki değer ise 1000 ile mod alınır ve çıkan sonuç number değişkeni içine yazılır.
                     * 
                     */
                    stringNumbers += " bin ";
                    number %= 1000;

                }
                if ((number / 1000) > 1)
                {
                    stringNumbers += NumberToWordsTr(number / 1000) + " bin ";
                    number %= 1000;
                }

                if ((number / 100) == 1)
                {
                    /*
                    * Eğer sayının yüze bölümünden sonuç 1 çıkarsa bu blog çalışır ve stringNumbers değişkenine bin yazılır.
                    * number içindeki değer ise 100 ile mod alınır ve çıkan sonuç number değişkeni içine yazılır.
                    * 
                    */
                    stringNumbers += " yüz ";
                    number %= 100;
                }

                if ((number / 100) > 1)
                {
                    stringNumbers += NumberToWordsTr(number / 100) + " yüz ";
                    number %= 100;
                }

                if (number > 0)
                {
                    var onesNumber = new[] { "sıfır", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz", "on", "on bir", "on iki", "on üç", "on dört", "on beş", "on altı", "on yedi", "on sekiz", "on dokuz" };
                    var tensNumber = new[] { "sıfır", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan", "yüz" };

                    if (number < 20)
                        stringNumbers += onesNumber[number];
                    else
                    {
                        stringNumbers += tensNumber[number / 10];
                        if ((number % 10) > 0)
                            stringNumbers += " " + onesNumber[number % 10];
                    }
                }

                return stringNumbers; //çıkan sonuç geriye gönderilir.

            }
            catch (Exception e)
            {
                //Exception türü genel olarak ayarlandı.
                Console.WriteLine(e);
                throw;
            }

        }
        public static int ConvertToNumbersEn(string numberString)
        {

            string[] words = numberString.Split(" ");
            if (words.Length > 1)
            {
                for (int i = 0; i < words.Length - 1; i++)
                {

                    if (words[i] == words[i + 1])
                    {
                        //exception
                        throw new Exception("Please enter a valid syntax.");

                    }

                }

            }

            for (int a = 0; a < words.Length; a++)
            {
                int value;
                bool keyExists = numberTableEn.TryGetValue(words[a], out value);
                if (!keyExists)
                {
                    throw new Exception("Please enter valid text!");
                }
            }


            //Ingilizce dili için tazılan metni sayıya çeviren algoritma yazıldı.
            try
            {
                /*
                 * FunctionalityService'den gelen numberString değeri Regex.Matches ile numberTableEN Dictionary sinde aratıldı.
                 * Select ile gönderilen metin m.Value.ToLowerInvariant() büyük küçük harfa karşı duyarsız hale getirildi.
                 * Where ile numberTableEN Dictionary sinde ContainsKey özelliği ile yazılan metne ait sayı arandı.
                 * Bulunan değer Select ile numbers değişkeni içine atıldı.
                 */
                var numbers = Regex.Matches(numberString, @"\w+").Cast<Match>()
                    .Select(m => m.Value.ToLowerInvariant())
                    .Where(v => numberTableEn.ContainsKey(v))
                    .Select(v => numberTableEn[v]);
                int accumulator = 0, total = 0; //Hesaplamalar için iki değişken oluşturuldu.

                foreach (var number in numbers) //numbers içindeki metnini tek tek almak için bir foreach döngüsü kullanıldı.
                {
                    if (number >= 1000000000)
                    {
                        //billion
                        accumulator = 1;
                        total += accumulator * number;
                        accumulator = 0;
                    }
                    else if (number >= 1000000)
                    {
                        //million
                        total += accumulator * number;
                        accumulator = 0;
                    }
                    else if (number >= 1000) //ilk kelimede olan sayı 1000'e eşit veya büyük ise if bloğu çalıştırıldı.
                    {
                        //thousand
                        total += accumulator * number; //acc değeri ile number değeri çarpılıp total değişkenine eklendi.
                        accumulator = 0; //acc içini tekrar kullanabilmek için 0 değeri atandı.
                    }
                    else if (number >= 100) //number eğer 100'e eşit veya 100'den büyük ise if bloğu çalıştırıldı.
                    {
                        //tespit edilen yüzlük sayılar acc ile çarpıldı ve sonuç acc içine atıldı.
                        accumulator *= number;
                    }
                    else
                        accumulator += number; //gelecek olan birlik sayılar için acc ve number toplandı çıkan sonuç acc içine atıldı.
                }
                return (total + accumulator) * (numberString.StartsWith("minus",
                    StringComparison.InvariantCultureIgnoreCase) ? -1 : 1);

                /*
                 * return olarak ise total değişkeni ve accumulator değişkeni toplandı daha sonra
                 * metnin ilk kelimesi minus ile başlıyorsa sayı -1 ile çarpıldı.
                 * minus ifadesi yok ise sayı 1 ile çarpılıp geriye int olarak gönderildi.
                 * StringComparison.InvariantCultureIgnoreCase ile minus ifadesi büyük küçük harfe duyarsız hale getirildi.
                 */
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
        public static string NumberToWordsEn(int number)
        {
            try
            {
                //ingilizce sayıdan metne çevirme kodu
                if (number == 0)
                    return "zero";//gelen number eğer sıfır ise geriye metin olarak zero ifadesi gönderildi.

                if (number < 0)
                    return "minus " + NumberToWordsEn(Math.Abs(number)); //gelen number sıfırdan küçük ise geriye minus değeri ve NumberToWordsEn metodundan gelen değer gönderildi. 

                var stringNumbers = ""; //metinlerin atanacağı değişken oluşturuldu.

                /*
                 * number eğer bir milyara bölümünden çıkan sonuç 0 dan büyük ise bu alan çalışır
                 * NumberToWordsEn metodu bir milyara bölünüp çıkan değer ile tekrar kendine dönüş (Recursive) yapar.
                 * daha sonra buradan çıkan sonucun önüne de billion ifadesini ekleyip stringNumbers değişkenine atandı.
                 * number değeri bir milyarın mod değeri alınır ve çıkan sonuç number değişkenine atıldı.
                 * program satır satır ilerledikçe kalan number değerine göre uygun olan if bloklarına girip
                 * gerekli işlemleri yapacaktır.
                 */
                if ((number / 1000000000) > 0)
                {

                    stringNumbers += NumberToWordsEn(number / 1000000000) + " billion ";
                    number %= 1000000000;
                }
                if ((number / 1000000) > 0)
                {
                    stringNumbers += NumberToWordsEn(number / 1000000) + " million ";
                    number %= 1000000;
                }

                if ((number / 1000) > 0)
                {
                    stringNumbers += NumberToWordsEn(number / 1000) + " thousand ";
                    number %= 1000;
                }

                if ((number / 100) > 0)
                {
                    stringNumbers += NumberToWordsEn(number / 100) + " hundred ";

                    //100 e bölümünden kalan sıfır değilse sonunda 'and' ekler.
                    //Kalan sıfıra eşitse 'and' koymadan devam eder.
                    if (number % 100 != 0)
                    {
                        stringNumbers += "and ";
                    }

                    number %= 100; //100 e bölümünden kalanı alır diğer sayıları tespit eder.
                }

                if (number > 0)
                {
                    /*
                     * number değişkeni sıfırdan büyük ise blok çalışır.
                     * onesNumber,tensNumber dizilerine onluk ve birlik sayılar yazıldı.
                     */
                    var onesNumber = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                    var tensNumber = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                    if (number < 20)
                        //number değeri eğer yirmiden küçük ise onesNumber dizisine number değişkeni ile bakıldı.
                        //diziden gelen değer stringNumber değişkenine yazıldı.
                        stringNumbers += onesNumber[number];
                    else
                    {
                        //number değişkeni eğer 20 den büyük ise tensNumber dizisine number/10 dan çıkan değer ile gidip
                        //buradan çıkan değerin metnini alır ve stringNumbers içerisine yazdırır.

                        stringNumbers += tensNumber[number / 10];
                        if ((number % 10) > 0)
                            //number değişkeni ile mod 10 da çıkan sonuç sıfırdan büyük ise bu eksili bir sayıyı ifade eder.
                            //stringNumbers önüne boşluk yazdırılır ve onesNumber dizisi ile number mod 10 işleminden çıkan sonucun metnini bulur.
                            stringNumbers += " and " + onesNumber[number % 10];
                    }
                }

                return stringNumbers; //sonuçta ortaya çıkan metin geriye gönderildi.
            }
            catch (Exception e)
            {
                //Genel bir Exception kullanıldı.
                Console.WriteLine(e);
                throw;
            }

        }

    }
}
