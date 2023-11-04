using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematyczny_Wąż
{
    public class rownanie : Label
    {

        public rownanie()
        {




            this.AutoSize = true;
            this.Font = new Font("Segoe UI Black", 19.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            this.ForeColor = SystemColors.WindowText;


            this.Size = new Size(300, 90);
            this.TabIndex = 4;


        }

    }
}
