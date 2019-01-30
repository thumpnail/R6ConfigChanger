namespace R6ConfigChanger {
    partial class ChangeUIDname {
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
            this.GivenUID = new System.Windows.Forms.Label();
            this.SelectAccount = new System.Windows.Forms.ComboBox();
            this.CustomNameLable = new System.Windows.Forms.Label();
            this.CustomName = new System.Windows.Forms.TextBox();
            this.SaveCustomData = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GivenUID
            // 
            this.GivenUID.AutoSize = true;
            this.GivenUID.Location = new System.Drawing.Point(12, 9);
            this.GivenUID.Name = "GivenUID";
            this.GivenUID.Size = new System.Drawing.Size(26, 13);
            this.GivenUID.TabIndex = 0;
            this.GivenUID.Text = "UID";
            // 
            // SelectAccount
            // 
            this.SelectAccount.FormattingEnabled = true;
            this.SelectAccount.Location = new System.Drawing.Point(12, 25);
            this.SelectAccount.Name = "SelectAccount";
            this.SelectAccount.Size = new System.Drawing.Size(386, 21);
            this.SelectAccount.TabIndex = 1;
            // 
            // CustomNameLable
            // 
            this.CustomNameLable.AutoSize = true;
            this.CustomNameLable.Location = new System.Drawing.Point(12, 49);
            this.CustomNameLable.Name = "CustomNameLable";
            this.CustomNameLable.Size = new System.Drawing.Size(35, 13);
            this.CustomNameLable.TabIndex = 2;
            this.CustomNameLable.Text = "Name";
            // 
            // CustomName
            // 
            this.CustomName.Location = new System.Drawing.Point(12, 65);
            this.CustomName.Name = "CustomName";
            this.CustomName.Size = new System.Drawing.Size(386, 20);
            this.CustomName.TabIndex = 3;
            // 
            // SaveCustomData
            // 
            this.SaveCustomData.Location = new System.Drawing.Point(323, 91);
            this.SaveCustomData.Name = "SaveCustomData";
            this.SaveCustomData.Size = new System.Drawing.Size(75, 23);
            this.SaveCustomData.TabIndex = 4;
            this.SaveCustomData.Text = "Save";
            this.SaveCustomData.UseVisualStyleBackColor = true;
            this.SaveCustomData.Click += new System.EventHandler(this.button1_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(12, 96);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 5;
            this.Status.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "nothing to say";
            // 
            // ChangeUIDname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 123);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.SaveCustomData);
            this.Controls.Add(this.CustomName);
            this.Controls.Add(this.CustomNameLable);
            this.Controls.Add(this.SelectAccount);
            this.Controls.Add(this.GivenUID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeUIDname";
            this.Text = "ChangeUIDname";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GivenUID;
        private System.Windows.Forms.ComboBox SelectAccount;
        private System.Windows.Forms.Label CustomNameLable;
        private System.Windows.Forms.TextBox CustomName;
        private System.Windows.Forms.Button SaveCustomData;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label label4;
    }
}