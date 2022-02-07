namespace AssignmentWork
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 27);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(145, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 27);
            this.textBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Birinci Sayı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "İkinci Sayı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sonuç";
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(24, 190);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(94, 29);
            this.btnTopla.TabIndex = 6;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(124, 190);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(94, 29);
            this.btnCikar.TabIndex = 7;
            this.btnCikar.Text = "Çıkar";
            this.btnCikar.UseVisualStyleBackColor = true;
            // 
            // btnCarp
            // 
            this.btnCarp.Location = new System.Drawing.Point(224, 190);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(94, 29);
            this.btnCarp.TabIndex = 8;
            this.btnCarp.Text = "Çarp";
            this.btnCarp.UseVisualStyleBackColor = true;
            // 
            // btnBol
            // 
            this.btnBol.Location = new System.Drawing.Point(324, 190);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(94, 29);
            this.btnBol.TabIndex = 9;
            this.btnBol.Text = "Böl";
            this.btnBol.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBol);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnCarp);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.btnCikar);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.btnTopla);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(7, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 292);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 294);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assigment";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnTopla;
        private Button btnCikar;
        private Button btnCarp;
        private Button btnBol;
        private GroupBox groupBox1;
    }
}