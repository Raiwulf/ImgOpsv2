using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using WindowsInput.Native;

namespace ImgOps
{
    public partial class StateManager : Form1
    {
        
        List<State> statesList = new List<State>();
        string statesPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps/States/";
        State currState = new State();
        Eye eye = new Eye();
        InputOps inputOps = new InputOps();
        //ENUMERATOR EKLE
        public void GetStates()//yakında dbden cekecek
        {
            string statesPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps/States/";
            statesList.Clear();
            Point target = new Point();
            statesList.AddRange(new List<State>{
            new State//proivder ekle oradan cagir
            (
                0,
                "Login",
                target
            ),
            new State
            (
                1,
                "ServerPick",
                target
            ),
            new State
            (
                2,
                "PostServer",
                target
            ),
            new State
            (
                3,
                "SubPassword1",
                target
            ),
            new State
            (
                4,
                "SubPassword2",
                target
            ),
            new State
            (
                5,
                "SubPassword3",
                target
            ),
            new State
            (
                6,
                "SubPassword4",
                target
            ),new State
            (
                7,
                "SubPassword5",
                target
            ),
            new State
            (
                8,
                "RunBot",
                target,
                "botPanel"
            ),
            new State
            (
                9,
                "RunBotPrompt",
                target
            ),
            new State
            (
                10,
                "ListenBot",
                target,
                "botPanel"
            ),
            new State
            (
                11,
                "ForceDC",
                target,
                "botPanel"
            ),
            new State
            (
                12,
                "Error",
                target
            )
        });
        }
        public void SetState(int stateId)
        {
            currState = statesList[stateId];
            currState.stateImg = (Bitmap)Image.FromFile(statesPath + currState.stateName + ".jpg");
            try
            {
                currState.target = eye.GetPixel(currState.panel, currState.stateImg);
            }
            catch (Exception)
            {
                if(currState.stateId == 2)
                {
                    Thread.Sleep(8000);
                    SetState(8);
                }
                else if (currState.stateId == 10)
                {
                    Thread.Sleep(60*1000);
                    SetState(10);
                }
                else
                {
                    notifyMe(currState.stateName);
                    Thread.Sleep(8000);
                    SetState(11);
                }
            }
            finally
            {
                StateOps(currState.stateId, currState.target, eye, inputOps);
            }
        }
        public void StateOps(int stateId, Point pixel, Eye eye, InputOps inputOps)
        {
            switch (stateId)
            {
                case 0://login
                    BringToFront();
                    inputOps.DoKey(VirtualKeyCode.RETURN);
                    inputOps.DoubleClick(pixel);
                    inputOps.DoClear();
                    inputOps.DoString(username);
                    inputOps.DoKey(VirtualKeyCode.TAB);
                    inputOps.DoClear();
                    inputOps.DoString("1999Ceren");
                    inputOps.DoKey(VirtualKeyCode.RETURN);
                    Thread.Sleep(2000);
                    SetState(1);
                    break;
                case 1://ServerPick
                    inputOps.DoubleClick(pixel);
                    Thread.Sleep(2000);
                    inputOps.DoKey(VirtualKeyCode.RETURN);
                    SetState(2);
                    break;
                case 2://postServerPick
                    Thread.Sleep(2000);
                    inputOps.DoHover(pixel);
                    inputOps.DoKey(VirtualKeyCode.RETURN);
                    SetState(3);
                    break;
                case 3://sub1
                    BringToFront();
                    inputOps.DoKey(VirtualKeyCode.RETURN);
                    Thread.Sleep(2000);
                    inputOps.DoClick(pixel);
                    SetState(4);
                    break;
                case 4://sub2
                    inputOps.DoClick(pixel);
                    SetState(5);
                    break;
                case 5://sub3
                    inputOps.DoClick(pixel);
                    SetState(6);
                    break;
                case 6://sub4
                    inputOps.DoClick(pixel);
                    SetState(7);
                    break;
                case 7://subOK
                    inputOps.DoClick(pixel);
                    Thread.Sleep(4000);
                    SetState(8);
                    break;
                case 8://RunBot
                    inputOps.DoClick(pixel);
                    Thread.Sleep(4000);
                    SetState(9);
                    break;
                case 9://RunBotPrompt
                    inputOps.DoClick(pixel);
                    Thread.Sleep(4000);
                    SetState(10);
                    break;
                case 10://ListenBot
                    inputOps.DoHover(pixel);
                    Thread.Sleep(2000);
                    SetState(11);
                    break;
                case 11://ForceDC
                    inputOps.DoClick(pixel);
                    Thread.Sleep(4000);
                    SetState(0);
                    break;
                case 12://error
                    AddLog("error");
                    break;
            }
        }
    }
}
