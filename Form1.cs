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

        int screenLeft = SystemInformation.VirtualScreen.Left;
        int screenTop = SystemInformation.VirtualScreen.Top;
        int screenWidth = SystemInformation.VirtualScreen.Width;
        int screenHeight = SystemInformation.VirtualScreen.Height;

        string capturedPath;
        string statesPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps/States/";

        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(String lpClassName, String lpWindowName);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        public Form1()
        {
            InitializeComponent();
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ImgOps"));
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps", "Captured"));
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps", "States"));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void pHook_CheckedChanged(object sender, EventArgs e)
        {
            capturedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps/Captured/" + DateTime.Now.ToString("M_d_H_m_s") + ".jpg";
            
            #region Take Screenshot
            // Create a bitmap of the appropriate size to receive the full-screen screenshot.
            using (Bitmap bitmap = new Bitmap(screenWidth, screenHeight))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(screenLeft, screenTop, 0, 0, bitmap.Size);
                    bitmap.Save(capturedPath);
                }
                capturedView.Image = Image.FromFile(capturedPath);
            }
            Bitmap master = new Bitmap(capturedPath);
            Bitmap sub = new Bitmap(statesPath + statesList.SelectedItem.ToString() + ".jpg");

            var list = GetSubPositions(master, sub);
            foreach(var elements in list)
            {
                logBox.Items.Add(elements);
            }
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

        public static List<Point> GetSubPositions(Bitmap main, Bitmap sub)
        {
            Form1 frm1 = new Form1();
            List<Point> possiblepos = new List<Point>();

            int mainwidth = main.Width;
            int mainheight = main.Height;

            int subwidth = sub.Width;
            int subheight = sub.Height;

            int movewidth = mainwidth - subwidth;
            int moveheight = mainheight - subheight;

            BitmapData bmMainData = main.LockBits(new Rectangle(0, 0, mainwidth, mainheight), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            BitmapData bmSubData = sub.LockBits(new Rectangle(0, 0, subwidth, subheight), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            int bytesMain = Math.Abs(bmMainData.Stride) * mainheight;
            int strideMain = bmMainData.Stride;
            System.IntPtr Scan0Main = bmMainData.Scan0;
            byte[] dataMain = new byte[bytesMain];
            System.Runtime.InteropServices.Marshal.Copy(Scan0Main, dataMain, 0, bytesMain);

            int bytesSub = Math.Abs(bmSubData.Stride) * subheight;
            int strideSub = bmSubData.Stride;
            System.IntPtr Scan0Sub = bmSubData.Scan0;
            byte[] dataSub = new byte[bytesSub];
            System.Runtime.InteropServices.Marshal.Copy(Scan0Sub, dataSub, 0, bytesSub);


            for (int y = 0; y < moveheight; ++y)
            {
                for (int x = 0; x < movewidth; ++x)
                {
                    MyColor curcolor = GetColor(x, y, strideMain, dataMain);

                    MyColor subcolor = GetColor(x, y, strideSub, dataSub);


                    int screenLeft = SystemInformation.VirtualScreen.Left;
                    int screenTop = SystemInformation.VirtualScreen.Top;
                    int screenWidth = SystemInformation.VirtualScreen.Width;
                    int screenHeight = SystemInformation.VirtualScreen.Height;

                    //using (Bitmap master = new Bitmap(screenWidth, screenHeight))
                    //{
                    //    using (Graphics g = Graphics.FromImage(master))
                    //    {
                    //        g.CopyFromScreen(screenLeft, screenTop, 0, 0, master.Size);

                    //    }
                    //}


                    foreach (var item in possiblepos.ToArray())
                    {
                        int xsub = x - item.X;
                        int ysub = y - item.Y;
                        if (xsub >= subwidth || ysub >= subheight || xsub < 0)
                            continue;

                        if (!curcolor.Equals(subcolor))
                        {
                            possiblepos.Remove(item);
                        }
                    }

                    if (curcolor.Equals(GetColor(0, 0, strideSub, dataSub)))
                        possiblepos.Add(new Point(x, y));
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(dataSub, 0, Scan0Sub, bytesSub);
            sub.UnlockBits(bmSubData);

            System.Runtime.InteropServices.Marshal.Copy(dataMain, 0, Scan0Main, bytesMain);
            main.UnlockBits(bmMainData);

            return possiblepos;
        }

        private static MyColor GetColor(Point point, int stride, byte[] data)
        {
            return GetColor(point.X, point.Y, stride, data);
        }

        private static MyColor GetColor(int x, int y, int stride, byte[] data)
        {
            int pos = y * stride + x * 4;
            byte a = data[pos + 3];
            byte r = data[pos + 2];
            byte g = data[pos + 1];
            byte b = data[pos + 0];
            return MyColor.FromARGB(a, r, g, b);
        }

        struct MyColor
        {
            byte A;
            byte R;
            byte G;
            byte B;

            public static MyColor FromARGB(byte a, byte r, byte g, byte b)
            {
                MyColor mc = new MyColor();
                mc.A = a;
                mc.R = r;
                mc.G = g;
                mc.B = b;
                return mc;
            }

            public override bool Equals(object obj)
            {
                if (!(obj is MyColor))
                    return false;
                MyColor color = (MyColor)obj;
                if (color.A == this.A && color.R == this.R && color.G == this.G && color.B == this.B)
                    return true;
                return false;
            }
        }
    }
}