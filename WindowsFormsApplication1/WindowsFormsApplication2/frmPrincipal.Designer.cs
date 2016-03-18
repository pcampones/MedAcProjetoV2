namespace ClinicalAlert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add = new System.Windows.Forms.ToolStripButton();
            this.Edit = new System.Windows.Forms.ToolStripButton();
            this.Alerts = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.Reports = new System.Windows.Forms.ToolStripButton();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel_Adicionar = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.ativeCheckBox = new System.Windows.Forms.CheckBox();
            this.maleRb = new System.Windows.Forms.RadioButton();
            this.femaleRb = new System.Windows.Forms.RadioButton();
            this.txb_sns = new System.Windows.Forms.TextBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.txb_nextkindofcontact = new System.Windows.Forms.TextBox();
            this.txb_surname = new System.Windows.Forms.TextBox();
            this.dtp_utente = new System.Windows.Forms.DateTimePicker();
            this.txb_morada = new System.Windows.Forms.TextBox();
            this.txb_bi = new System.Windows.Forms.TextBox();
            this.txb_phone = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.rtxb_alergies = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel_Adicionar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelPrincipal);
            this.splitContainer1.Panel2.Controls.Add(this.panel_Adicionar);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer1.Size = new System.Drawing.Size(716, 435);
            this.splitContainer1.SplitterDistance = 137;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add,
            this.Edit,
            this.Alerts,
            this.toolStripButton3,
            this.Reports});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(137, 435);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // Add
            // 
            this.Add.AutoSize = false;
            this.Add.AutoToolTip = false;
            this.Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(140, 50);
            this.Add.Text = "Add";
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.AutoSize = false;
            this.Edit.AutoToolTip = false;
            this.Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(140, 50);
            this.Edit.Text = "Edit";
            // 
            // Alerts
            // 
            this.Alerts.AutoSize = false;
            this.Alerts.AutoToolTip = false;
            this.Alerts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Alerts.Image = ((System.Drawing.Image)(resources.GetObject("Alerts.Image")));
            this.Alerts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Alerts.Name = "Alerts";
            this.Alerts.Size = new System.Drawing.Size(140, 50);
            this.Alerts.Text = "Alerts";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.AutoToolTip = false;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(140, 50);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // Reports
            // 
            this.Reports.AutoSize = false;
            this.Reports.AutoToolTip = false;
            this.Reports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Reports.Image = ((System.Drawing.Image)(resources.GetObject("Reports.Image")));
            this.Reports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(140, 50);
            this.Reports.Text = "Reports";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Location = new System.Drawing.Point(537, 413);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(35, 22);
            this.panelPrincipal.TabIndex = 41;
            // 
            // panel_Adicionar
            // 
            this.panel_Adicionar.Controls.Add(this.groupBox1);
            this.panel_Adicionar.Location = new System.Drawing.Point(11, 29);
            this.panel_Adicionar.Name = "panel_Adicionar";
            this.panel_Adicionar.Size = new System.Drawing.Size(552, 394);
            this.panel_Adicionar.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ativeCheckBox);
            this.groupBox1.Controls.Add(this.maleRb);
            this.groupBox1.Controls.Add(this.femaleRb);
            this.groupBox1.Controls.Add(this.txb_sns);
            this.groupBox1.Controls.Add(this.txb_email);
            this.groupBox1.Controls.Add(this.txb_nextkindofcontact);
            this.groupBox1.Controls.Add(this.txb_surname);
            this.groupBox1.Controls.Add(this.dtp_utente);
            this.groupBox1.Controls.Add(this.txb_morada);
            this.groupBox1.Controls.Add(this.txb_bi);
            this.groupBox1.Controls.Add(this.txb_phone);
            this.groupBox1.Controls.Add(this.txb_name);
            this.groupBox1.Controls.Add(this.rtxb_alergies);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 388);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Patient";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(314, 216);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(59, 217);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Regist";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ativeCheckBox
            // 
            this.ativeCheckBox.AutoSize = true;
            this.ativeCheckBox.Location = new System.Drawing.Point(439, 268);
            this.ativeCheckBox.Name = "ativeCheckBox";
            this.ativeCheckBox.Size = new System.Drawing.Size(50, 17);
            this.ativeCheckBox.TabIndex = 15;
            this.ativeCheckBox.Text = "Ative";
            this.ativeCheckBox.UseVisualStyleBackColor = true;
            this.ativeCheckBox.CheckedChanged += new System.EventHandler(this.ativeCheckBox_CheckedChanged);
            // 
            // maleRb
            // 
            this.maleRb.AutoSize = true;
            this.maleRb.Location = new System.Drawing.Point(314, 178);
            this.maleRb.Name = "maleRb";
            this.maleRb.Size = new System.Drawing.Size(48, 17);
            this.maleRb.TabIndex = 10;
            this.maleRb.TabStop = true;
            this.maleRb.Text = "Male";
            this.maleRb.UseVisualStyleBackColor = true;
            this.maleRb.CheckedChanged += new System.EventHandler(this.maleRb_CheckedChanged);
            // 
            // femaleRb
            // 
            this.femaleRb.AutoSize = true;
            this.femaleRb.Location = new System.Drawing.Point(385, 177);
            this.femaleRb.Name = "femaleRb";
            this.femaleRb.Size = new System.Drawing.Size(59, 17);
            this.femaleRb.TabIndex = 11;
            this.femaleRb.TabStop = true;
            this.femaleRb.Text = "Female";
            this.femaleRb.UseVisualStyleBackColor = true;
            this.femaleRb.CheckedChanged += new System.EventHandler(this.femaleRb_CheckedChanged);
            // 
            // txb_sns
            // 
            this.txb_sns.Location = new System.Drawing.Point(314, 141);
            this.txb_sns.Name = "txb_sns";
            this.txb_sns.Size = new System.Drawing.Size(172, 20);
            this.txb_sns.TabIndex = 8;
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(314, 103);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(172, 20);
            this.txb_email.TabIndex = 6;
            // 
            // txb_nextkindofcontact
            // 
            this.txb_nextkindofcontact.Location = new System.Drawing.Point(362, 69);
            this.txb_nextkindofcontact.Name = "txb_nextkindofcontact";
            this.txb_nextkindofcontact.Size = new System.Drawing.Size(142, 20);
            this.txb_nextkindofcontact.TabIndex = 4;
            // 
            // txb_surname
            // 
            this.txb_surname.Location = new System.Drawing.Point(314, 27);
            this.txb_surname.Name = "txb_surname";
            this.txb_surname.Size = new System.Drawing.Size(190, 20);
            this.txb_surname.TabIndex = 2;
            // 
            // dtp_utente
            // 
            this.dtp_utente.Location = new System.Drawing.Point(61, 104);
            this.dtp_utente.Name = "dtp_utente";
            this.dtp_utente.Size = new System.Drawing.Size(172, 20);
            this.dtp_utente.TabIndex = 5;
            // 
            // txb_morada
            // 
            this.txb_morada.Location = new System.Drawing.Point(60, 179);
            this.txb_morada.Name = "txb_morada";
            this.txb_morada.Size = new System.Drawing.Size(173, 20);
            this.txb_morada.TabIndex = 9;
            // 
            // txb_bi
            // 
            this.txb_bi.Location = new System.Drawing.Point(60, 141);
            this.txb_bi.Name = "txb_bi";
            this.txb_bi.Size = new System.Drawing.Size(173, 20);
            this.txb_bi.TabIndex = 7;
            // 
            // txb_phone
            // 
            this.txb_phone.Location = new System.Drawing.Point(61, 69);
            this.txb_phone.Name = "txb_phone";
            this.txb_phone.Size = new System.Drawing.Size(172, 20);
            this.txb_phone.TabIndex = 3;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(61, 27);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(172, 20);
            this.txb_name.TabIndex = 1;
            this.txb_name.TextChanged += new System.EventHandler(this.txb_name_TextChanged);
            this.txb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_name_KeyPress);
            // 
            // rtxb_alergies
            // 
            this.rtxb_alergies.Location = new System.Drawing.Point(59, 272);
            this.rtxb_alergies.Name = "rtxb_alergies";
            this.rtxb_alergies.Size = new System.Drawing.Size(359, 110);
            this.rtxb_alergies.TabIndex = 14;
            this.rtxb_alergies.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Weigth:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(247, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Next of kin contact:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(247, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Height:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Alergies:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Gender:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "SNS:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "BI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Birthdate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name:";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(575, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "Alertas";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 435);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmPrincipal";
            this.Text = "Clinical Alert";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel_Adicionar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Add;
        private System.Windows.Forms.ToolStripButton Edit;
        private System.Windows.Forms.ToolStripButton Alerts;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton Reports;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel panel_Adicionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxb_alergies;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_sns;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.TextBox txb_nextkindofcontact;
        private System.Windows.Forms.TextBox txb_surname;
        private System.Windows.Forms.DateTimePicker dtp_utente;
        private System.Windows.Forms.TextBox txb_morada;
        private System.Windows.Forms.TextBox txb_bi;
        private System.Windows.Forms.TextBox txb_phone;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.RadioButton maleRb;
        private System.Windows.Forms.RadioButton femaleRb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ativeCheckBox;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

