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
                Bitmap botPanel = CaptureManager.CapIt(0, 250, 0, screenHeight, "botPanel");
                form.pictureBox2.Image = botPanel;
                Point pixel = GetMatch(botPanel, statesImg);
                return pixel;
            }
            else
            {
                Bitmap clientPanel = CaptureManager.CapIt(250, screenWidth - 250, 0, screenHeight, "Client");
                form.pictureBox2.Image = clientPanel;
                Point pixel = GetMatch(clientPanel, statesImg);
                pixel.X = pixel.X + 250;
                return pixel;
            }
        }
        public Point GetMatch(Bitmap sourceImage, Bitmap template)
        {
            ExhaustiveTemplateMatching tm = new ExhaustiveTemplateMatching(0.80f);
            TemplateMatch[] matchings = tm.ProcessImage(sourceImage, template);
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