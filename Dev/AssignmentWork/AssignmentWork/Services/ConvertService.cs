using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentWork.Services
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
         *  
         */

        public String _number1 { get; set; }
        public String _number2 { get; set; }
        public String TextResult { get; set; }

        public int NumberResult; //class elemanı
        public ConvertService(String number1,String number2)
        {
            _number1 = number1;
            _number2 = number2;
        }
            

    }
}
