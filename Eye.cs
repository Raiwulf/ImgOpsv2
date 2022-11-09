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
        string currentState;
        string panel;

        Bitmap kek;

        Bitmap statesImg;
        public void SetPanel(string panel)
        {
            int screenWidth = SystemInformation.VirtualScreen.Width;
            Form1 form = new Form1();
            Capture capture = new Capture();// ilk param: start, iki: param width, uc: panel
            if (panel== "botPanel")
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
        }

        public void SetCurrentState(string state)
        {
            switch (state)
            {
                case "1_Login":
                    State state1 = new State
                    {
                        stateName = "1_Login",
                        stateImg = kek,
                        panel = "clientPanel",
                        isSet = true
                    };
                    SetPanel(panel);
                    currentState = state1.stateName;
                    break;

                case "2_ServerPick":
                    State state2 = new State
                    {
                        stateName = "2_ServerPick",
                        stateImg = kek,
                        panel = "clientPanel",
                        isSet = true
                    };
                    SetPanel(panel);
                    currentState = state2.stateName;
                    break;

                case "3_CharacterPick":
                    State state3 = new State
                    {
                        stateName = "3_CharacterPick",
                        stateImg = kek,
                        panel = "clientPanel",
                        isSet = true
                    };
                    SetPanel(panel);
                    currentState = state3.stateName;
                    break;

                case "4_SubPassword":
                    State state4 = new State
                    {
                        stateName = "4_SubPassword",
                        stateImg = kek,
                        panel = "clientPanel",
                        isSet = true
                    };
                    SetPanel(panel);
                    currentState = state4.stateName;
                    break;

                case "5_RunBot":
                    State state5 = new State
                    {
                        stateName = "5_RunBot",
                        stateImg = kek,
                        panel = "clientPanel",
                        isSet = true
                    };
                    SetPanel(panel);
                    currentState = state5.stateName;
                    break;

                case "6_ListenBot":
                    State state6 = new State
                    {
                        stateName = "6_ListenBot",
                        stateImg = kek,
                        panel = "botPanel",
                        isSet = true
                    };
                    SetPanel(panel);
                    currentState = state6.stateName;
                    break;
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
