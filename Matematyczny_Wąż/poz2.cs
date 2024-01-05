using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematyczny_Wąż
{
    public class poz2 : Label
    {
        public poz2()
        {




            this.AutoSize = true;
            this.Font = new Font("Segoe UI Black", 30.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            this.ForeColor = SystemColors.WindowText;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MinimumSize = new Size(1240, 60);
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Size = new Size(150, 45);
            this.TabIndex = 4;
            this.Text = "POZIOM 2";
            this.Location = new Point(10, -150);
            this.BackColor = Color.SpringGreen;

        }
    }
}
