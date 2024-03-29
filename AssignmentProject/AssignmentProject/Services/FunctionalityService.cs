﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentProject.Services
{
    public class FunctionalityService : ConvertService //ConvertService Class'ından inherit edildi.
    {
        private string FirstString { get; set; }
        private string SecondString { get; set; }
        private string Language { get; set; }
        public FunctionalityService(string firstString, string secondString, string language)
        {
            //Veriler constructor ile injection yapıldı.
            FirstString = firstString;
            SecondString = secondString;
            Language = language;
        }

        //Değişkenler tanımlandı
        private int _firstNumber;
        private int _secondNumber;
        public string? AddProcess()
        {
            //null değer gelebileceğini belirtmek için ? kullanıldı.
            try
            {
                string result = "";
                if (Language == "Türkçe") //dilin Türkçe olduğu kontrol ettirildi
                {

                    _firstNumber = ConvertToNumbersTr(FirstString);//metin olarak ConvertToNumbersTr'ye gönderildi.
                    _secondNumber = ConvertToNumbersTr(SecondString);//metin olarak ConvertToNumbersTr'ye gönderildi.
                    int total; //toplam için bir total değişkeni tanımlandı
                    checked
                    {
                        //_firstNumber ve _secondNumber toplamının Int max ve Min'i geçmemesi için checked bloğu kullanıldı.
                        total = _firstNumber + _secondNumber;
                    }
                    result = NumberToWordsTr(total); //total değişkeni NumberToWordsTr'ye metne dönüşmek üzere gönderildi.

                }
                else
                {
                    /*
                     *Türkçe dilinde yapılan işlemlerin aynısı bu blokta da yapıldı.
                     *Farklı metod olarak ConvertToNumbersEn kullanıldı
                     */

                    _firstNumber = ConvertToNumbersEn(FirstString); //metin olarak ConvertToNumbersEn metoduna gönderildi.
                    _secondNumber = ConvertToNumbersEn(SecondString);

                    int total;
                    checked
                    {
                        total = _firstNumber + _secondNumber;
                    }
                    result = NumberToWordsEn(total);
                }

                return result; //bulunan sonuç değerleri result değişkeni ile Main class'ına tekrar dönüş yapacaktır.
            }
            catch (ArithmeticException arithmeticException)
            {
                MessageBox.Show(arithmeticException.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public string? SubtractProcess()
        {

            try
            {
                string result = "";
                if (Language == "Türkçe") //dilin Türkçe olduğu kontrol ettirildi
                {


                    _firstNumber = ConvertToNumbersTr(FirstString); //gönderilen firstnumber değeri alındı
                    _secondNumber = ConvertToNumbersTr(SecondString); //gönderilen secondnumber değeri alındı
                    int total;

                    checked
                    {
                        //_firstNumber ve _secondNumber çıkarma işlemi Int max ve Int min değerlerini geçmemesi için checked bloğu kullanıldı
                        total = _firstNumber - _secondNumber;
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
                    _firstNumber = ConvertToNumbersEn(FirstString); //gönderilen firstnumber değeri alındı
                    _secondNumber = ConvertToNumbersEn(SecondString);
                    int total;

                    checked
                    {
                        total = _firstNumber - _secondNumber;
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
            catch (ArithmeticException arithmeticException)
            {

                Console.WriteLine(arithmeticException.Message);
                MessageBox.Show(arithmeticException.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


        }

        public string? MultiplyProcess()
        {
            try
            {
                string result = "";
                if (Language == "Türkçe") //dilin Türkçe olduğu kontrol ettirildi
                {

                    _firstNumber = ConvertToNumbersTr(FirstString); //metin olarak ConvertToNumbersTr'ye gönderildi.
                    _secondNumber = ConvertToNumbersTr(SecondString);
                    int total;

                    checked
                    {
                        //_firstNumber ve _secondNumber çarpma işlemi Int max ve Int min değerlerini geçmemesi için checked bloğu kullanıldı

                        total = _firstNumber * _secondNumber;
                    }
                    result = NumberToWordsTr(total);

                }
                else
                {
                    /*
                     *Türkçe dilinde yapılan işlemlerin aynısı bu blokta da yapıldı.
                     *Farklı metod olarak ConvertToNumbersEn kullanıldı
                     */

                    _firstNumber = ConvertToNumbersEn(FirstString);
                    _secondNumber = ConvertToNumbersEn(SecondString);
                    int total;

                    checked
                    {
                        total = _firstNumber * _secondNumber;
                    }
                    result = NumberToWordsEn(total);
                }

                return result;
            }
            catch (ArithmeticException arithmeticException)
            {

                Console.WriteLine(arithmeticException.Message);
                MessageBox.Show(arithmeticException.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


        }

        public string? DivideProcess()
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
                            _firstNumber = ConvertToNumbersTr(txtFirst);
                            _secondNumber = ConvertToNumbersTr(txtSecond);
                            int total;

                            checked
                            {
                                //Oluşacak bir Int Max Min değer aşımı kontrolü yapıldı.
                                total = _firstNumber / _secondNumber;
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
                        _firstNumber = ConvertToNumbersEn(txtFirst);
                        _secondNumber = ConvertToNumbersEn(txtSecond);
                        int total;

                        checked
                        {
                            total = _firstNumber / _secondNumber;
                        }

                        result = NumberToWordsEn(total);
                    }
                }

                return result;
            }
            catch (ArithmeticException arithmeticException)
            {

                Console.WriteLine(arithmeticException.Message);
                MessageBox.Show(arithmeticException.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


        }
    }
}
