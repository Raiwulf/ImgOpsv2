using AForge.Imaging;
using System;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;

namespace ImgOps
{
    public class Eye
    {
        public Point GetPixel(string panel, Bitmap statesImg)
        {
            int screenWidth = SystemInformation.VirtualScreen.Width;
            int screenHeight = SystemInformation.VirtualScreen.Height;
            Form1 form = new Form1(); ;// ilk param: start, iki: param width, uc: panel
            if (panel == "botPanel")
            {
                Bitmap botPanel = CaptureManager.CapIt(0, 250, 0, 85, "botPanel");
                form.AddLog("Captured botPanel");
                form.pictureBox2.Image = botPanel;
                Point pixel = GetMatch(botPanel, statesImg);
                return pixel;
            }
            else
            {
                Bitmap clientPanel = CaptureManager.CapIt(250, screenWidth - 250, 0, screenHeight, "Client");
                form.AddLog("Captured clientPanel");
                form.pictureBox2.Image = clientPanel;
                Point pixel = GetMatch(clientPanel, statesImg);
                pixel.X = pixel.X + 250;
                return pixel;
            }
        }

        public Point GetMatch(Bitmap sourceImage, Bitmap template)
        {
            // create template matching algorithm's instance
            // (set similarity threshold to 92.5%)

            ExhaustiveTemplateMatching tm = new ExhaustiveTemplateMatching(0.80f);
            // find all matchings with specified above similarity
            TemplateMatch[] matchings = tm.ProcessImage(sourceImage, template);
            // highlight found matchings

            BitmapData data = sourceImage.LockBits(
                 new Rectangle(0, 0, sourceImage.Width, sourceImage.Height),
                 ImageLockMode.ReadWrite, sourceImage.PixelFormat);

            Drawing.Rectangle(data, matchings[0].Rectangle, Color.White);
            // do something else with matching
            Point center = new Point((matchings[0].Rectangle.Left + matchings[0].Rectangle.Right) / 2, (matchings[0].Rectangle.Top + matchings[0].Rectangle.Bottom) / 2);
            sourceImage.UnlockBits(data);

            return center;
        }
    }
}
