using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace FormsLab1
{
    partial class RoomDesigner
    {
        private void SaveBlueprintMenuHandler(object sender, EventArgs e)
        {
            SerializingInfo serializingInfo = new SerializingInfo
            {
                RoomElementSet = roomElementSet,
                PictureBoxSize = leftPanelPictureBox.Size,
                LeftPanelSize = leftPanelFlow.Size,
                RightPanelSize = rightPanelTable.Size,
                FormSize = this.Size
            };

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "xd files (*.xd)|*.xd";

            System.IO.Stream stream;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                stream = saveFileDialog.OpenFile();
            }
            else
            {
                MessageBox.Show("ERROR! Unable to save.");
                return;
            }

            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                formatter.Serialize(stream, serializingInfo);
                MessageBox.Show("Saved succesfully!");
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR! Unable to save.");
            }
            finally
            {
                stream.Close();
            }
        }

        private void OpenBlueprintMenuHandler(object sender, EventArgs e)
        {
            SerializingInfo serializingInfo = new SerializingInfo();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "xd files (*.xd)|*.xd";

            System.IO.Stream stream;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                stream = openFileDialog.OpenFile();
            }
            else
            {
                MessageBox.Show("ERROR! Unable to save.");
                return;
            }

            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                serializingInfo = (SerializingInfo)formatter.Deserialize(stream);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR! Unable to load.");
                stream.Close();
                return;
            }
            finally
            {
                stream.Close();
            }

            InitializeBlueprint();
            this.Size = serializingInfo.FormSize;
            leftPanelFlow.Size = serializingInfo.LeftPanelSize;
            leftPanelPictureBox.Size = serializingInfo.PictureBoxSize;
            rightPanelTable.Size = serializingInfo.RightPanelSize;

            foreach (RoomElement element in serializingInfo.RoomElementSet.elements)
            {
                RoomElement roomElement;

                if (element.path.Count == 0)
                {
                    roomElement = new Furniture(element.Coordinates, this, element.name, element.Rotation);
                }
                else
                {
                    roomElement = new Wall(element.Coordinates, element.path);
                }

                roomElementSet.Add(roomElement);
                createdElementsListView.Items.Add(roomElement.ToString());
            }

            leftPanelPictureBox.Refresh();
        }
    }
}
