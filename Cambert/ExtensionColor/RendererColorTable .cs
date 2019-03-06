using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Cambert.ExtensionColor
{
    public class RendererColorTable : ProfessionalColorTable
    {   
        private const string PRIMARY_COLOR = "#3f51b5";
        private const string SECONDARY_COLOR = "#00838f";
        private const string SECONDARY_COLOR_LIGHT = "#4fb3bf";
        private const string SECONDARY_COLOR_DARK = "#005662";

        public override Color ToolStripDropDownBackground
        {
            get { return ColorTranslator.FromHtml(SECONDARY_COLOR); }
        }

        public override Color ImageMarginGradientBegin
        {
            get { return ColorTranslator.FromHtml(SECONDARY_COLOR_DARK); }
        }

        public override Color ImageMarginGradientMiddle
        {
            get { return ColorTranslator.FromHtml(SECONDARY_COLOR_DARK); }
        }

        public override Color ImageMarginGradientEnd
        {
            get { return ColorTranslator.FromHtml(SECONDARY_COLOR_DARK); }
        }

        public override Color MenuBorder
        {
            get { return ColorTranslator.FromHtml(PRIMARY_COLOR); }
        }

        public override Color MenuItemBorder
        {
            get { return ColorTranslator.FromHtml(PRIMARY_COLOR); }
        }

        public override Color MenuItemSelected
        {
            get { return ColorTranslator.FromHtml(SECONDARY_COLOR_LIGHT); }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get { return ColorTranslator.FromHtml(SECONDARY_COLOR); }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get { return ColorTranslator.FromHtml(SECONDARY_COLOR); }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get { return ColorTranslator.FromHtml(SECONDARY_COLOR); }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return ColorTranslator.FromHtml(SECONDARY_COLOR); }
        }
    }
}
