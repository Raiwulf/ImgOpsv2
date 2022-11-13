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

        public State(int stateId, string stateName, Bitmap stateImg, Point target, string panel, bool isSet)
        {
            this.stateId = stateId;
            this.stateName = stateName;
            this.stateImg = stateImg;
            this.target = target;
            this.panel = panel;
            this.isSet = isSet;
        }
        public int stateId { get; set; }
        public string stateName { get; set; }
        public string panel { get; set; }
        public Bitmap stateImg { get; set; }
        public Point target { get; set; }
        public bool isSet { get; set; }
    }
}
