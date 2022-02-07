using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkProject
{
    public class FunctionalityService:ConvertService
    {
        public string _firstString { get; set; }
        public string _secondString { get; set; }
        public FunctionalityService(string firstString,string secondString)
        {
            _firstString = firstString;
            _secondString = secondString;
        }

        public String addProcess()
        {
            string result = "";
            string birinciMetin = _firstString;
            string birinciSayi = ConvertToNumber(birinciMetin).ToString();

            string ikinciMetin = _secondString;
            string ikinciSayi =ConvertToNumber(ikinciMetin).ToString();

            int sayibir = int.Parse(birinciSayi);
            int sayiiki = int.Parse(ikinciSayi);
            int total = sayibir + sayiiki;
            result = ConvertToWord(total);

            return result;
        }

        public String subtractProcess()
        {
            string result = "";
            string birinciMetin = _firstString;
            //string birinciSayi= _CombineService.ConvertToNumbers(birinciMetin).ToString();
            string birinciSayi = ConvertToNumber(birinciMetin).ToString();
            string ikinciMetin = _secondString;
            //string ikinciSayi = _CombineService.ConvertToNumbers(ikinciMetin).ToString();
            string ikinciSayi = ConvertToNumber(ikinciMetin).ToString();

            int sayibir = int.Parse(birinciSayi);
            int sayiiki = int.Parse(ikinciSayi);
            int total = sayibir - sayiiki;
            if (total < 0)
            {
                string toplam = total.ToString();
                toplam = toplam.Substring(1);
                result = "eksi " + ConvertToWord(int.Parse(toplam));
            }
            else if (total == 0)
            {
                result = "Sıfır";
            }
            else
            {
                result = ConvertToWord(total);
            }

            return result;
        }

        public String multiplyProcess()
        {
            string result = "";
            string birinciMetin = _firstString;
            //string birinciSayi= _CombineService.ConvertToNumbers(birinciMetin).ToString();
            string birinciSayi = ConvertToNumber(birinciMetin).ToString();
            //txtResult.Text = birinciSayi;

            string ikinciMetin = _secondString;
            //string ikinciSayi = _CombineService.ConvertToNumbers(ikinciMetin).ToString();
            string ikinciSayi = ConvertToNumber(ikinciMetin).ToString();

            int sayibir = int.Parse(birinciSayi);
            int sayiiki = int.Parse(ikinciSayi);
            int total = sayibir * sayiiki;
            result = ConvertToWord(total);

            return result;

        }


        
        public String divideProcess()
        {
            string result = "";
            string birinciMetin = _firstString;
            string ikinciMetin = _secondString;
            if (birinciMetin == "sıfır" && ikinciMetin == "sıfır")
            {
                result = "Sıfır";
            }
            else if (ikinciMetin == "sıfır")
            {
                result= "Tanımsız";
            }
            else
            {
                string birinciSayi = ConvertToNumber(birinciMetin).ToString();
                string ikinciSayi =  ConvertToNumber(ikinciMetin).ToString();
                int sayibir = int.Parse(birinciSayi);
                int sayiiki = int.Parse(ikinciSayi);
                int total = sayibir / sayiiki;

                result = ConvertToWord(total);
            }

            return result;
        }
    }
}
