using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLab1
{
    [Serializable]
    public class RoomElementSet
    {
        public List<RoomElement> elements;

        public RoomElement this[int i]
        {
            get
            {
                return elements[i];
            }
        }
        public RoomElementSet(List<RoomElement> elements = null)
        {
            this.elements = elements ?? new List<RoomElement>();
        }

        public int GetClosestFurniture(Point point)
        {
            int index = -1, count = -1;
            double delta = double.PositiveInfinity;

            foreach (RoomElement f in elements)
            {
                count++;

                if (!f.IsPointPartOf(point)) continue;

                double dist = f.DistFromCenterOfGravity(point);

                if (dist < delta)
                {
                    delta = dist;
                    index = count;

                    if (dist == 0) break;
                }
            }

            return index;
        }

        public void Add(RoomElement element)
        {
            elements.Add(element);
        }

        public void Clear()
        {
            elements.Clear();
        }

        public int Find(RoomElement element)
        {
            return elements.IndexOf(element);
        }

        public void RemoveAt(int i)
        {
            elements.RemoveAt(i);
        }

        public void Draw(Graphics g)
        {
            foreach(RoomElement re in elements)
            {
                re.Draw(g);
            }
        }

    }
}
