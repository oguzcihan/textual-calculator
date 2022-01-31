using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkProject
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            process();

        }

        public void process()
        {
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text.ToString());
            string numberString = "";

            switch (sayi / 1000)
            {
                case 9: numberString += ("Dokuzbin "); break;
                case 8: numberString += ("Sekizbin "); break;
                case 7: numberString += ("Yedibin "); break;
                case 6: numberString += ("Altıbin "); break;
                case 5: numberString += ("Beşbin "); break;
                case 4: numberString += ("Dörtbin "); break;
                case 3: numberString += ("Üçbin "); break;
                case 2: numberString += ("İkibin "); break;
                case 1: numberString += ("Bin "); break;
            }
            switch (sayi % 1000 / 100)
            {
                case 9: numberString += ("Dokuzyüz "); break;
                case 8: numberString += ("Sekizyüz "); break;
                case 7: numberString += ("Yediyüz "); break;
                case 6: numberString += ("Altıyüz "); break;
                case 5: numberString += ("Beşyüz "); break;
                case 4: numberString += ("Dörtyüz "); break;
                case 3: numberString += ("Üçyüz "); break;
                case 2: numberString += ("İkiyüz "); break;
                case 1: numberString += ("Yüz "); break;
            }
            switch ((sayi % 100) / 10)
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
            switch ((sayi % 10))
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
            textBox2.Text = numberString;
            if (sayi == 0)
                Console.WriteLine("Sıfır ");
            Console.WriteLine("Şeklinde Okunur");
            //Console.ReadKey();
        }


    }
}
