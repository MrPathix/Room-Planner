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
    public class Furniture : RoomElement
    {
        [NonSerialized] public Bitmap Image;
        [NonSerialized] protected Bitmap semitranspImage;
        public Furniture(PointF coordinates, RoomDesigner roomDesigner, string name, int rotation = 0)
            : base(coordinates)
        {
            this.Image = roomDesigner.images[name];
            this.name = name;
            this.Rotation = rotation;

            Bitmap bmp = new Bitmap(Image.Width, Image.Height);

            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = 0.5f;

                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                gfx.DrawImage(Image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, Image.Width, Image.Height, GraphicsUnit.Pixel, attributes);

                semitranspImage = bmp;
            }
        }

        public override bool IsPointPartOf(Point p)
        {
            return ((p.X <= Coordinates.X + Image.Width) && (p.X >= Coordinates.X)
                && (p.Y <= Coordinates.Y + Image.Height) && (p.Y >= Coordinates.Y));
        }

        private Point GetMidPoint()
        {
            return new Point((int)(Coordinates.X + Math.Sqrt(2) * Image.Width / 2), (int)(Coordinates.Y + Math.Sqrt(2) * Image.Height / 2));
        }
        public override void ChangeTransparency()
        {
            Bitmap temp = Image;
            Image = semitranspImage;
            semitranspImage = temp;
        }
        public override double DistFromCenterOfGravity(Point p)
        {
            return Math.Sqrt(Math.Pow(Coordinates.X + Image.Width / 2 - p.X, 2) + Math.Pow(Coordinates.Y + Image.Height / 2 - p.Y, 2));
        }

        public override void Draw(Graphics g)
        {
            Bitmap bmp = new Bitmap((int)(Image.Width * Math.Sqrt(2)), (int)(Image.Height * Math.Sqrt(2)));

            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);
                gfx.RotateTransform(Rotation);
                gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);
                gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gfx.DrawImage(Image, new Point((bmp.Width - Image.Width) / 2, (bmp.Height - Image.Height) / 2));
            }

            g.DrawImage(bmp, Coordinates);
        }
        public override string ToString()
        {
            Point mid = GetMidPoint();
            return $"{name} - [X: {mid.X}, Y: {mid.Y}]";
        }
    }
}
