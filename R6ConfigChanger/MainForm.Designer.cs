namespace R6ConfigChanger
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.SaveButton = new System.Windows.Forms.Button();
            this.labelDatacentre = new System.Windows.Forms.Label();
            this.SelectDatacentre = new System.Windows.Forms.ComboBox();
            this.lableAccount = new System.Windows.Forms.Label();
            this.UplayAccountName = new System.Windows.Forms.Label();
            this.SelectAccount = new System.Windows.Forms.ComboBox();
            this.ShowPATH = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(132, 195);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // labelDatacentre
            // 
            this.labelDatacentre.AutoSize = true;
            this.labelDatacentre.Location = new System.Drawing.Point(12, 93);
            this.labelDatacentre.Name = "labelDatacentre";
            this.labelDatacentre.Size = new System.Drawing.Size(63, 13);
            this.labelDatacentre.TabIndex = 1;
            this.labelDatacentre.Text = "Datacentre:";
            this.labelDatacentre.Click += new System.EventHandler(this.labelDatacentre_Click);
            // 
            // SelectDatacentre
            // 
            this.SelectDatacentre.FormattingEnabled = true;
            this.SelectDatacentre.Items.AddRange(new object[] {"default", "eus", "cus", "scus", "wus", "sbr", "neu", "weu", "eas", "seas", "eau", "wja"});
            this.SelectDatacentre.Location = new System.Drawing.Point(86, 90);
            this.SelectDatacentre.Name = "SelectDatacentre";
            this.SelectDatacentre.Size = new System.Drawing.Size(318, 21);
            this.SelectDatacentre.TabIndex = 2;
            // 
            // lableAccount
            // 
            this.lableAccount.AutoSize = true;
            this.lableAccount.Location = new System.Drawing.Point(12, 9);
            this.lableAccount.Name = "lableAccount";
            this.lableAccount.Size = new System.Drawing.Size(50, 13);
            this.lableAccount.TabIndex = 3;
            this.lableAccount.Text = "Account:";
            // 
            // UplayAccountName
            // 
            this.UplayAccountName.AutoSize = true;
            this.UplayAccountName.Location = new System.Drawing.Point(14, 61);
            this.UplayAccountName.Name = "UplayAccountName";
            this.UplayAccountName.Size = new System.Drawing.Size(61, 13);
            this.UplayAccountName.TabIndex = 4;
            this.UplayAccountName.Text = "no account";
            this.UplayAccountName.Click += new System.EventHandler(this.UplayAccountName_Click);
            // 
            // SelectAccount
            // 
            this.SelectAccount.FormattingEnabled = true;
            this.SelectAccount.Location = new System.Drawing.Point(86, 6);
            this.SelectAccount.Name = "SelectAccount";
            this.SelectAccount.Size = new System.Drawing.Size(318, 21);
            this.SelectAccount.TabIndex = 5;
            // 
            // ShowPATH
            // 
            this.ShowPATH.AutoSize = true;
            this.ShowPATH.Location = new System.Drawing.Point(12, 37);
            this.ShowPATH.Name = "ShowPATH";
            this.ShowPATH.Size = new System.Drawing.Size(35, 13);
            this.ShowPATH.TabIndex = 6;
            this.ShowPATH.Text = "label1";
            this.ShowPATH.Click += new System.EventHandler(this.ShowPATH_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Change UID Name";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 229);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowPATH);
            this.Controls.Add(this.SelectAccount);
            this.Controls.Add(this.UplayAccountName);
            this.Controls.Add(this.lableAccount);
            this.Controls.Add(this.SelectDatacentre);
            this.Controls.Add(this.labelDatacentre);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label labelDatacentre;
        private System.Windows.Forms.ComboBox SelectDatacentre;
        private System.Windows.Forms.Label lableAccount;
        public System.Windows.Forms.Label UplayAccountName;
        private System.Windows.Forms.ComboBox SelectAccount;
        private System.Windows.Forms.Label ShowPATH;
        private System.Windows.Forms.Button button1;
    }
}