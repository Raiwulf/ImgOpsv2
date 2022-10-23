using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ImgOps
{
    public partial class Form1 : Form
    {
        Process p;

        string capturedPath;
        string statesPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps/States/";

        [StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(String lpClassName, String lpWindowName);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        public Form1()
        {
            InitializeComponent();
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ImgOps"));
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+ "/ImgOps", "Captured"));
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps", "States"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void pHook_CheckedChanged(object sender, EventArgs e)
        {
            if (pHook.Checked)
            {
                timer1.Interval = Convert.ToInt32(scanInt.Text) * 1000;
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region Take Screenshot

            //int screenLeft = SystemInformation.VirtualScreen.Left;
            //int screenTop = SystemInformation.VirtualScreen.Top;
            //int screenWidth = SystemInformation.VirtualScreen.Width;
            //int screenHeight = SystemInformation.VirtualScreen.Height;

            //// Create a bitmap of the appropriate size to receive the full-screen screenshot.
            //using (Bitmap bitmap = new Bitmap(screenWidth, screenHeight))
            //{

            //    using (Graphics g = Graphics.FromImage(bitmap))
            //    {
            //        g.CopyFromScreen(screenLeft, screenTop, 0, 0, bitmap.Size);
            //    }

            //    //Save the screenshot as a Jpg image
            //    capturedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps/Captured/" + DateTime.Now.ToString("M_d_H_m_s") + ".jpg";
            //    try
            //    {
            //        Bitmap bmp = new Bitmap(bitmap);
            //        Bitmap grayed = bitmap2Grayscale(bmp, 1);
            //        grayed.Save(capturedPath);
            //        grayed.Dispose();
            //    }
            //    catch (Exception ex)
            //    {
            //    }
            //    capturedView.Image = Image.FromFile(capturedPath);
            //}

            #endregion
            #region Take SS specific app 
            bringToFront(pName.Text);
            Bitmap bitmapScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            Graphics graphicsScreenshot = Graphics.FromImage(bitmapScreenshot);
            var a = graphicsScreenshot.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
            capturedView.Image = a;
            #endregion
            #region Bitmap2Matrix
            //var stateMatrix = GetBitMapColorMatrix(statesPath + statesList.SelectedItem.ToString() + ".jpg");
            //var capturedMatrix = GetBitMapColorMatrix(capturedPath);
            //if(IsSubMatrix(capturedMatrix, stateMatrix))
            //{
            //    matrixCheck.Text = "Match!";
            //}
            //else
            //{
            //    matrixCheck.Text = "No Match!";
            //};

            #endregion


        }

        private void importPicButton_Click(object sender, EventArgs e)
        {

            try
            {
                importDialog.InitialDirectory = statesPath;
                importDialog.Title = "Insert the object image";
                importDialog.FileName = "";
                importDialog.Filter = "Images|*.jpg;*.jpeg;*.bmp;*.png";

                importDialog.ShowDialog();

                importPicView.Image = Image.FromFile(importDialog.FileName);
                //Bitmap bmp = new Bitmap(importPicView.Image);
                //Bitmap grayed = bitmap2Grayscale(bmp,1);
                //Image finalImage = (Image)grayed;
                //finalImage.Save(statesPath + statesList.SelectedItem.ToString() + ".jpg");
                //importPicView.Image = finalImage;
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
            if(removeDialog == DialogResult.Yes)
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
            }
            catch (Exception)
            {
                importPicView.Image = null;
                return;
            }
        }
        //public Color[][] GetBitMapColorMatrix(string bitmapFilePath)
        //{
        //    Bitmap b1 = new Bitmap(bitmapFilePath);

        //    int hight = b1.Height;
        //    int width = b1.Width;

        //    Color[][] colorMatrix = new Color[width][];
        //    for (int i = 0; i < width; i++)
        //    {
        //        colorMatrix[i] = new Color[hight];
        //        for (int j = 0; j < hight; j++)
        //        {
        //            colorMatrix[i][j] = b1.GetPixel(i, j);
        //        }
        //    }
        //    return colorMatrix;
        //}
        //private Bitmap bitmap2Grayscale(Bitmap img, int brightness)
        //{
        //    // Adjust brightness to be in range 0.0 - 1.0
        //    float bright = -1 * ((float)brightness / 255);

        //    // Average R, G, B values of all pixels
        //    float[][] colorTransMatrix =
        //    {
        //    new float[] {0.333F, 0.333F, 0.333F, 0.000F, 0.000F},
        //    new float[] {0.333F, 0.333F, 0.333F, 0.000F, 0.000F},
        //    new float[] {0.333F, 0.333F, 0.333F, 0.000F, 0.000F},
        //    new float[] {0.000F, 0.000F, 0.000F, 1.000F, 0.000F},
        //    new float[] {bright, bright, bright, 0.000F, 1.000F},
        //    };
        //    Bitmap grayImg = translateBitmap(img, colorTransMatrix);

        //    // Return the grayscale image
        //    return grayImg;
        //}
        //private Bitmap translateBitmap(Bitmap img, float[][] colorTranslationMatrix)
        //{
        //    // Setup color translation
        //    ColorMatrix colorMatrix = new ColorMatrix(colorTranslationMatrix);
        //    ImageAttributes imgAttr = new ImageAttributes();
        //    imgAttr.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

        //    // Draw the image with translated colors
        //    Bitmap trImg = new Bitmap(img.Width, img.Height);
        //    Graphics g = Graphics.FromImage(trImg);
        //    g.DrawImage(img, new Rectangle(0, 0, trImg.Width, trImg.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttr);

        //    // Return the translated image
        //    return trImg;
        //}
        private static bool IsSubMatrix(Color[][] a, Color[][] b)
        {
            for (int i = 0; i < a.Length - b.Length + 1; i++)
            {
                for (int j = 0; j < a[0].Length - b[0].Length + 1; j++)
                {
                    bool found = true;
                    for (int k = 0; k < b.Length; ++k)
                    {
                        for (int l = 0; l < b[0].Length; ++l)
                        {
                            if (a[i + k][j + l] != b[k][l])
                            {
                                found = false;
                                break;
                            }
                        }
                        if (!found) break;
                    }
                    if (found) return true;
                }
            }
            return false;
        }
        public static void bringToFront(string title)
        {
            // Get a handle to the Calculator application.
            IntPtr handle = FindWindow(null, title);

            // Verify that Calculator is a running process.
            if (handle == IntPtr.Zero)
            {
                return;
            }

            // Make Calculator the foreground application
            SetForegroundWindow(handle);
        }

    }
}