using AssignmentProject.Services;

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
            //numara giriþine kapatýldý
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
            cmbLang.SelectedIndex = 0; //Geçerli dil Türkçe
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Textbox kontrol
            //Toplama iþlemi butonu
            try
            {
                if (txtFirstNumber.Text == "" && txtSecondNumber.Text == "")
                {
                    //Textbox'lar boþ olma durumu hata gönderildi
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
                    errorProvider1.Clear();
                    var lang = cmbLang.SelectedItem.ToString(); //dil seçimi deðiþkene atandý
                    FunctionalityService functionalityService = new FunctionalityService(txtFirstNumber.Text, txtSecondNumber.Text, lang);
                    // firstnumber, secondnumber FunctionalityService classýna nesne aracýlýðý ile gönderildi.
                    txtResult.Text = functionalityService.AddProcess(); //üretilen nesneden AddProcess metodu çaðrýldý.
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
                    errorProvider1.Clear();
                    var lang = cmbLang.SelectedItem.ToString();
                    FunctionalityService functionalityService = new FunctionalityService(txtFirstNumber.Text, txtSecondNumber.Text, lang);
                    // firstnumber, secondnumber FunctionalityService classýna nesne aracýlýðý ile gönderildi.
                    txtResult.Text = functionalityService.SubtractProcess(); //üretilen nesneden SubtractProcess metodu çaðrýldý.
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
                    errorProvider1.Clear();
                   var lang = cmbLang.SelectedItem.ToString();
                    FunctionalityService functionalityService = new FunctionalityService(txtFirstNumber.Text, txtSecondNumber.Text, lang);
                    // firstnumber, secondnumber FunctionalityService classýna nesne aracýlýðý ile gönderildi.
                    txtResult.Text = functionalityService.MultiplyProcess(); //üretilen nesneden MultiplyProcess metodu çaðrýldý.
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
                    errorProvider1.Clear();
                    var lang = cmbLang.SelectedItem.ToString();
                    FunctionalityService functionalityService = new FunctionalityService(txtFirstNumber.Text, txtSecondNumber.Text, lang);
                    // firstnumber, secondnumber FunctionalityService classýna nesne aracýlýðý ile gönderildi.
                    txtResult.Text = functionalityService.DivideProcess(); //üretilen nesneden MultiplyProcess metodu çaðrýldý.
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
                lblNumberone.Location = new Point(94, 52);
                lblNumbertwo.Location = new Point(67, 98);
                txtFirstNumber.Location = new Point(213, 51);
                txtSecondNumber.Location = new Point(213, 96);


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
                lblNumberone.Location = new Point(108, 53);
                lblNumbertwo.Location = new Point(117, 98);
                txtFirstNumber.Location = new Point(213, 51);
                txtSecondNumber.Location = new Point(213, 96);

            }
        }
    }
}