using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLab1
{
    [Serializable]
    public abstract class RoomElement
    {
        public PointF Coordinates { get; set; }
        public int Rotation { get; set; }
        public string name;
        public List<PointF> path = new List<PointF>();

        public RoomElement(PointF coordinates)
        {
            this.Rotation = 0;
            this.Coordinates = coordinates;
        }

        public abstract void Draw(Graphics g);
        public abstract bool IsPointPartOf(Point p);
        public abstract void ChangeTransparency();
        public abstract double DistFromCenterOfGravity(Point p);
    }
}
