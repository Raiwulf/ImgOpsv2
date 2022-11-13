using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using WindowsInput.Native;

namespace ImgOps
{
    public class StateManager
    {
        List<State> statesList = new List<State>();
        Form1 form = new Form1();
        int stopCount = 0;
        string statesPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps/States/";
        State currState = new State();
        Eye eye = new Eye();
        InputOps inputOps = new InputOps();
        string username ;
        string password ;
        public void GetStates()//yakında dbden cekecek
        {
            string statesPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ImgOps/States/";
            statesList.Clear();
            Point target = new Point();
            statesList.AddRange(new List<State>{
            new State
            (
                0,
                "Login",
                null,
                target,
                "clientPanel",
                false
            ),
            new State
            (
                1,
                "ServerPick",
                null,
                target,
                "clientPanel",
                false
            ),
            new State
            (
                2,
                "PostServer",
                null,
                target,
                "clientPanel",
                false
            ),
            new State
            (
                3,
                "SubPassword1",
                null,
                target,
                "clientPanel",
                false
            ),
            new State
            (
                4,
                "SubPassword2",
                null,
                target,
                "clientPanel",
                false
            ),
            new State
            (
                5,
                "SubPassword3",
                null,
                target,
                "clientPanel",
                false
            ),
            new State
            (
                6,
                "SubPassword4",
                null,
                target,
                "clientPanel",
                false
            ),new State
            (
                7,
                "SubPassword5",
                null,
                target,
                "clientPanel",
                false
            ),
            new State
            (
                8,
                "RunBot",
                null,
                target,
                "botPanel",
                false
            ),
            new State
            (
                9,
                "RunBotPrompt",
                null,
                target,
                "clientPanel",
                false
            ),
            new State
            (
                10,
                "ListenBot",
                null,
                target,
                "botPanel",
                false
            ),
            new State
            (
                11,
                "ListenGame",
                null,
                target,
                "clientPanel",
                false
            ),
            new State
            (
                -1,
                "Error",
                null,
                target,
                null,
                false
            )
        });
        }
        public State SetState(int stateId)
        {
            currState = statesList[stateId];
            currState.stateImg = (Bitmap)Image.FromFile(statesPath + currState.stateName + ".jpg");
            try
            {
                currState.target = eye.GetPixel(currState.panel, currState.stateImg);
                StateOps(currState.stateId, currState.target, eye, inputOps);
                return statesList[stateId];
            }
            catch (Exception)
            {
                SetState(currState.stateId-1);
                return statesList[currState.stateId - 1];
            }
        }

        public void StateOps(int stateId, Point pixel, Eye eye, InputOps inputOps)
        {
            switch (stateId)
            {
                case -1://error
                    form.AddLog("error");
                    break;
                case 0://login
                    inputOps.DoKey(VirtualKeyCode.RETURN);
                    inputOps.DoubleClick(pixel);
                    inputOps.DoClear();
                    inputOps.DoString("cabaleski000");
                    inputOps.DoKey(VirtualKeyCode.TAB);
                    inputOps.DoClear();
                    inputOps.DoString("1999Ceren");
                    inputOps.DoKey(VirtualKeyCode.RETURN);
                    Thread.Sleep(8000);
                    SetState(1);
                    break;
                case 1://ServerPick
                    inputOps.DoubleClick(pixel);
                    Thread.Sleep(8000);
                    SetState(2);
                    break;
                case 2://postServerPick
                    inputOps.DoKey(VirtualKeyCode.RETURN);
                    try
                    {
                        inputOps.DoClick(pixel);
                        SetState(8);
                        break;
                    }
                    catch (Exception)
                    {
                        SetState(3);
                        break;
                    } 
                case 3://sub1
                    inputOps.DoKey(VirtualKeyCode.RETURN);
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
                    inputOps.DoubleClick(pixel);
                    SetState(8);
                    break;
                case 8://RunBot
                    inputOps.DoubleClick(pixel);
                    Thread.Sleep(2000);
                    SetState(9);
                    break;
                case 9://RunBotPrompt
                    inputOps.DoubleClick(pixel);
                    SetState(10);
                    break;
                case 10://ListenBot
                    try
                    {
                        inputOps.DoClick(pixel);
                        stopCount++;
                        if (stopCount == 2)
                        {
                            form.AddLog("Retry Count: " + stopCount.ToString());
                            SetState(1);
                            stopCount = 0;
                        }
                        SetState(8);
                        Thread.Sleep(1000);
                        break;
                    }
                    catch (Exception)
                    {
                        SetState(10);
                        break;
                    }
            }
        }
    }
}
