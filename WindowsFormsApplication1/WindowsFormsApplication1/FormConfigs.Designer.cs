namespace BOT
{
    partial class formConfigs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConfigs));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRetMax = new System.Windows.Forms.Label();
            this.txb_local = new System.Windows.Forms.TextBox();
            this.txb_medline = new System.Windows.Forms.TextBox();
            this.txb_delaydll = new System.Windows.Forms.TextBox();
            this.txb_retmax = new System.Windows.Forms.TextBox();
            this.bt_default = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medline:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Delay DLL:";
            // 
            // labelRetMax
            // 
            this.labelRetMax.AutoSize = true;
            this.labelRetMax.Location = new System.Drawing.Point(34, 188);
            this.labelRetMax.Name = "labelRetMax";
            this.labelRetMax.Size = new System.Drawing.Size(125, 13);
            this.labelRetMax.TabIndex = 8;
            this.labelRetMax.Text = "MedlinePlus Max Return:";
            // 
            // txb_local
            // 
            this.txb_local.Location = new System.Drawing.Point(77, 56);
            this.txb_local.Name = "txb_local";
            this.txb_local.Size = new System.Drawing.Size(277, 20);
            this.txb_local.TabIndex = 9;
            // 
            // txb_medline
            // 
            this.txb_medline.Location = new System.Drawing.Point(88, 93);
            this.txb_medline.Name = "txb_medline";
            this.txb_medline.Size = new System.Drawing.Size(266, 20);
            this.txb_medline.TabIndex = 10;
            // 
            // txb_delaydll
            // 
            this.txb_delaydll.Location = new System.Drawing.Point(101, 139);
            this.txb_delaydll.Name = "txb_delaydll";
            this.txb_delaydll.Size = new System.Drawing.Size(253, 20);
            this.txb_delaydll.TabIndex = 11;
            // 
            // txb_retmax
            // 
            this.txb_retmax.Location = new System.Drawing.Point(165, 188);
            this.txb_retmax.Name = "txb_retmax";
            this.txb_retmax.Size = new System.Drawing.Size(189, 20);
            this.txb_retmax.TabIndex = 12;
            // 
            // bt_default
            // 
            this.bt_default.Location = new System.Drawing.Point(165, 237);
            this.bt_default.Name = "bt_default";
            this.bt_default.Size = new System.Drawing.Size(75, 23);
            this.bt_default.TabIndex = 13;
            this.bt_default.Text = "Default";
            this.bt_default.UseVisualStyleBackColor = true;
            this.bt_default.Click += new System.EventHandler(this.bt_default_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(272, 237);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(82, 23);
            this.bt_ok.TabIndex = 14;
            this.bt_ok.Text = "Ok";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // formConfigs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 298);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.bt_default);
            this.Controls.Add(this.txb_retmax);
            this.Controls.Add(this.txb_delaydll);
            this.Controls.Add(this.txb_medline);
            this.Controls.Add(this.txb_local);
            this.Controls.Add(this.labelRetMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formConfigs";
            this.Text = "Configurations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRetMax;
        private System.Windows.Forms.TextBox txb_local;
        private System.Windows.Forms.TextBox txb_medline;
        private System.Windows.Forms.TextBox txb_delaydll;
        private System.Windows.Forms.TextBox txb_retmax;
        private System.Windows.Forms.Button bt_default;
        private System.Windows.Forms.Button bt_ok;
    }
}