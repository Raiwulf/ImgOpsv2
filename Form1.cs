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
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        private void BringToFront()
        {
            Process p = Process.GetProcessesByName("CabalMain").First();
            SetForegroundWindow(p.MainWindowHandle);
        }
        string statesPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps/States/";
        public Form1()
        {
            InitializeComponent();
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ImgOps"));
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps", "Captured"));
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps", "States"));


        }

        //private void pHook_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (pHook.Checked)
        //    {
        //        timer1.Interval = Convert.ToInt32(scanInt.Text) * 1000;
        //        timer1.Start();
        //    }
        //    else
        //    {
        //        timer1.Stop();
        //    }
        //}
        private void importPicButton_Click(object sender, EventArgs e)
        {

            string statesPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps/States/";
            string statesImg = statesPath + statesList.SelectedItem.ToString() + ".jpg";
            try
            {
                importDialog.InitialDirectory = statesPath;
                importDialog.Title = "Insert the object image";
                importDialog.FileName = "";
                importDialog.Filter = "Images|*.jpg;*.jpeg;*.bmp;*.png";

                importDialog.ShowDialog();

                importPicView.Image = Image.FromFile(importDialog.FileName);
                Bitmap bmp = new Bitmap(importPicView.Image);
                Bitmap grayed = CaptureManager.b2grayNformat(bmp);
                grayed.Save(statesImg);
            }
            catch (Exception)
            {
                return;
            }
        }
        private void removeStateButton_Click(object sender, EventArgs e)
        {
            DialogResult removeDialog = new DialogResult();
            removeDialog = MessageBox.Show("Do you want to remove the selected state?", "Remove", MessageBoxButtons.YesNo);
            if (removeDialog == DialogResult.Yes)
            {
                statesList.Items.Remove(statesList.SelectedItem);
            }
        }
        private void addStateButton_Click(object sender, EventArgs e)
        {
            statesList.Items.Add(addStateName.Text, false);
        }
        private void statesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                importPicView.Image = Image.FromFile(statesPath + statesList.SelectedItem.ToString() + ".jpg");
                if (String.IsNullOrEmpty(importPicView.Image.ToString()))
                {
                    importPicView.Image = null;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        public void AddLog(string text)
        {
            logBox.Items.Add(DateTime.Now.ToString("dd/MM HH:mm:ss ") + text);
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
            var SetPC = client.Set("Computers/"+pcName.Text, computer);
        }
        private void pHook_CheckedChanged(object sender, EventArgs e)//timera çevir
        {
            client = new FireSharp.FirebaseClient(fbase);
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("PC", "PC");
            dataGridView1.Columns.Add("CHAR1", "CHAR1");
            dataGridView1.Columns.Add("CHAR2", "CHAR2");
            dataGridView1.Columns.Add("CHAR3", "CHAR3");
            dataGridView1.Columns.Add("HOOK", "HOOK");
            FirebaseResponse getData = client.Get(@"Computers");
            List<Computer> computers = new List<Computer>();
            computers = JsonConvert.DeserializeObject<List<Computer>>(getData.Body.ToString());
            foreach (var item in computers)
            {
                dataGridView1.Rows.Add(item.PC,item.CHAR1,item.CHAR2,item.CHAR3,item.HOOK);
            }
        }
    }

}

