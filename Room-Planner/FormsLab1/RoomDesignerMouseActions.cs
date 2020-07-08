using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLab1
{
    partial class RoomDesigner
    {
        private void LeftMouseDown(object sender, MouseEventArgs e)
        {
            buttonHeldDown = e.Location;
            leftPanelPictureBox.MouseMove += MouseMoveWithLeftMouseButtonDown;
        }

        private void LeftMouseUp(object sender, MouseEventArgs e)
        {
            leftPanelPictureBox.MouseMove -= MouseMoveWithLeftMouseButtonDown;
        }

        private void MouseMoveWithLeftMouseButtonDown(object sender, MouseEventArgs e)
        {
            if (clickedElement is Furniture && clickedElement.IsPointPartOf(e.Location)) //  moving furnitures
            {
                (clickedElement as Furniture).Coordinates = new PointF(
                    (float)(e.X - Math.Sqrt(2) * (clickedElement as Furniture).Image.Width / 2), 
                    (float)(e.Y - Math.Sqrt(2) * (clickedElement as Furniture).Image.Height / 2));

                leftPanelPictureBox.Refresh();
                createdElementsListView.Items[roomElementSet.Find(clickedElement)].Text = clickedElement.ToString();
            }
            else if (clickedElement as Wall != null && clickedElement.IsPointPartOf(e.Location)) //  moving walls
            {
                Wall wall = clickedElement as Wall;
                int dx = e.X - buttonHeldDown.X;
                int dy = e.Y - buttonHeldDown.Y;

                List<PointF> path = wall.path;

                for (int i = 0; i < path.Count; i++)
                {
                    PointF p = path[i];
                    p.X += dx;
                    p.Y += dy;

                    path[i] = p;
                }

                wall.graphicsPath.Reset();
                wall.graphicsPath.AddLines(path.ToArray());
                buttonHeldDown = e.Location;

                int index = roomElementSet.Find(wall);
                createdElementsListView.Items[index].Text = wall.ToString();

                leftPanelPictureBox.Refresh();
            }
        }
        private void MouseMoveWithWallInCreation(object sender, MouseEventArgs e)
        {
            cursor = e.Location;
            leftPanelPictureBox?.Refresh();
        }

        private void MouseWheelHandler(object sender, MouseEventArgs e)
        {
            if (clickedElement == null) return;
            else
            {
                clickedElement.Rotation += e.Delta / 24;
                leftPanelPictureBox.Refresh();
            }
        }
        void MouseWheelHandlerWhenElementPicked(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void BitmapClicked(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // obsługa LPM
            {
                LeftMouseButtonHandler(e);
            }
            else if (e.Button == MouseButtons.Right) // obsługa PPM
            {
                RightMouseButtonHandler();
            }
        }

        private void RightMouseButtonHandler()
        {
            if (wallInCreation != null)
            {
                if (wallInCreation.path.Count == 1)
                {
                    int index = roomElementSet.Find(wallInCreation);
                    roomElementSet.RemoveAt(index);
                    createdElementsListView.Items.RemoveAt(index);
                }
                wallInCreation = null;
                leftPanelPictureBox.MouseMove -= MouseMoveWithWallInCreation;
                leftPanelPictureBox.Refresh();
            }
        }

        private void LeftMouseButtonHandler(MouseEventArgs e)
        {
            if (clickedButton == null) // guzik niewciśnięty
            {
                if (wallInCreation == null) // nie tworzymy ściany - sprawdzamy czy kliknięto rysunek
                {
                    CheckIfAnyRoomElementClicked(e);
                }
                else // ściana jest tworzona - robimy ją dalej
                {
                    wallInCreation.AddPoint(e.Location);
                    leftPanelPictureBox.Refresh();
                }
            }
            else  // guzik wciśnięty - tworzymy nowy mebelek w lokalizacji kliknięcia
            {
                CreateNewRoomElement(e);
            }
        }

        private void UnclickClickedRoomElement()
        {
            if (clickedElement != null) // jeśli jakiś rysunek był już kliknięty, odklikujemy go
            {
                int i = roomElementSet.Find(clickedElement);

                if (i != -1) // rozwiązanie buga przy wczytywaniu pliku kiedy element zaznaczony
                {
                    clickedElement.ChangeTransparency();
                    leftPanelPictureBox.Refresh();

                    createdElementsListView.Items[i].Focused = false;
                    createdElementsListView.Items[i].Selected = false;
                }
            }
            clickedElement = null;
        }

        private void CheckIfAnyRoomElementClicked(MouseEventArgs e)
        {
            int index = roomElementSet.GetClosestFurniture(e.Location);

            if (index == -1) // nie kliknięto rysunku
            {
                leftPanelPictureBox.MouseWheel -= MouseWheelHandlerWhenElementPicked;

                UnclickClickedRoomElement();
            }
            else // kliknięto rysunek
            {
                UnclickClickedRoomElement();

                leftPanelPictureBox.MouseWheel += MouseWheelHandlerWhenElementPicked;

                clickedElement = roomElementSet[index];
                clickedElement.ChangeTransparency();

                createdElementsListView.Items[index].Focused = true;
                createdElementsListView.Items[index].Selected = true;

                leftPanelPictureBox.Refresh();
            }
        }

        private void CreateNewRoomElement(MouseEventArgs e)
        {
            if (clickedButton != Wall) // rysowanie zwykłych mebli
            {
                Point p = new Point((int)(e.X - Math.Sqrt(2) * clickedButton.BackgroundImage.Width / 2), (int)(e.Y - Math.Sqrt(2) * clickedButton.BackgroundImage.Height / 2));

                RoomElement furniture = new Furniture(p, this, clickedButton.Name);

                roomElementSet.Add(furniture);
                createdElementsListView.Items.Add(furniture.ToString());

                leftPanelPictureBox.Refresh();
                ButtonUnclick();
            }
            else // rysowanie ścian
            {
                if (wallInCreation == null)
                {
                    wallInCreation = new Wall(e.Location);
                    roomElementSet.Add(wallInCreation);
                    createdElementsListView.Items.Add(wallInCreation.ToString());
                    leftPanelPictureBox.MouseMove += MouseMoveWithWallInCreation;
                }

                leftPanelPictureBox.Refresh();
                ButtonUnclick();
            }
        }
    }
}
