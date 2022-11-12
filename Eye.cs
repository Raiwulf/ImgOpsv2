using AForge.Imaging;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Forms;

namespace ImgOps
{
    public class Eye
    {
        Bitmap statesImg;
        public void SetPanel(string panel)
        {
            int screenWidth = SystemInformation.VirtualScreen.Width;
            Form1 form = new Form1();;// ilk param: start, iki: param width, uc: panel
            if (panel == "botPanel")
            {
                Bitmap botPanel = CaptureManager.CapIt(0, 250, "botPanel");
                form.logBox.Items.Add(DateTime.Now.ToString("dd/MM HH:mm:ss") + " Captured botPanel");
                getMatch(botPanel, statesImg);
                panel= "botPanel";
            }
            else
            {
                Bitmap clientPanel = CaptureManager.CapIt(250, screenWidth - 250, "Client");
                form.logBox.Items.Add(DateTime.Now.ToString("dd/MM HH:mm:ss") + " Captured clientPanel");
                getMatch(clientPanel, statesImg);
                panel= "clientPanel";
            }
        }

        public Point getMatch(Bitmap sourceImage, Bitmap template)
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
            
            Drawing.Rectangle(data, matchings[0].Rectangle, Color.White);
            // do something else with matching
            Point center = new Point((matchings[0].Rectangle.Left + matchings[0].Rectangle.Right) / 2, (matchings[0].Rectangle.Top + matchings[0].Rectangle.Bottom) / 2);
            
            sourceImage.UnlockBits(data);

            return center;
        }
    }
}
