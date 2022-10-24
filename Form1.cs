using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Reg;
using Emgu.CV.Structure;

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
            capturedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps/Captured/" + DateTime.Now.ToString("M_d_H_m_s") + ".jpg";
            #region Opencv

            #endregion
            #region Take Screenshot

            int screenLeft = SystemInformation.VirtualScreen.Left;
            int screenTop = SystemInformation.VirtualScreen.Top;
            int screenWidth = SystemInformation.VirtualScreen.Width;
            int screenHeight = SystemInformation.VirtualScreen.Height;

            // Create a bitmap of the appropriate size to receive the full-screen screenshot.
            using (Bitmap bitmap = new Bitmap(screenWidth, screenHeight))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(screenLeft, screenTop, 0, 0, bitmap.Size);
                    bitmap.Save(capturedPath);
                    Rectangle rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                    BitmapData bmpData = bitmap.LockBits(rectangle, ImageLockMode.ReadWrite, bitmap.PixelFormat);
                    Image<Gray, byte> bitmapArr = new Image<Gray, byte>(bitmap.Width, bitmap.Height, bmpData.Stride, bmpData.Scan0);

                    bitmapArr.Save(capturedPath);

                    using (Bitmap impMap = new Bitmap(importPicView.Image))
                    {
                        Image<Gray, byte> impFinal = impMap.ToImage<Gray, byte>();


                        Image<Gray, Byte> MaskDifferenceHigh = bitmapArr.Cmp(impFinal, CmpType.GreaterThan);
                        Image<Gray, Byte> MaskDifferenceLow = impFinal.Cmp(bitmapArr, CmpType.LessThan);

                        Image<Gray, byte> result = bitmapArr.CopyBlank();
                        result.SetValue(new Gray(1), MaskDifferenceHigh);
                        result.SetValue(new Gray(0.2), MaskDifferenceLow);
                        Bitmap resImage = result.ToBitmap();
                        resultBox.Image = resImage;
                    }


                }
                capturedView.Image = Image.FromFile(capturedPath);

            }

            #endregion

            #region Take SS specific app 

            //bringToFront(pName.Text);
            //Bitmap bitmapScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            //Graphics graphicsScreenshot = Graphics.FromImage(bitmapScreenshot);
            //graphicsScreenshot.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);

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
                bmp.Save(statesImg);
                Rectangle rectangle = new Rectangle(0, 0, bmp.Width, bmp.Height);
                BitmapData bmpData = bmp.LockBits(rectangle, ImageLockMode.ReadWrite, bmp.PixelFormat);
                Image<Bgr, byte> bitmapArr = new Image<Bgr, byte>(bmp.Width, bmp.Height, bmpData.Stride, bmpData.Scan0);
                bitmapArr.Save(statesImg);
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
                if(String.IsNullOrEmpty(importPicView.Image.ToString()))
                {

                    importPicView.Image = null;
                }
            }
            catch (Exception)
            {
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