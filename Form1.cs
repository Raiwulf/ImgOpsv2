using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Image = System.Drawing.Image;
using System.Linq;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Collections.Generic;
using Newtonsoft.Json;
using FireSharp;

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
        List<String> listPC = new List<String>();
        FirebaseResponse response = null;
        public Form1()
        {
            InitializeComponent();
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ImgOps"));
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps", "Captured"));
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps", "States"));
        }
        private void testButton_Click(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(fbase);

            List<String> listData = new List<String>();
            FirebaseResponse response = null;
            var result = response.Body;
            if (client != null)
                MessageBox.Show("Established connection");
            //StateManager stateManager = new StateManager();
            //BringToFront();
            //stateManager.GetStates();
            //var cState = stateManager.SetState(0);
            //pictureBox1.Image = cState.stateImg;
            //int i = 16;
            //currentState.stateImg = (Bitmap)Image.FromFile(statesPath + currentState.stateName + ".jpg");
            //processBox.Image = currentState.stateImg;
            //logBox.Items.Add(currentState.stateName);

        }
        private void addPC_Click_1(object sender, EventArgs e)
        {
            Computer computer = new Computer()
            {
                PC = pcName.Text,
                CHAR1 = char1.Text,
                CHAR2 = char2.Text,
                CHAR3 = char3.Text,
                HOOK = webHook.Text
            };
            client = new FirebaseClient(fbase);
            var SetPC = client.Set("Computers/" + pcName.Text, computer);
        }
        private void pHook_CheckedChanged(object sender, EventArgs e)//timera çevir
        {
            StateManager stateManager = new StateManager();
            stateManager.GetStates();
            stateManager.SetState(0);
        }
        public void AddLog(string text)
        {
            logBox.Items.Add(DateTime.Now.ToString("dd/MM HH:mm:ss ") + text);
        }
        private void loadDb_Click(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(fbase);
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
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}