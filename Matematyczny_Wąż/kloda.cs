using Matematyczny_Wąż.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematyczny_Wąż
{
    public class kloda : PictureBox
    {
        public kloda()
        {

            this.Image = Resources.kloda;

            this.Size = new Size(238, 73);
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.Transparent;


        }
    }
}
