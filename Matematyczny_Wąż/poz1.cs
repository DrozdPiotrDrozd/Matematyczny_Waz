using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematyczny_Wąż
{
    public class poz1 : Label
    {
        public poz1()
        { 



            
            this.AutoSize = true;
            this.Font = new Font("Segoe UI Black", 30.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            this.ForeColor = SystemColors.WindowText;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MinimumSize = new Size(400, 60);
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Size = new Size(150, 45);
            this.TabIndex = 4;
            this.Text = "POZIOM 1";
            this.Location = new Point(440, 0);

        }
    }
}
