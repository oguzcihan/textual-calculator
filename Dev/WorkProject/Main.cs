namespace WorkProject
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

        private void btnTopla_Click(object sender, EventArgs e)
        {
            //textbox kontrol
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
                FunctionalityService functionalityService = new FunctionalityService(txtFirstNumber.Text,txtSecondNumber.Text);
                txtResult.Text= functionalityService.addProcess();
                lblStatus.Text = "Toplama Ýþlemi Baþarýlý.";
            }

        }

        
        private void btnCikar_Click(object sender, EventArgs e)
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
                FunctionalityService functionalityService = new FunctionalityService(txtFirstNumber.Text, txtSecondNumber.Text);
                txtResult.Text= functionalityService.subtractProcess();
                lblStatus.Text = "Çýkarma Ýþlemi Baþarýlý.";
            }

        }

       

        private void Main_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }

        private void btnCarp_Click(object sender, EventArgs e)
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
                FunctionalityService functionalityService = new FunctionalityService(txtFirstNumber.Text, txtSecondNumber.Text);
                txtResult.Text=functionalityService.multiplyProcess();
                lblStatus.Text = "Çarpma Ýþlemi Baþarýlý.";
            }

        }

        

        private void btnBol_Click(object sender, EventArgs e)
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

                FunctionalityService functionalityService = new FunctionalityService(txtFirstNumber.Text, txtSecondNumber.Text);
                txtResult.Text = functionalityService.divideProcess();
                lblStatus.Text = "Bölme Ýþlemi Baþarýlý.";
            }

        }

      

    }
}