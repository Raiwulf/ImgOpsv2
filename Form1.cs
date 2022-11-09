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
            eye.SetCurrentState("1_Login");
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
                Bitmap grayed = b2grayNformat(bmp);
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
            string statesPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps/States/";
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
        public static Bitmap b2grayNformat(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            using (Graphics g = Graphics.FromImage(newBitmap))
            {

                //create the grayscale ColorMatrix
                ColorMatrix colorMatrix = new ColorMatrix(
                   new float[][]
                   {
                     new float[] {.3f, .3f, .3f, 0, 0},
                     new float[] {.59f, .59f, .59f, 0, 0},
                     new float[] {.11f, .11f, .11f, 0, 0},
                     new float[] {0, 0, 0, 1, 0},
                     new float[] {0, 0, 0, 0, 1}
                   });

                //create some image attributes
                using (ImageAttributes attributes = new ImageAttributes())
                {

                    //set the color matrix attribute
                    attributes.SetColorMatrix(colorMatrix);

                    //draw the original image on the new image
                    //using the grayscale color matrix
                    g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
                                0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);
                }
            }
            Bitmap final = AForge.Imaging.Image.Clone(newBitmap, PixelFormat.Format24bppRgb);
            return final;
        }
        private void testButton_Click(object sender, EventArgs e)
        {
        }
    }

}

