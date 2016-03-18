namespace BOT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbt_me = new System.Windows.Forms.ToolStripButton();
            this.tsbt_dataAqu = new System.Windows.Forms.ToolStripButton();
            this.tsbt_medicaldic = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSbtConfigs = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tSBt_confirm = new System.Windows.Forms.ToolStripButton();
            this.tsLbl_welcome = new System.Windows.Forms.ToolStripLabel();
            this.panelDataAcquisition = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panelMe = new System.Windows.Forms.Panel();
            this.panelMedicalDictionary = new System.Windows.Forms.Panel();
            this.bt_procurar = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_sns = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_birthdate = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelDataAcquisition.SuspendLayout();
            this.panelMe.SuspendLayout();
            this.panelMedicalDictionary.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(4, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelMe);
            this.splitContainer1.Panel2.Controls.Add(this.panelDataAcquisition);
            this.splitContainer1.Panel2.Controls.Add(this.panelMedicalDictionary);
            this.splitContainer1.Panel2.Controls.Add(this.panelPrincipal);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(751, 493);
            this.splitContainer1.SplitterDistance = 105;
            this.splitContainer1.TabIndex = 2;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbt_me,
            this.tsbt_dataAqu,
            this.tsbt_medicaldic});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(105, 493);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbt_me
            // 
            this.tsbt_me.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbt_me.Image = ((System.Drawing.Image)(resources.GetObject("tsbt_me.Image")));
            this.tsbt_me.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbt_me.Name = "tsbt_me";
            this.tsbt_me.Size = new System.Drawing.Size(23, 20);
            this.tsbt_me.Text = "Me";
            this.tsbt_me.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbt_dataAqu
            // 
            this.tsbt_dataAqu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbt_dataAqu.Image = ((System.Drawing.Image)(resources.GetObject("tsbt_dataAqu.Image")));
            this.tsbt_dataAqu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbt_dataAqu.Name = "tsbt_dataAqu";
            this.tsbt_dataAqu.Size = new System.Drawing.Size(23, 20);
            this.tsbt_dataAqu.Text = "Data Acquisition";
            this.tsbt_dataAqu.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsbt_medicaldic
            // 
            this.tsbt_medicaldic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbt_medicaldic.Image = ((System.Drawing.Image)(resources.GetObject("tsbt_medicaldic.Image")));
            this.tsbt_medicaldic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbt_medicaldic.Name = "tsbt_medicaldic";
            this.tsbt_medicaldic.Size = new System.Drawing.Size(23, 20);
            this.tsbt_medicaldic.Text = "Medical Dictionary";
            this.tsbt_medicaldic.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSbtConfigs,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.tSBt_confirm,
            this.tsLbl_welcome});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(642, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSbtConfigs
            // 
            this.tSbtConfigs.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSbtConfigs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSbtConfigs.Image = ((System.Drawing.Image)(resources.GetObject("tSbtConfigs.Image")));
            this.tSbtConfigs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtConfigs.Name = "tSbtConfigs";
            this.tSbtConfigs.Size = new System.Drawing.Size(23, 22);
            this.tSbtConfigs.Text = "Configurations";
            this.tSbtConfigs.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel1.Text = "SNS:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // tSBt_confirm
            // 
            this.tSBt_confirm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSBt_confirm.Image = ((System.Drawing.Image)(resources.GetObject("tSBt_confirm.Image")));
            this.tSBt_confirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBt_confirm.Name = "tSBt_confirm";
            this.tSBt_confirm.Size = new System.Drawing.Size(23, 22);
            this.tSBt_confirm.Text = "Confirm";
            this.tSBt_confirm.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // tsLbl_welcome
            // 
            this.tsLbl_welcome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsLbl_welcome.Name = "tsLbl_welcome";
            this.tsLbl_welcome.Size = new System.Drawing.Size(0, 22);
            // 
            // panelDataAcquisition
            // 
            this.panelDataAcquisition.Controls.Add(this.textBox3);
            this.panelDataAcquisition.Controls.Add(this.textBox2);
            this.panelDataAcquisition.Controls.Add(this.textBox1);
            this.panelDataAcquisition.Controls.Add(this.label4);
            this.panelDataAcquisition.Controls.Add(this.label3);
            this.panelDataAcquisition.Controls.Add(this.label2);
            this.panelDataAcquisition.Controls.Add(this.label1);
            this.panelDataAcquisition.Controls.Add(this.checkedListBox1);
            this.panelDataAcquisition.Location = new System.Drawing.Point(0, 46);
            this.panelDataAcquisition.Name = "panelDataAcquisition";
            this.panelDataAcquisition.Size = new System.Drawing.Size(630, 413);
            this.panelDataAcquisition.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(463, 241);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 26);
            this.textBox3.TabIndex = 22;
            // 
            // panelMe
            // 
            this.panelMe.Controls.Add(this.lbl_age);
            this.panelMe.Controls.Add(this.lbl_sns);
            this.panelMe.Controls.Add(this.lbl_surname);
            this.panelMe.Controls.Add(this.lbl_birthdate);
            this.panelMe.Controls.Add(this.lbl_name);
            this.panelMe.Controls.Add(this.label9);
            this.panelMe.Controls.Add(this.label8);
            this.panelMe.Controls.Add(this.label7);
            this.panelMe.Controls.Add(this.label6);
            this.panelMe.Controls.Add(this.label5);
            this.panelMe.Location = new System.Drawing.Point(0, 31);
            this.panelMe.Name = "panelMe";
            this.panelMe.Size = new System.Drawing.Size(622, 425);
            this.panelMe.TabIndex = 24;
            // 
            // panelMedicalDictionary
            // 
            this.panelMedicalDictionary.Controls.Add(this.bt_procurar);
            this.panelMedicalDictionary.Controls.Add(this.textBox4);
            this.panelMedicalDictionary.Controls.Add(this.label10);
            this.panelMedicalDictionary.Controls.Add(this.listView1);
            this.panelMedicalDictionary.Location = new System.Drawing.Point(0, 49);
            this.panelMedicalDictionary.Name = "panelMedicalDictionary";
            this.panelMedicalDictionary.Size = new System.Drawing.Size(636, 190);
            this.panelMedicalDictionary.TabIndex = 0;
            // 
            // bt_procurar
            // 
            this.bt_procurar.Location = new System.Drawing.Point(280, 41);
            this.bt_procurar.Name = "bt_procurar";
            this.bt_procurar.Size = new System.Drawing.Size(75, 23);
            this.bt_procurar.TabIndex = 3;
            this.bt_procurar.Text = "Search";
            this.bt_procurar.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(53, 43);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(199, 20);
            this.textBox4.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Term:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(505, 301);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.pictureBox1);
            this.panelPrincipal.Controls.Add(this.label11);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 28);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(636, 434);
            this.panelPrincipal.TabIndex = 10;
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(49, 161);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(0, 13);
            this.lbl_age.TabIndex = 9;
            // 
            // lbl_sns
            // 
            this.lbl_sns.AutoSize = true;
            this.lbl_sns.Location = new System.Drawing.Point(301, 74);
            this.lbl_sns.Name = "lbl_sns";
            this.lbl_sns.Size = new System.Drawing.Size(0, 13);
            this.lbl_sns.TabIndex = 8;
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(318, 29);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(0, 13);
            this.lbl_surname.TabIndex = 7;
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Location = new System.Drawing.Point(69, 74);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.Size = new System.Drawing.Size(0, 13);
            this.lbl_birthdate.TabIndex = 6;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(58, 29);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 13);
            this.lbl_name.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Age:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "SNS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Birthdate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Surname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(463, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 26);
            this.textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(463, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 26);
            this.textBox1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Choices";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Heart Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Oxigen Saturation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Blood Pressure";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Blood Pressure",
            "Oxigen Saturation",
            "Heart Rate"});
            this.checkedListBox1.Location = new System.Drawing.Point(66, 78);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 64);
            this.checkedListBox1.TabIndex = 15;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(224, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 51);
            this.label11.TabIndex = 2;
            this.label11.Text = "Welcome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 281);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 497);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BOT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelDataAcquisition.ResumeLayout(false);
            this.panelDataAcquisition.PerformLayout();
            this.panelMe.ResumeLayout(false);
            this.panelMe.PerformLayout();
            this.panelMedicalDictionary.ResumeLayout(false);
            this.panelMedicalDictionary.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbt_me;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panelDataAcquisition;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ToolStripButton tsbt_dataAqu;
        private System.Windows.Forms.Panel panelMe;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_sns;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_birthdate;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton tsbt_medicaldic;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelMedicalDictionary;
        private System.Windows.Forms.Button bt_procurar;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripButton tSbtConfigs;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton tSBt_confirm;
        private System.Windows.Forms.ToolStripLabel tsLbl_welcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
    }
}

