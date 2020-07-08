using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLab1
{
    [Serializable]
    class Wall : RoomElement
    {
        [NonSerialized] protected int brushDensity = 8;
        [NonSerialized] public Pen pen;
        [NonSerialized] protected Pen transpPen;
        [NonSerialized] public GraphicsPath graphicsPath;
        public PointF Last { get; protected set; }
        public Wall(PointF coordinates, List<PointF> points = null)
            : base(coordinates) 
        {
            name = "Wall";
            graphicsPath = new GraphicsPath();
            pen = new Pen(Color.FromArgb(255, Color.Black), brushDensity);
            transpPen = new Pen(Color.FromArgb(128, Color.Black), brushDensity);

            if (points == null)
            {
                path.Add(coordinates);
                Last = coordinates;
            }
            else
            {
                path = points;
                graphicsPath.AddLines(path.ToArray());
            }
        }

        public override void ChangeTransparency()
        {
            Pen temp = pen;
            pen = transpPen;
            transpPen = temp;
        }

        public void AddPoint(Point p)
        {
            graphicsPath.AddLine(Last, p);
            Last = p;
            path.Add(p);
        }

        public override double DistFromCenterOfGravity(Point p)
        {
            if (IsPointPartOf(p)) return 0f;
            else return double.PositiveInfinity;
        }

        public override void Draw(Graphics g)
        {
            if (Rotation == 0)
            {
                g.DrawPath(pen, graphicsPath);
            }
            else
            {
                for(int i = 1; i < path.Count; i++)
                {
                    path[i] = path[i].RotatePoint(path.First(), Rotation);
                }

                Rotation = 0;
                graphicsPath.Reset();
                graphicsPath.AddLines(path.ToArray());
                g.DrawPath(pen, graphicsPath);
            }
        }

        // do poprawy
        public override bool IsPointPartOf(Point p)
        {
            for(int i = 0; i < path.Count - 1; i++)
            {
                double dist1 = path[i].Distance(p);
                double dist2 = path[i + 1].Distance(p);
                double absDist = path[i].Distance(path[i + 1]);

                if (dist1 + dist2 - absDist < brushDensity / 4) return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"Wall - [X: {path.First().X}, Y: {path.First().Y}]";
        }
    }
}
