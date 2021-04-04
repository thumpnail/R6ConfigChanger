using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ini.Net;

namespace R6ConfigChanger {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            for (int i = 0; i < Program.PATH_UID.Length; i++) {
                SelectAccount.Items.Insert(i, Program.UIDs[i]);
            }
            ShowPATH.Text = Program.PATH;
            UplayAccountName.Text = "Click to update";
            if (SelectAccount.SelectedIndex == -1) { SelectAccount.SelectedIndex = 0; }
            if (SelectDatacentre.SelectedIndex == -1) { SelectDatacentre.SelectedIndex = 0; }
        }

        private void button1_Click(object sender, EventArgs e) {
            Console.WriteLine("Save Clicked");
        }

        private void ShowPATH_Click(object sender, EventArgs e) {
            Console.WriteLine("PATH");
        }

        private void labelDatacentre_Click(object sender, EventArgs e) {
            Console.WriteLine("Datacentre");
        }

        public void UplayAccountName_Click(object sender, EventArgs e) {
            var IniFile = new IniFile(Program.config_path);
            Console.WriteLine(SelectAccount.SelectedIndex);
            UplayAccountName.Text = IniFile.ReadString(SelectAccount.Text, "CustomName");
            if (UplayAccountName.Text.Equals(""))
                UplayAccountName.Text = "Nothing";
        }

        private void button1_Click_1(object sender, EventArgs e) {
            ChangeUIDname m = new ChangeUIDname();
            m.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            Console.WriteLine("Save Clicked");
            var IniFile = new IniFile(Program.PATH + "\\" + SelectAccount.Text + "\\GameSettings.ini");
            if (!(SelectDatacentre.SelectedIndex == -1)) {
                IniFile.WriteString("ONLINE", "DataCenterHint", SelectDatacentre.Text);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing) {
                Console.WriteLine("Exit");
                Program.threadRunning = false;
                Application.Exit();
            } else {
                Console.WriteLine("other Exit");
                Program.threadRunning = false;
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {
            
        }
    }
}
