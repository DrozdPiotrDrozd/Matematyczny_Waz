using Matematyczny_Wąż.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Matematyczny_Wąż
{
    public class poprawne : Label
    {

        public poprawne()
        {




            this.AutoSize = true;
            this.Font = new Font("Segoe UI Black", 17.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            this.ForeColor = SystemColors.WindowText;

            this.Size = new Size(150, 45);
            this.TabIndex = 4;


        }

    }

}