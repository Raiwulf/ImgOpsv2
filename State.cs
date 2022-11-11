using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgOps
{
    public class State
    {//state manager 
        public State() { }

        public State(string stateName, Bitmap stateImg, string panel, bool isSet)
        {
            this.stateName = stateName;
            this.stateImg = stateImg;
            this.panel = panel;
            this.isSet = isSet;
        }
        public string stateName { get; set; }
        public string panel { get; set; }
        public Bitmap stateImg { get; set; }
        public bool isSet { get; set; }
    }
}
