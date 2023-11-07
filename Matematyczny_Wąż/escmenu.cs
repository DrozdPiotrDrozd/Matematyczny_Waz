using Matematyczny_Wąż.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematyczny_Wąż
{
    internal class escmenu : PictureBox
    {
        public escmenu()
        {
           // this.Image = Resources.tlo;
            this.Size = new Size(1280, 1024);
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.White;


        }

    }
}
