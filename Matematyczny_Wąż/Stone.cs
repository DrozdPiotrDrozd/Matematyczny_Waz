﻿using Matematyczny_Wąż.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematyczny_Wąż
{

    public class Stone: PictureBox
    {

      public Stone() {

            this.Image = Resources.glaz;

            this.Size = new Size(169, 124);
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.Transparent;
            

        }

    }
}
