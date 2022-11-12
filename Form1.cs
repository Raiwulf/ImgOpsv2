using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Image = System.Drawing.Image;

namespace ImgOps
{
    public partial class Form1 : Form
    {

        string statesPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps/States/";

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hWnd, ref RECT Rect);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int Width, int Height, bool Repaint);

        Eye eye = new Eye();
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

        public static IntPtr WinGetHandle(string wName)
        {
            foreach (Process pList in Process.GetProcesses())
                if (pList.MainWindowTitle.Contains(wName))
                    return pList.MainWindowHandle;

            return IntPtr.Zero;
        }

        private void pHook_CheckedChanged(object sender, EventArgs e)//timera çevir
        {
        }
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
        private void testButton_Click(object sender, EventArgs e)
        {
            StateManager stateManager = new StateManager();
            stateManager.GetStates();
            var currentState = stateManager.SetState(0);
            currentState.stateImg = (Bitmap)Image.FromFile(statesPath + currentState.stateName + ".jpg");
            processBox.Image = currentState.stateImg;
            logBox.Items.Add(currentState.stateName);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

