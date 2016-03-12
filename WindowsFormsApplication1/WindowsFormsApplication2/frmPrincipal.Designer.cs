namespace WindowsFormsApplication2
{
    partial class frmPrincipal
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.txb_sobrenome = new System.Windows.Forms.TextBox();
            this.txb_morada = new System.Windows.Forms.TextBox();
            this.txb_SNS = new System.Windows.Forms.TextBox();
            this.txb_BI = new System.Windows.Forms.TextBox();
            this.dtP_Nascimento = new System.Windows.Forms.DateTimePicker();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txb_pContato = new System.Windows.Forms.TextBox();
            this.txb_phone = new System.Windows.Forms.TextBox();
            this.rich_alergies = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(122, 435);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 72);
            this.button1.TabIndex = 1;
            this.button1.Text = "Registration";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Birthdate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "BI:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "SNS:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(380, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Gender:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(153, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Alergies:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(153, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Height:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(380, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Weight:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(153, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Next of kin contact:";
            // 
            // txb_nome
            // 
            this.txb_nome.Location = new System.Drawing.Point(207, 75);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(159, 20);
            this.txb_nome.TabIndex = 1;
            // 
            // txb_sobrenome
            // 
            this.txb_sobrenome.Location = new System.Drawing.Point(439, 74);
            this.txb_sobrenome.Name = "txb_sobrenome";
            this.txb_sobrenome.Size = new System.Drawing.Size(193, 20);
            this.txb_sobrenome.TabIndex = 2;
            // 
            // txb_morada
            // 
            this.txb_morada.Location = new System.Drawing.Point(207, 106);
            this.txb_morada.Name = "txb_morada";
            this.txb_morada.Size = new System.Drawing.Size(159, 20);
            this.txb_morada.TabIndex = 3;
            // 
            // txb_SNS
            // 
            this.txb_SNS.Location = new System.Drawing.Point(207, 141);
            this.txb_SNS.MaxLength = 9;
            this.txb_SNS.Name = "txb_SNS";
            this.txb_SNS.Size = new System.Drawing.Size(159, 20);
            this.txb_SNS.TabIndex = 5;
            // 
            // txb_BI
            // 
            this.txb_BI.Location = new System.Drawing.Point(207, 170);
            this.txb_BI.MaxLength = 9;
            this.txb_BI.Name = "txb_BI";
            this.txb_BI.Size = new System.Drawing.Size(159, 20);
            this.txb_BI.TabIndex = 7;
            // 
            // dtP_Nascimento
            // 
            this.dtP_Nascimento.Location = new System.Drawing.Point(439, 109);
            this.dtP_Nascimento.Name = "dtP_Nascimento";
            this.dtP_Nascimento.Size = new System.Drawing.Size(194, 20);
            this.dtP_Nascimento.TabIndex = 4;
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(439, 145);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(194, 20);
            this.txb_email.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(380, 254);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Ative :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(439, 254);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Ative";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(439, 184);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 25;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(530, 184);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 26;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txb_pContato
            // 
            this.txb_pContato.Location = new System.Drawing.Point(266, 247);
            this.txb_pContato.Name = "txb_pContato";
            this.txb_pContato.Size = new System.Drawing.Size(100, 20);
            this.txb_pContato.TabIndex = 27;
            // 
            // txb_phone
            // 
            this.txb_phone.Location = new System.Drawing.Point(207, 273);
            this.txb_phone.Name = "txb_phone";
            this.txb_phone.Size = new System.Drawing.Size(159, 20);
            this.txb_phone.TabIndex = 28;
            // 
            // rich_alergies
            // 
            this.rich_alergies.Location = new System.Drawing.Point(207, 311);
            this.rich_alergies.Name = "rich_alergies";
            this.rich_alergies.Size = new System.Drawing.Size(425, 68);
            this.rich_alergies.TabIndex = 29;
            this.rich_alergies.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(557, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(207, 208);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(159, 20);
            this.numericUpDown1.TabIndex = 31;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(439, 207);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(193, 20);
            this.numericUpDown2.TabIndex = 32;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 435);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rich_alergies);
            this.Controls.Add(this.txb_phone);
            this.Controls.Add(this.txb_pContato);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.dtP_Nascimento);
            this.Controls.Add(this.txb_BI);
            this.Controls.Add(this.txb_SNS);
            this.Controls.Add(this.txb_morada);
            this.Controls.Add(this.txb_sobrenome);
            this.Controls.Add(this.txb_nome);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitter1);
            this.Name = "frmPrincipal";
            this.Text = "Clinical Alert";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.TextBox txb_sobrenome;
        private System.Windows.Forms.TextBox txb_morada;
        private System.Windows.Forms.TextBox txb_SNS;
        private System.Windows.Forms.TextBox txb_BI;
        private System.Windows.Forms.DateTimePicker dtP_Nascimento;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txb_pContato;
        private System.Windows.Forms.TextBox txb_phone;
        private System.Windows.Forms.RichTextBox rich_alergies;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

