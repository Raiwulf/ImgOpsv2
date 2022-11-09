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
        string currState;
        string panel;
        
        Bitmap statesImg;
        List<String> states;
        public String SetPanel()
        {
            int screenWidth = SystemInformation.VirtualScreen.Width;
            Form1 form = new Form1();
            Capture capture = new Capture();// ilk parametre start, ikinci parametre width
            if (true)
            {
                Bitmap botPanel = capture.CapIt(0, 250, "botPanel");
                form.logBox.Items.Add(DateTime.Now.ToString("dd/MM HH:mm:ss") + " Captured botPanel");
                getMatch(botPanel, statesImg);
                panel= "botPanel";
            }
            else
            {
                Bitmap clientPanel = capture.CapIt(250, screenWidth - 250, "Client");
                form.logBox.Items.Add(DateTime.Now.ToString("dd/MM HH:mm:ss") + " Captured clientPanel");
                getMatch(clientPanel, statesImg);
                panel= "clientPanel";
            }
            return panel;
        }

        public void SetCurrentState(string state)
        {
            switch (state)
            {
                case "1_Login":

                    break;
                case "2_ServerPick":

                    break;
                case "3_CharacterPick":

                    break;
                case "4_SubPassword":

                    break;
                case "5_RunBot":

                    break;
                case "6_ListenBot":

                    break;
            }

            currState = null;
        }

        public void getMatch(Bitmap sourceImage, Bitmap template)
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
                // do something else with matching

                var a = (m.Rectangle.Location.ToString());
            }
            sourceImage.UnlockBits(data);
        }
    }
}
