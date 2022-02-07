using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentProject
{
    public class FunctionalityService : ConvertService //ConvertService classından kalıtım alındı
    {
        private string FirstString { get; set; }
        private string SecondString { get; set; }
        private string Language { get; set; }
        public FunctionalityService(string firstString, string secondString, string language)
        {
            //veriler constructor ile injection yapıldı.
            FirstString = firstString;
            SecondString = secondString;
            Language = language;
        }

        public string AddProcess()
        {
            
            try
            {
                string result = "";
                if (Language == "Türkçe") //dilin Türkçe olduğu kontrol ettirildi
                {
                    string birinciMetin = FirstString; //gönderilen firstnumber değeri alındı
                    string birinciSayi = ConvertToNumbersTr(birinciMetin).ToString(); //metin olarak ConvertToNumbersTr'ye gönderildi.

                    string ikinciMetin = SecondString; //gönderilen secondnumber değeri alındı
                    string ikinciSayi = ConvertToNumbersTr(ikinciMetin).ToString();//metin olarak ConvertToNumbersTr'ye gönderildi.
                    
                    //ConvertToNumbersTr'den gelen sayılar integer türüne dönüştürüldü.
                    int sayibir = int.Parse(birinciSayi); 
                    int sayiiki = int.Parse(ikinciSayi);

                    int total; //toplam için bir total değişkeni tanımlandı
                    checked
                    {
                        //sayibir ve sayiiki nin toplamının Int max ve Min'i geçmemesi için checked bloğu kullanıldı.
                        total = sayibir + sayiiki;
                    }
                    result = NumberToWordsTr(total); //total değişkeni NumberToWordsTr'ye metne dönüşmek üzere gönderildi.
                }
                else
                {
                    /*
                     *Türkçe dilinde yapılan işlemlerin aynısı bu blokta da yapıldı.
                     *Farklı metod olarak ConvertToNumbersEn kullanıldı
                     */

                    string birinciMetin = FirstString;
                    string birinciSayi = ConvertToNumbersEn(birinciMetin).ToString(); //metin olarak ConvertToNumbersEn metoduna gönderildi.
                    string ikinciMetin = SecondString;
                    string ikinciSayi = ConvertToNumbersEn(ikinciMetin).ToString();

                    int sayibir = int.Parse(birinciSayi);
                    int sayiiki = int.Parse(ikinciSayi);

                    int total;
                    checked
                    {
                        total = sayibir + sayiiki;
                    }
                    result = NumberToWordsEn(total);
                }

                return result; //bulunan sonuç değerleri result değişkeni ile Main class'ına tekrar dönüş yapacaktır.
            }
            catch (Exception e)
            {
                //Genel bir Exception türü kullanıldı.
                Console.WriteLine(e);
                throw;
            }

        }

        public string SubtractProcess()
        {
          
            try
            {
                string result = "";
                if (Language == "Türkçe") //dilin Türkçe olduğu kontrol ettirildi
                {

                    string birinciMetin = FirstString;  //gönderilen firstnumber değeri alındı
                    string birinciSayi = ConvertToNumbersTr(birinciMetin).ToString();
                    string ikinciMetin = SecondString;  //gönderilen secondnumber değeri alındı
                    string ikinciSayi = ConvertToNumbersTr(ikinciMetin).ToString();

                    int sayibir = int.Parse(birinciSayi);
                    int sayiiki = int.Parse(ikinciSayi);
                    int total;

                    checked
                    {
                        //sayibir ve sayiiki'nin çıkarma işlemi Int max ve Int min değerlerini geçmemesi için checked bloğu kullanıldı
                        total = sayibir - sayiiki;
                    }
                    if (total < 0)
                    {
                        //eğer total sıfırdan küçük ise başına eksi yazdırmak için bu alan oluşturuldu.
                        string toplam = total.ToString(); //total string'e dönüştürülüp bir toplam değişkenine atıldı.
                        toplam = toplam.Substring(1); //toplam değişkeninin '-' simgesi kesildi.
                        result = "eksi " + NumberToWordsTr(int.Parse(toplam)); //sonuç içine 'eksi' olarak yazdırılıp NumberToWordsTr metoduna gönderildi.
                    }
                    else if (total == 0)
                    {
                        //total eğer sıfıra eşit ise sıfır yazdırıldı.
                        result = "Sıfır";
                    }
                    else
                    {
                        //değer normal gelen bir değer ise bu blokta NumberToWordsTr metoduna gönderildi.
                        result = NumberToWordsTr(total);
                    }
                }
                else
                {
                    /*
                     *Türkçe dilinde yapılan işlemlerin aynısı bu blokta da yapıldı.
                     *Farklı metod olarak ConvertToNumbersEn kullanıldı
                     */
                    string birinciMetin = FirstString;
                    string birinciSayi = ConvertToNumbersEn(birinciMetin).ToString();
                    string ikinciMetin = SecondString;
                    string ikinciSayi = ConvertToNumbersEn(ikinciMetin).ToString();

                    int sayibir = int.Parse(birinciSayi);
                    int sayiiki = int.Parse(ikinciSayi);
                    int total;
                    
                    checked
                    {
                         total=sayibir - sayiiki;
                    }
                    if (total < 0)
                    {
                        string toplam = total.ToString();
                        toplam = toplam.Substring(1);
                        result = "eksi " + NumberToWordsEn(int.Parse(toplam));
                    }
                    else if (total == 0)
                    {
                        result = "Sıfır";
                    }
                    else
                    {
                        result = NumberToWordsEn(total);
                    }
                }

                return result;
            }
            catch (Exception e)
            {
                //Exception olarak genel bir tür kullanıldı.
                Console.WriteLine(e);
                throw;
            }


        }

        public string MultiplyProcess()
        {
            try
            {
                string result = "";
                if (Language == "Türkçe") //dilin Türkçe olduğu kontrol ettirildi
                {
                    string birinciMetin = FirstString; //gönderilen firstnumber değeri alındı
                    string birinciSayi = ConvertToNumbersTr(birinciMetin).ToString(); //metin olarak ConvertToNumbersTr'ye gönderildi.

                    string ikinciMetin = SecondString;
                    string ikinciSayi = ConvertToNumbersTr(ikinciMetin).ToString();

                    int sayibir = int.Parse(birinciSayi);
                    int sayiiki = int.Parse(ikinciSayi);
                    int total;

                    checked
                    {
                        //sayibir ve sayiiki'nin çarpma işlemi Int max ve Int min değerlerini geçmemesi için checked bloğu kullanıldı

                        total = sayibir * sayiiki;
                    }
                    result = NumberToWordsTr(total);

                }
                else
                {
                    /*
                     *Türkçe dilinde yapılan işlemlerin aynısı bu blokta da yapıldı.
                     *Farklı metod olarak ConvertToNumbersEn kullanıldı
                     */

                    string birinciMetin = FirstString;
                    string birinciSayi = ConvertToNumbersEn(birinciMetin).ToString();

                    string ikinciMetin = SecondString;
                    string ikinciSayi = ConvertToNumbersEn(ikinciMetin).ToString();

                    int sayibir = int.Parse(birinciSayi);
                    int sayiiki = int.Parse(ikinciSayi);
                    int total;

                    checked
                    {
                        total = sayibir * sayiiki;
                    }
                    result = NumberToWordsEn(total);
                }

                return result;
            }
            catch (Exception e)
            {
                //Exception türü olarak genel bir tür kullanıldı.
                Console.WriteLine(e);
                throw;
            }


        }

        public string DivideProcess()
        {

            try
            {
                string result = ""; 
                
                if (Language == "Türkçe") //dilin Türkçe olduğu kontrol ettirildi
                {
                    string birinciMetin = FirstString; //gönderilen firstnumber değeri alındı
                    string ikinciMetin = SecondString; //gönderilen secondnumber değeri alındı
                    if (birinciMetin == "sıfır" && ikinciMetin == "sıfır")
                    {
                        //gelen değerler içinden iki değerde sıfır ise geriye sıfır sonucu döndürüldü.
                        result = "Sıfır";
                    }
                    else if (ikinciMetin == "sıfır")
                    {
                        //gelen değerler içinden sadece ikincisayi sıfır ise bölüm durumunda tanımsızlık olacağı için 'Tanımsız' sonucu geri döndürüldü.
                        result = "Tanımsız";
                    }
                    else
                    {

                        try
                        {
                            //birinciSayi ConvertToNumbersTr metoduna gönderildi.
                            string birinciSayi = ConvertToNumbersTr(birinciMetin).ToString(); 
                            string ikinciSayi = ConvertToNumbersTr(ikinciMetin).ToString();
                            int sayibir = int.Parse(birinciSayi);
                            int sayiiki = int.Parse(ikinciSayi);
                            int total;

                            checked
                            {
                                //Oluşacak bir Int Max Min değer aşımı kontrolü yapıldı.
                                total = sayibir / sayiiki;
                            }

                            result = NumberToWordsTr(total); //sonuç NumberToWordsTr metoduna gönderiildi
                        }
                        catch (DivideByZeroException ex)
                        {
                            //Sıfıra bölümde aynı zamanda DivideByZeroExcepiton türü kullanıldı.
                            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    /*
                     *Türkçe dilinde yapılan işlemlerin aynısı bu blokta da yapıldı.
                     *Farklı metod olarak ConvertToNumbersEn kullanıldı
                     */

                    string birinciMetin = FirstString;
                    string ikinciMetin = SecondString;
                    if (birinciMetin == "sıfır" && ikinciMetin == "sıfır")
                    {
                        result = "Sıfır";
                    }
                    else if (ikinciMetin == "sıfır")
                    {
                        result = "Tanımsız";
                    }
                    else
                    {
                        string birinciSayi = ConvertToNumbersEn(birinciMetin).ToString();
                        string ikinciSayi = ConvertToNumbersEn(ikinciMetin).ToString();
                        int sayibir = int.Parse(birinciSayi);
                        int sayiiki = int.Parse(ikinciSayi);
                        int total;

                        checked
                        {
                            total = sayibir / sayiiki;
                        }

                        result = NumberToWordsEn(total);
                    }
                }

                return result;
            }
            catch (Exception e)
            {
                //Genel bir tür Exception kullanıldı.
                Console.WriteLine(e);
                throw;
            }


        }
    }
}
