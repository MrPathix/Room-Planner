using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLab1
{
    public partial class RoomDesigner : Form
    {
        PictureBox leftPanelPictureBox;
        Button clickedButton = null;
        readonly RoomElementSet roomElementSet = new RoomElementSet();
        Wall wallInCreation = null;
        RoomElement clickedElement = null;
        public Dictionary<string, Bitmap> images = new Dictionary<string, Bitmap>();
        Point cursor;
        Point buttonHeldDown;

        public RoomDesigner()
        {
            InitializeComponent();
            SetButtons();
            leftPanelFlow.AutoScroll = true;
            InitializeBlueprint();
        }

        private void DisposeLeftPanel()
        {
            foreach (Control control in leftPanelFlow.Controls)
            {
                control.Dispose();
            }
            leftPanelFlow.Controls.Clear();
        }

        private void InitializeBlueprint()
        {
            DisposeLeftPanel();
            createdElementsListView.Items.Clear();
            roomElementSet.Clear();

            leftPanelPictureBox = new PictureBox();
            leftPanelPictureBox.Size = leftPanelFlow.Size;
            leftPanelPictureBox.BackColor = Color.White;
            leftPanelPictureBox.Paint += PaintPictureBox;
            leftPanelPictureBox.MouseClick += new MouseEventHandler(BitmapClicked);
            leftPanelPictureBox.MouseDown += LeftMouseDown;
            leftPanelPictureBox.MouseUp += LeftMouseUp;

            leftPanelPictureBox.MouseWheel += MouseWheelHandler;

            leftPanelFlow.Controls.Add(leftPanelPictureBox);
        }
        private void NewBlueprintMenuHandler(object sender, EventArgs e)
        {
            InitializeBlueprint();
        }

        //  funkcja obsługująca event Paint w PictureBoxie
        private void PaintPictureBox(object sender, PaintEventArgs e)
        {
            roomElementSet.Draw(e.Graphics);

            if(wallInCreation != null)
            {
                e.Graphics.DrawLine(wallInCreation.pen, wallInCreation.Last, cursor);
            }
        }

        //  resize bitmapy
        private void LeftFlowPanelResize(object sender, EventArgs e)
        {
            if (leftPanelPictureBox == null) return;

            if(leftPanelFlow.Width > leftPanelPictureBox.Width || leftPanelFlow.Height > leftPanelPictureBox.Height)
                leftPanelPictureBox.Size = new Size(leftPanelFlow.Size.Width, leftPanelFlow.Size.Height);
        }

        //  obsługa klawiszy
        private void KeyDownForm(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    if (clickedElement != null)
                    {
                        int i = roomElementSet.Find(clickedElement);
                        
                        roomElementSet.RemoveAt(i);
                        createdElementsListView.Items.RemoveAt(i);
                        
                        leftPanelPictureBox?.Refresh();
                        
                        clickedElement = null;
                    }
                    break;
                case Keys.Escape:
                    if(clickedElement != null)
                    {
                        clickedElement.ChangeTransparency();
                        clickedElement = null;
                        leftPanelPictureBox?.Refresh();
                    }
                    else if (wallInCreation != null)
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
                    break;
                default:
                    break;
            }
        }

        private void ListViewSelect(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            /*if (e.IsSelected && clickedElement == null)
            {
                int i;

                for (i = 0; i < createdElementsListView.Items.Count; i++)
                {
                    if (createdElementsListView.Items[i] == e.Item)
                    {
                        UnclickClickedRoomElement();

                        leftPanelPictureBox.MouseWheel += MouseWheelHandlerWhenElementPicked;

                        clickedElement = roomElementSet[i];
                        clickedElement.ChangeTransparency();

                        createdElementsListView.Items[i].Focused = true;
                        createdElementsListView.Items[i].Selected = true;

                        leftPanelPictureBox.Refresh();

                        break;
                    }
                }
            }*/
        }
    }
}