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
    public partial class RoomDesigner : Form
    {
        private void SetButtons()
        {
            CoffeeTable.Click += ButtonClicked;
            DoubleBed.Click += ButtonClicked;
            Sofa.Click += ButtonClicked;
            Wall.Click += ButtonClicked;
            Table.Click += ButtonClicked;

            images.Add(CoffeeTable.Name, CoffeeTable.BackgroundImage as Bitmap);
            images.Add(DoubleBed.Name, DoubleBed.BackgroundImage as Bitmap);
            images.Add(Sofa.Name, Sofa.BackgroundImage as Bitmap);
            images.Add(Wall.Name, Wall.BackgroundImage as Bitmap);
            images.Add(Table.Name, Table.BackgroundImage as Bitmap);
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Button newClicked = sender as Button;

            if (clickedButton == newClicked)
            {
                clickedButton = null;
                newClicked.BackColor = Color.White;
            }
            else
            {
                newClicked.BackColor = Color.LightYellow;

                ButtonUnclick();
            }

            clickedButton = newClicked;
        }

        private void ButtonUnclick()
        {
            if (clickedButton != null)
            {
                clickedButton.BackColor = Color.White;
                createdElementsListView.Focus();
            }
            
            clickedButton = null;
        }

        private void Button_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
    }
}
