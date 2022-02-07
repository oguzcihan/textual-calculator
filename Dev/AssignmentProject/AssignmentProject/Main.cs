namespace AssignmentProject
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void txtFirstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece metin giriþi
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                                                  && !char.IsSeparator(e.KeyChar);
        }

        private void txtSecondNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sadece metin giriþi
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                                                  && !char.IsSeparator(e.KeyChar);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            cmbLang.SelectedIndex = 0; //geçerli dil türkçe
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //textbox kontrol
            //Toplama iþlemi butonu
            try
            {
                if (txtFirstNumber.Text == "" && txtSecondNumber.Text == "")
                {
                    //textbox'lar boþ olma durumu hata gönderildi
                    errorProvider1.SetError(txtFirstNumber, "Zorunlu Alan");
                    errorProvider1.SetError(txtSecondNumber, "Zorunlu Alan");
                }
                else if (txtFirstNumber.Text == "")
                {
                    errorProvider1.SetError(txtFirstNumber, "Zorunlu Alan");
                }
                else if (txtSecondNumber.Text == "")
                {
                    errorProvider1.SetError(txtSecondNumber, "Zorunlu Alan");
                }
                else
                {
                    var lang = cmbLang.SelectedItem.ToString(); //dil seçimi deðiþkene atandý
                    FunctionalityService functionalityService = new FunctionalityService(txtFirstNumber.Text, txtSecondNumber.Text, lang);
                    // firstnumber, secondnumber FunctionalityService classýna nesne aracýlýðý ile gönderildi.
                    txtResult.Text = functionalityService.AddProcess(); //üretilen nesneden AddProcess metodu çaðrýldý.
                    lblStatus.Text = "Toplama Ýþlemi Baþarýlý."; //status label'ýna iþlem özeti gönderildi.
                }
            }
            catch (ArithmeticException exception)
            {
                //ArithmeticException ile Int Max ve Min deðerleri aþýmý yakalandý.
                Console.WriteLine(exception.StackTrace);
                MessageBox.Show("Int Max/Min deðeri aþýldý", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            //Çýkarma iþlemi butonuna basýldýðýnda;
       
            try
            {
                if (txtFirstNumber.Text == "" && txtSecondNumber.Text == "")
                {
                    errorProvider1.SetError(txtFirstNumber, "Zorunlu Alan");
                    errorProvider1.SetError(txtSecondNumber, "Zorunlu Alan");
                }
                else if (txtFirstNumber.Text == "")
                {
                    errorProvider1.SetError(txtFirstNumber, "Zorunlu Alan");
                }
                else if (txtSecondNumber.Text == "")
                {
                    errorProvider1.SetError(txtSecondNumber, "Zorunlu Alan");
                }
                else
                {
                    var lang = cmbLang.SelectedItem.ToString();
                    FunctionalityService functionalityService = new FunctionalityService(txtFirstNumber.Text, txtSecondNumber.Text, lang);
                    // firstnumber, secondnumber FunctionalityService classýna nesne aracýlýðý ile gönderildi.
                    txtResult.Text = functionalityService.SubtractProcess(); //üretilen nesneden SubtractProcess metodu çaðrýldý.
                    lblStatus.Text = "Çýkarma Ýþlemi Baþarýlý.";
                }
            }
            catch (ArithmeticException exception)
            {
                Console.WriteLine(exception.StackTrace);
                MessageBox.Show("Int Max/Min deðeri aþýldý", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            //Çarpma iþlemi butonuna basýldýðýnda;
            try
            {
                if (txtFirstNumber.Text == "" && txtSecondNumber.Text == "")
                {
                    errorProvider1.SetError(txtFirstNumber, "Zorunlu Alan");
                    errorProvider1.SetError(txtSecondNumber, "Zorunlu Alan");
                }
                else if (txtFirstNumber.Text == "")
                {
                    errorProvider1.SetError(txtFirstNumber, "Zorunlu Alan");
                }
                else if (txtSecondNumber.Text == "")
                {
                    errorProvider1.SetError(txtSecondNumber, "Zorunlu Alan");
                }
                else
                {
                    var lang = cmbLang.SelectedItem.ToString();
                    FunctionalityService functionalityService = new FunctionalityService(txtFirstNumber.Text, txtSecondNumber.Text, lang);
                    // firstnumber, secondnumber FunctionalityService classýna nesne aracýlýðý ile gönderildi.
                    txtResult.Text = functionalityService.MultiplyProcess(); //üretilen nesneden MultiplyProcess metodu çaðrýldý.
                    lblStatus.Text = "Çarpma Ýþlemi Baþarýlý.";
                }
            }
            catch (ArithmeticException exception)
            {
                Console.WriteLine(exception.StackTrace);
                MessageBox.Show("Int Max/Min deðeri aþýldý", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            //Bölme iþlemi butonuna basýldýðýnda;
            try
            {
                if (txtFirstNumber.Text == "" && txtSecondNumber.Text == "")
                {
                    errorProvider1.SetError(txtFirstNumber, "Zorunlu Alan");
                    errorProvider1.SetError(txtSecondNumber, "Zorunlu Alan");
                }
                else if (txtFirstNumber.Text == "")
                {
                    errorProvider1.SetError(txtFirstNumber, "Zorunlu Alan");
                }
                else if (txtSecondNumber.Text == "")
                {
                    errorProvider1.SetError(txtSecondNumber, "Zorunlu Alan");
                }
                else
                {
                    var lang = cmbLang.SelectedItem.ToString();
                    FunctionalityService functionalityService = new FunctionalityService(txtFirstNumber.Text, txtSecondNumber.Text, lang);
                    // firstnumber, secondnumber FunctionalityService classýna nesne aracýlýðý ile gönderildi.
                    txtResult.Text = functionalityService.DivideProcess(); //üretilen nesneden MultiplyProcess metodu çaðrýldý.
                    lblStatus.Text = "Bölme Ýþlemi Baþarýlý.";
                }
            }
            catch (ArithmeticException exception)
            {
                Console.WriteLine(exception.StackTrace);
                MessageBox.Show("Int Max/Min deðeri aþýldý", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cmbLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LanguageText();
        }

        public void LanguageText()
        {
            if (cmbLang.SelectedIndex == 1)
            {
                txtFirstNumber.Clear();
                txtSecondNumber.Clear();
                txtResult.Clear();
                btnAdd.Text = "Add";
                btnSubtract.Text = "Subtract ";
                btnMultiply.Text = "Multiply";
                btnDivide.Text = "Divide";
                lblLangText.Text = "Current Language: "+"English";
                lblNumberone.Text = "First Number";
                lblNumbertwo.Text = "Second Number";
                grpResult.Text = "Result";
                grpLang.Text = "Language Selection";
                grpUser.Text = "User Input";
                lblNumberone.Location = new Point(44, 54);
                lblNumbertwo.Location = new Point(17, 99);
                txtFirstNumber.Location = new Point(164, 51);
                txtSecondNumber.Location = new Point(164, 96);
                //lblLangText.Location = new Point(17, 34);


            }
            else
            {
                txtFirstNumber.Clear();
                txtSecondNumber.Clear();
                txtResult.Clear();
                btnAdd.Text = "Topla";
                btnSubtract.Text = "Çýkar ";
                btnMultiply.Text = "Çarp ";
                btnDivide.Text = "Böl ";
                lblLangText.Text = "Geçerli Dil: "+"Türkçe";
                lblNumberone.Text = "Birinci Sayý";
                lblNumbertwo.Text = "Ýkinci Sayý";
                grpResult.Text = "Sonuç";
                grpLang.Text = "Dil Seçimi";
                grpUser.Text = "Kullanýcý Giriþi";
                lblNumberone.Location = new Point(52, 53);
                lblNumbertwo.Location = new Point(61, 98);
                txtFirstNumber.Location = new Point(155, 51);
                txtSecondNumber.Location = new Point(155, 96);
                //lblLangText.Location = new Point(71, 34);

            }
        }
    }
}