using System;
using System.Collections;
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
    public partial class Test2 : Form
    {
        public Test2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
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
            string yeni = textBox1.Text.ToLower();
            string[] bol = yeni.Split(' ');
            int sayi = 0;
            for (int i = 1; i <= bol.Length; i++)
            {

                sayi = int.Parse(liste[bol[i - 1]].ToString()) + sayi;
            }
            label1.Text = label1.Text + " " + Convert.ToString(sayi);

        }

        private void Test2_Load(object sender, EventArgs e)
        {

        }

       
    }
}