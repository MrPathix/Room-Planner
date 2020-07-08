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
    class SerializingInfo
    {
        public RoomElementSet RoomElementSet;
        public Size PictureBoxSize;
        public Size LeftPanelSize;
        public Size RightPanelSize;
        public Size FormSize;
    }
}
