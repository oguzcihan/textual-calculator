namespace AssignmentProject
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNumbertwo = new System.Windows.Forms.Label();
            this.lblNumberone = new System.Windows.Forms.Label();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lblLangText = new System.Windows.Forms.Label();
            this.cmbLang = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.grpLang = new System.Windows.Forms.GroupBox();
            this.grpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grpUser.SuspendLayout();
            this.grpLang.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDivide.FlatAppearance.BorderSize = 0;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(454, 162);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(94, 39);
            this.btnDivide.TabIndex = 21;
            this.btnDivide.Text = "Böl";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.Location = new System.Drawing.Point(332, 162);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(94, 39);
            this.btnMultiply.TabIndex = 20;
            this.btnMultiply.Text = "Çarp";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubtract.FlatAppearance.BorderSize = 0;
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtract.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubtract.Location = new System.Drawing.Point(218, 162);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(94, 39);
            this.btnSubtract.TabIndex = 19;
            this.btnSubtract.Text = "Çıkar";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(99, 162);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 39);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Topla";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(85, 61);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(483, 30);
            this.txtResult.TabIndex = 17;
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSecondNumber.Location = new System.Drawing.Point(213, 96);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(315, 30);
            this.txtSecondNumber.TabIndex = 16;
            this.txtSecondNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecondNumber_KeyPress);
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstNumber.Location = new System.Drawing.Point(213, 51);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(315, 30);
            this.txtFirstNumber.TabIndex = 15;
            this.txtFirstNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstNumber_KeyPress);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblStatus.Location = new System.Drawing.Point(85, 26);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(483, 23);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "---";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumbertwo
            // 
            this.lblNumbertwo.AutoSize = true;
            this.lblNumbertwo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumbertwo.Location = new System.Drawing.Point(117, 98);
            this.lblNumbertwo.Name = "lblNumbertwo";
            this.lblNumbertwo.Size = new System.Drawing.Size(95, 25);
            this.lblNumbertwo.TabIndex = 12;
            this.lblNumbertwo.Text = "İkinci Sayı";
            // 
            // lblNumberone
            // 
            this.lblNumberone.AutoSize = true;
            this.lblNumberone.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumberone.Location = new System.Drawing.Point(108, 53);
            this.lblNumberone.Name = "lblNumberone";
            this.lblNumberone.Size = new System.Drawing.Size(104, 25);
            this.lblNumberone.TabIndex = 11;
            this.lblNumberone.Text = "Birinci Sayı";
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.lblStatus);
            this.grpResult.Controls.Add(this.txtResult);
            this.grpResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpResult.Location = new System.Drawing.Point(12, 305);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(634, 113);
            this.grpResult.TabIndex = 22;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Sonuç";
            // 
            // lblLangText
            // 
            this.lblLangText.AutoSize = true;
            this.lblLangText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLangText.Location = new System.Drawing.Point(68, 23);
            this.lblLangText.Name = "lblLangText";
            this.lblLangText.Size = new System.Drawing.Size(134, 20);
            this.lblLangText.TabIndex = 23;
            this.lblLangText.Text = "Geçerli Dil: Türkçe";
            this.lblLangText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbLang
            // 
            this.cmbLang.BackColor = System.Drawing.SystemColors.Window;
            this.cmbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLang.FormattingEnabled = true;
            this.cmbLang.Items.AddRange(new object[] {
            "Türkçe",
            "English"});
            this.cmbLang.Location = new System.Drawing.Point(450, 15);
            this.cmbLang.Name = "cmbLang";
            this.cmbLang.Size = new System.Drawing.Size(118, 28);
            this.cmbLang.TabIndex = 22;
            this.cmbLang.SelectedIndexChanged += new System.EventHandler(this.cmbLang_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.btnDivide);
            this.grpUser.Controls.Add(this.txtFirstNumber);
            this.grpUser.Controls.Add(this.txtSecondNumber);
            this.grpUser.Controls.Add(this.lblNumbertwo);
            this.grpUser.Controls.Add(this.btnMultiply);
            this.grpUser.Controls.Add(this.lblNumberone);
            this.grpUser.Controls.Add(this.btnSubtract);
            this.grpUser.Controls.Add(this.btnAdd);
            this.grpUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpUser.Location = new System.Drawing.Point(12, 71);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(634, 228);
            this.grpUser.TabIndex = 23;
            this.grpUser.TabStop = false;
            this.grpUser.Text = "Kullanıcı Girişi";
            // 
            // grpLang
            // 
            this.grpLang.Controls.Add(this.cmbLang);
            this.grpLang.Controls.Add(this.lblLangText);
            this.grpLang.Location = new System.Drawing.Point(12, 8);
            this.grpLang.Name = "grpLang";
            this.grpLang.Size = new System.Drawing.Size(634, 57);
            this.grpLang.TabIndex = 24;
            this.grpLang.TabStop = false;
            this.grpLang.Text = "Dil Seçimi";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.grpLang);
            this.Controls.Add(this.grpUser);
            this.Controls.Add(this.grpResult);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grpUser.ResumeLayout(false);
            this.grpUser.PerformLayout();
            this.grpLang.ResumeLayout(false);
            this.grpLang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDivide;
        private Button btnMultiply;
        private Button btnSubtract;
        private Button btnAdd;
        private TextBox txtResult;
        private TextBox txtSecondNumber;
        private TextBox txtFirstNumber;
        private Label lblStatus;
        private Label lblNumbertwo;
        private Label lblNumberone;
        private GroupBox grpResult;
        private ErrorProvider errorProvider1;
        private ComboBox cmbLang;
        private Label lblLangText;
        private GroupBox grpLang;
        private GroupBox grpUser;
    }
}