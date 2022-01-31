namespace WorkProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CombineService _CombineService=new CombineService();
        private void btnTopla_Click(object sender, EventArgs e)
        {
            string birinciMetin=txtFirstNumber.Text;
            //string birinciSayi= _CombineService.ConvertToNumbers(birinciMetin).ToString();
            string birinciSayi= _CombineService.ConvertToNumber(birinciMetin).ToString();
            //txtResult.Text = birinciSayi;

            string ikinciMetin = txtSecondNumber.Text;
            //string ikinciSayi = _CombineService.ConvertToNumbers(ikinciMetin).ToString();
            string ikinciSayi = _CombineService.ConvertToNumber(ikinciMetin).ToString();

            int sayibir=int.Parse(birinciSayi);
            int sayiiki=int.Parse(ikinciSayi);
            int total = sayibir + sayiiki;
            txtResult.Text = _CombineService.ConvertToWord(total);
        }
    }
}