
using AForge.Imaging;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Image = System.Drawing.Image;

namespace ImgOps
{
    public partial class Form1 : Form
    {
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

        private void pHook_CheckedChanged(object sender, EventArgs e)//timera çevir
        {
            bringToFront(pName.Text);
            capturedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps/Captured/" + DateTime.Now.ToString("M_d_H_m_s") + ".jpg";

            #region Take Screenshot
            // Create a bitmap of the appropriate size to receive the full-screen screenshot.

            using (Bitmap bitmap = new Bitmap(screenWidth, screenHeight))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    Bitmap grayed = new Bitmap(screenWidth, screenHeight);
                    g.CopyFromScreen(screenLeft, screenTop, 0, 0, bitmap.Size);
                    grayed = b2grayNformat(bitmap);
                    grayed.Save(capturedPath);
                }
                capturedView.Image = Image.FromFile(capturedPath);
            }

            Bitmap sourceImage = (Bitmap)Bitmap.FromFile(capturedPath);
            Bitmap template = (Bitmap)Bitmap.FromFile(statesPath + statesList.SelectedItem.ToString() + ".jpg");

            cigiScan(sourceImage, template);

            //foreach(var elements in list)
            //{
            //    logBox.Items.Add(elements);
            //}
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
        public void cigiScan(Bitmap sourceImage, Bitmap template)
        {
            // create template matching algorithm's instance
            // (set similarity threshold to 92.5%)

            ExhaustiveTemplateMatching tm = new ExhaustiveTemplateMatching(0.96f);
            // find all matchings with specified above similarity

            TemplateMatch[] matchings = tm.ProcessImage(sourceImage, template);
            // highlight found matchings

            BitmapData data = sourceImage.LockBits(
                 new Rectangle(0, 0, sourceImage.Width, sourceImage.Height),
                 ImageLockMode.ReadWrite, sourceImage.PixelFormat);
            foreach (TemplateMatch m in matchings)
            {

                Drawing.Rectangle(data, m.Rectangle, Color.White);

                matrixCheck.Text= (m.Rectangle.Location.ToString());
                // do something else with matching
            }
            sourceImage.UnlockBits(data);
        }
    }

}

