using Matematyczny_Wąż.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematyczny_Wąż
{
    public class waz : PictureBox
    {

        public waz()
        {

            this.Image = Resources.waz;

            this.Size = new Size(87, 250);
            this.SizeMode = PictureBoxSizeMode.Zoom;



        }

    }
}
