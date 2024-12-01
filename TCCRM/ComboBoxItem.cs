using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCRM
{
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        // Over-ride Tostring to show the display name in the ComboBox
        public override string ToString()
        {
            return Text;
        }
    }
}
