using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgOps
{
    public partial class LayoutForm : Form
    {
        public LayoutForm()
        {
            InitializeComponent();
            this.TopMost = true;
            this.Opacity= 0.32;
        }
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        const int GWL_EXSTYLE = -20;
        const int WS_EX_LAYERED = 0x80000;
        const int WS_EX_TRANSPARENT = 0x20;

        private void onLoad(object sender, EventArgs e)
        {
            var style = GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, style | WS_EX_LAYERED | WS_EX_TRANSPARENT);
            this.Location= new Point(0,0);
            this.Size= new Size(1024,768);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
