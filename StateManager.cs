﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using WindowsInput.Native;

namespace ImgOps
{
    public class StateManager
    {
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        public void BringToFront()
        {
            Process p = Process.GetProcessesByName("CabalMain").FirstOrDefault();
            SetForegroundWindow(p.MainWindowHandle);
        }
        List<State> statesList = new List<State>();
        Form1 form = new Form1();
        int stopCount = 0;
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
                target
            ),
            new State
            (
                99,
                "Error",
                target
            )
        });
            State currState = statesList[0];
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
                SetState(currState.stateId - 1);
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
                    inputOps.DoString(Form1.username);
                    inputOps.DoKey(VirtualKeyCode.TAB);
                    inputOps.DoClear();
                    inputOps.DoString("1999Ceren");
                    inputOps.DoKey(VirtualKeyCode.RETURN);
                    Thread.Sleep(2000);
                    SetState(1);
                    break;
                case 1://ServerPick
                    try
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            inputOps.DoKey(VirtualKeyCode.DOWN);
                        }
                        Thread.Sleep(2000);
                        inputOps.DoKey(VirtualKeyCode.RETURN);
                        inputOps.DoKey(VirtualKeyCode.RETURN);
                        Thread.Sleep(2000);
                        inputOps.DoKey(VirtualKeyCode.RETURN);
                        SetState(2);
                    }
                    catch (Exception)
                    {
                        stopCount++;
                        if(stopCount == 3)
                        {
                            SetState(-1);
                        }
                    }
                    break;
                case 2://postServerPick
                    try
                    {
                        Thread.Sleep(2000);
                        inputOps.DoClick(pixel);
                        SetState(3);
                        break;
                    }
                    catch (Exception)
                    {
                        Thread.Sleep(2000);
                        inputOps.DoKey(VirtualKeyCode.RETURN);
                        SetState(8);
                        break;
                    }
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
                    SetState(8);
                    Thread.Sleep(8000);
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
                    try
                    {
                        inputOps.DoClick(pixel);
                        stopCount++;
                        if (stopCount == 2)
                        {
                            stopCount = 0;
                            SetState(11);
                        }
                        SetState(8);
                        Thread.Sleep(1000);
                    }
                    catch (Exception)
                    {
                        SetState(8);
                    }
                    break;
                case 11://ForceDC
                    inputOps.DoClick(pixel);
                    Thread.Sleep(4000);
                    SetState(0);
                    break;
                case 99://error
                    //form.AddLog("error");
                    break;
            }
        }
    }
}
