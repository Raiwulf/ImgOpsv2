using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ImgOps
{
    public partial class Form1 : Form
    {
        IFirebaseConfig fbase = new FirebaseConfig
        {
            AuthSecret = "T3BXwyrzk8JqYvXBJAKwrKikAWR9LaEgtHA9KWHl",
            BasePath = "https://dcbot-7b0eb-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        public static string username;
        public static string botName;
        public static string url;
        public static string content;

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        public void BringToFront()
        {
            Process p = Process.GetProcessesByName("CabalMain").FirstOrDefault();
            SetForegroundWindow(p.MainWindowHandle);
        }
        public Form1()
        {
            InitializeComponent();
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ImgOps"));
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps", "Captured"));
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps", "States"));
        }
        public void testButton_Click(object sender, EventArgs e)
        {
            notifyMe(" Hata ");
        }
        private void pHook_CheckedChanged(object sender, EventArgs e)
        {
            if (pHook.Checked == true)
            {
                username = charPicker();
                Thread a = new Thread(ExThread.thread1);
                a.Start();
            }
        }
        private void loadDb_Click(object sender, EventArgs e)
        {
            client = new FirebaseClient(fbase);
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            dgv.Columns.Add("PC", "PC");
            dgv.Columns.Add("CHAR1", "CHAR1");
            dgv.Columns.Add("CHAR2", "CHAR2");
            dgv.Columns.Add("CHAR3", "CHAR3");
            dgv.Columns.Add("HOOK", "HOOK");
            FirebaseResponse getData = client.Get(@"Computers");
            List<Computer> computers = new List<Computer>();
            computers = JsonConvert.DeserializeObject<List<Computer>>(getData.Body.ToString());
            foreach (var item in computers)
            {
                dgv.Rows.Add(item.PC, item.CHAR1, item.CHAR2, item.CHAR3, item.HOOK);
            }
        }
        public string charPicker()
        {
            long time = long.Parse(DateTime.Now.ToString("HHmm"));
            if (0200 <= time && time <= 1000)
            {
                username = dgv.SelectedCells[1].Value.ToString();
            }
            else if (1000 < time && time <= 1800)
            {
                username = dgv.SelectedCells[2].Value.ToString();
            }
            else
            {
                username = dgv.SelectedCells[3].Value.ToString();
            }
            return username;
        }
        public void AddLog(string text)
        {
            logBox.Items.Add("[" + DateTime.Now.ToString("dd/MM HH:mm:ss") + "]" + text);
        }
        public void notifyMe(string msg)
        {
            AddLog(msg);
            url = dgv.SelectedCells[0].Value.ToString();
            botName = dgv.SelectedCells[4].Value.ToString();
            content = logBox.Items[logBox.Items.Count - 1].ToString();
            log2Discord(url, botName, content);
        }
        public void log2Discord(string URL, string botName, string content)
        {
            WebClient wc = new WebClient();
            try
            {
                wc.UploadValues(URL, new System.Collections.Specialized.NameValueCollection
                {
                    {"content",content },
                    {"username",botName},
                });
            }
            catch (WebException ex)
            {
                AddLog(ex.ToString());
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 60 * 10;
            notifyMe("Last Event: ");
        }
    }
    public class ExThread
    {
        public static void thread1()
        {
            StateManager sm = new StateManager();
            sm.GetStates();
            sm.SetState(0);
        }
    }
}