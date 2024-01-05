using Matematyczny_Wąż.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematyczny_Wąż
{
    public class krokodyl : PictureBox
    {
        public krokodyl()
        {

            this.Image = Resources.krok;

            this.Size = new Size(179, 176);
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.Transparent;


        }
    }
}
