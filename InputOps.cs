using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace ImgOps
{
    public class InputOps
    {
        InputSimulator sim = new InputSimulator();
        public void DoClick(Point pixel)
        {
            Cursor.Position = pixel;
            sim.Mouse.LeftButtonClick();
            SleepOps();
        }
        public void DoubleClick(Point pixel)
        {
            Cursor.Position = pixel;
            sim.Mouse.LeftButtonDoubleClick();
            SleepOps();
        }
        public void DoString(String input)
        {
            sim.Keyboard.TextEntry(input);
            SleepOps();
        }
        public void DoKey(VirtualKeyCode key)
        {
            sim.Keyboard.KeyPress(key);
            SleepOps();
        }
        public void SleepOps()
        {
            sim.Keyboard.Sleep(16);
        }
        public void DoClear()
        {
            for (int i = 0; i < 32; i++)
            {
                DoKey(VirtualKeyCode.BACK);
                SleepOps();
            }
        }
    }
}
