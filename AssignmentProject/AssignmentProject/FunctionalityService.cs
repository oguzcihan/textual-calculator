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

        private string _firstNumber;
        private string _secondNumber;
        private int _numberOne;
        private int _numberTwo;
        public string AddProcess()
        {
            
            try
            {
                string result = "";
                if (Language == "Türkçe") //dilin Türkçe olduğu kontrol ettirildi
                {

                    _firstNumber = ConvertToNumbersTr(FirstString).ToString(); //metin olarak ConvertToNumbersTr'ye gönderildi.
                    _secondNumber = ConvertToNumbersTr(SecondString).ToString();//metin olarak ConvertToNumbersTr'ye gönderildi.
                    
                    //ConvertToNumbersTr'den gelen sayılar integer türüne dönüştürüldü.
                    _numberOne = int.Parse(_firstNumber); 
                    _numberTwo = int.Parse(_secondNumber);

                    int total; //toplam için bir total değişkeni tanımlandı
                    checked
                    {
                        //sayibir ve sayiiki nin toplamının Int max ve Min'i geçmemesi için checked bloğu kullanıldı.
                        total = _numberOne + _numberTwo;
                    }
                    result = NumberToWordsTr(total); //total değişkeni NumberToWordsTr'ye metne dönüşmek üzere gönderildi.
                }
                else
                {
                    /*
                     *Türkçe dilinde yapılan işlemlerin aynısı bu blokta da yapıldı.
                     *Farklı metod olarak ConvertToNumbersEn kullanıldı
                     */

                    _firstNumber = ConvertToNumbersEn(FirstString).ToString(); //metin olarak ConvertToNumbersEn metoduna gönderildi.
                    _secondNumber = ConvertToNumbersEn(SecondString).ToString();

                    _numberOne = int.Parse(_firstNumber);
                    _numberTwo = int.Parse(_secondNumber);

                    int total;
                    checked
                    {
                        total = _numberOne + _numberTwo;
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

                     
                    _firstNumber = ConvertToNumbersTr(FirstString).ToString(); //gönderilen firstnumber değeri alındı
                    _secondNumber = ConvertToNumbersTr(SecondString).ToString(); //gönderilen secondnumber değeri alındı

                    _numberOne = int.Parse(_firstNumber);
                    _numberTwo = int.Parse(_secondNumber);
                    int total;

                    checked
                    {
                        //sayibir ve sayiiki'nin çıkarma işlemi Int max ve Int min değerlerini geçmemesi için checked bloğu kullanıldı
                        total = _numberOne - _numberTwo;
                    }
                    if (total < 0)
                    {
                        //eğer total sıfırdan küçük ise başına eksi yazdırmak için bu alan oluşturuldu.
                        string totalString = total.ToString(); //total string'e dönüştürülüp bir toplam değişkenine atıldı.
                        totalString = totalString.Substring(1); //toplam değişkeninin '-' simgesi kesildi.
                        result = "eksi " + NumberToWordsTr(int.Parse(totalString)); //sonuç içine 'eksi' olarak yazdırılıp NumberToWordsTr metoduna gönderildi.
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
                    _firstNumber = ConvertToNumbersTr(FirstString).ToString(); //gönderilen firstnumber değeri alındı
                    _secondNumber = ConvertToNumbersTr(SecondString).ToString();

                    _numberOne = int.Parse(_firstNumber);
                    _numberTwo = int.Parse(_secondNumber);
                    int total;
                    
                    checked
                    {
                         total= _numberOne - _numberTwo;
                    }
                    if (total < 0)
                    {
                        string totalString = total.ToString();
                        totalString = totalString.Substring(1);
                        result = "eksi " + NumberToWordsEn(int.Parse(totalString));
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

                    _firstNumber = ConvertToNumbersTr(FirstString).ToString(); //metin olarak ConvertToNumbersTr'ye gönderildi.
                    _secondNumber = ConvertToNumbersTr(SecondString).ToString();

                    _numberOne = int.Parse(_firstNumber);
                    _numberTwo = int.Parse(_secondNumber);
                    int total;

                    checked
                    {
                        //sayibir ve sayiiki'nin çarpma işlemi Int max ve Int min değerlerini geçmemesi için checked bloğu kullanıldı

                        total = _numberOne * _numberTwo;
                    }
                    result = NumberToWordsTr(total);

                }
                else
                {
                    /*
                     *Türkçe dilinde yapılan işlemlerin aynısı bu blokta da yapıldı.
                     *Farklı metod olarak ConvertToNumbersEn kullanıldı
                     */

                    _firstNumber = ConvertToNumbersEn(FirstString).ToString();
                    _secondNumber = ConvertToNumbersEn(SecondString).ToString();

                    _numberOne = int.Parse(_firstNumber);
                    _numberTwo = int.Parse(_secondNumber);
                    int total;

                    checked
                    {
                        total = _numberOne * _numberTwo;
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
                    string txtFirst = FirstString; //gönderilen firstnumber değeri alındı
                    string txtSecond = SecondString; //gönderilen secondnumber değeri alındı
                    if (txtFirst == "sıfır" && txtSecond == "sıfır")
                    {
                        //gelen değerler içinden iki değerde sıfır ise geriye sıfır sonucu döndürüldü.
                        result = "Sıfır";
                    }
                    else if (txtSecond == "sıfır")
                    {
                        //gelen değerler içinden sadece ikincisayi sıfır ise bölüm durumunda tanımsızlık olacağı için 'Tanımsız' sonucu geri döndürüldü.
                        result = "Tanımsız";
                    }
                    else
                    {

                        try
                        {
                            //birinciSayi ConvertToNumbersTr metoduna gönderildi.
                            _firstNumber = ConvertToNumbersTr(txtFirst).ToString(); 
                            _secondNumber= ConvertToNumbersTr(txtSecond).ToString();
                            _numberOne= int.Parse(_firstNumber);
                            _numberTwo= int.Parse(_secondNumber);
                            int total;

                            checked
                            {
                                //Oluşacak bir Int Max Min değer aşımı kontrolü yapıldı.
                                total = _numberOne / _numberTwo;
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

                    string txtFirst = FirstString; //gönderilen firstnumber değeri alındı
                    string txtSecond = SecondString; //gönderilen secondnumber değeri alındı
                    if (txtFirst == "sıfır" && txtSecond == "sıfır")
                    {
                        result = "Sıfır";
                    }
                    else if (txtSecond == "sıfır")
                    {
                        result = "Tanımsız";
                    }
                    else
                    {
                        _firstNumber = ConvertToNumbersEn(txtFirst).ToString();
                        _secondNumber = ConvertToNumbersEn(txtSecond).ToString();
                        _numberOne = int.Parse(_firstNumber);
                        _numberTwo = int.Parse(_secondNumber);
                        int total;

                        checked
                        {
                            total = _numberOne / _numberTwo;
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
