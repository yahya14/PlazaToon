using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;

namespace PlazaToon
{
    public class ToolStripColors : ProfessionalColorTable
    {

        public override Color MenuItemSelectedGradientBegin
        {
            get { return SystemColors.MenuHighlight; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return SystemColors.MenuHighlight; }
        }
        public override Color MenuItemPressedGradientBegin
        {
            get { return SystemColors.MenuHighlight; }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get { return SystemColors.MenuHighlight; }
        }
        public override Color MenuItemBorder
        {
            get { return Color.DodgerBlue; }
        }
    }
}
