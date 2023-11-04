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

            this.Image = Resources.w2;

            this.Size = new Size(69,225);
            this.SizeMode = PictureBoxSizeMode.Zoom;



        }

    }
}
