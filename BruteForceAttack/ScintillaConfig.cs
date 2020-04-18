using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScintillaNET;

namespace BruteForceAttack
{
    class ScintillaConfig
    {
        public static void loadHtmlStyleConfig(Scintilla scintilla)
        {
            scintilla.Lexer = Lexer.Html;
            scintilla.Styles[Style.Html.Entity].ForeColor = Color.DarkBlue;
            scintilla.Styles[Style.Html.Attribute].ForeColor = Color.DarkCyan;
            scintilla.Styles[Style.Html.Script].ForeColor = Color.DarkGoldenrod;
            scintilla.Styles[Style.Html.Tag].ForeColor = Color.DarkGreen;
            scintilla.Styles[Style.Html.TagEnd].ForeColor = Color.DarkMagenta;
            scintilla.Styles[Style.Html.Value].ForeColor = Color.DarkKhaki;
            scintilla.Styles[Style.Html.Asp].ForeColor = Color.DarkOliveGreen;
            scintilla.Styles[Style.Html.AspAt].ForeColor = Color.DarkSalmon;
            scintilla.Styles[Style.Html.CData].ForeColor = Color.DarkOrange;
            scintilla.Styles[Style.Html.Comment].ForeColor = Color.DarkGray;
            scintilla.Styles[Style.Html.DoubleString].ForeColor = Color.DarkSlateBlue;
            scintilla.Styles[Style.Html.Question].ForeColor = Color.DarkSeaGreen;
            scintilla.Styles[Style.Html.XmlStart].ForeColor = Color.GreenYellow;
            scintilla.Styles[Style.Html.XmlEnd].ForeColor = Color.ForestGreen;
            scintilla.Styles[Style.Html.XcComment].ForeColor = Color.DarkGray;
        }
    }
}
