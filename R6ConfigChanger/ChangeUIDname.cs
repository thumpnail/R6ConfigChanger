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
    public partial class ChangeUIDname : Form {
        public ChangeUIDname() {
            InitializeComponent();
            for (int i = 0; i < Program.PATH_UID.Length; i++) {
                SelectAccount.Items.Insert(i, Program.UIDs[i]);
            }
            if (SelectAccount.SelectedIndex == -1) { SelectAccount.SelectedIndex = 0; }
        }

        private void button1_Click/*Save Custom Data*/(object sender, EventArgs e) {
            if(!CustomName.Text.Equals("")) {
                var IniFile = new IniFile(Program.config_path);
                IniFile.WriteString(SelectAccount.Text, "CustomName", CustomName.Text);
            }
        }
    }
}
