using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Ini.Net;
using WaitLib;


namespace R6ConfigChanger {
    class Program {
        public static readonly string PATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\Rainbow Six - Siege";
        public static string config_path = PATH + "\\R6S_config.ini";
        public static string[] PATH_UID = Directory.GetDirectories(PATH);
        public static string[] UIDs = new string[100];
        public static string[] tmp;
        public static bool threadRunning = true;

        static void Main(string[] args) {
            Console.WriteLine("Working dir: " + PATH);
            GetAllUserIds();
            if (!File.Exists(config_path)) {
                Console.WriteLine("Create Custom INI File");
                StreamWriter sw = new StreamWriter(config_path);
                for (int i = 0; i < PATH_UID.Length; i++) {
                    sw.WriteLine("["+UIDs[i]+"]");
                    sw.WriteLine("CustomName=");
                }
                sw.Close();
            }
            Console.WriteLine("Start Thread");
            //Thread t = new Thread(Thread);
            //t.Start();
            Console.WriteLine("Start Main Window");
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }

        public static void Thread() {
            Console.WriteLine("While is running");
            while (threadRunning) {
                Wait.waitMilsec(500);
                if (!threadRunning) {
                    break;
                }
            }
        }

        public static void TestLog() {
            Console.WriteLine("Test Log");
        }

        public static void GetAllUserIds() {
            int UID_Amount = PATH_UID.Length;
            
            for (int i = 0; i < PATH_UID.Length; i++) {
                Console.WriteLine(PATH_UID[i]);
            }

            for (int i = 0; i < UID_Amount; i++) {
                tmp = PATH_UID[i].Split(Path.DirectorySeparatorChar);
                UIDs[i] = tmp[5];
                Console.WriteLine("UserID " + (i + 1) + ": " + UIDs[i]);
            }
        }
    }
}
