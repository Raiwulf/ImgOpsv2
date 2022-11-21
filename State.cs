using System.Drawing;

namespace ImgOps
{
    public class State
    {//state manager 
        public State() { }
        public State(int stateId, string stateName, Point target, string panel="clientPanel")
        {
            this.stateId = stateId;
            this.stateName = stateName;
            this.stateImg = null;
            this.target = target;
            this.panel = panel;
        }
        public int stateId { get; set; }
        public string stateName { get; set; }
        public string panel { get; set; }
        public Bitmap stateImg { get; set; }
        public Point target { get; set; }
    }
}
