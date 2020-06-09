using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DictionaryAttack
{
    class Highlighter
    {
        public static void highlightHTMLText(RichTextBox richTextBox)
        {
            string[] tags =
            {
                "html", "head", "body", "a", "b", "img", "strong", "p", "h1", "h2", "h3", "h4", "h5", "h6", "embed",
                "iframe", "span", "form",
                "button", "input", "textarea", "br", "div", "style", "script", "table", "tr", "td", "th", "i", "u",
                "link", "meta", "title"
            };

            List<string> tagList = tags.ToList();

            foreach (string s in tagList)
            {
                findAndHighlight("<" + s, Color.Green, richTextBox);
                findAndHighlight("</" + s, Color.Green, richTextBox);
                findAndHighlight(">", Color.Green, richTextBox);
            }

            string[] attributes =
            {
                "href", "src", "height", "width", "rowspan", "colspan", "target", "style", "onclick", "id", "name",
                "class"
            };

            foreach (string s in attributes)
            {
                findAndHighlight(s + "=", Color.Blue, richTextBox);
            }
        }


        private static void findAndHighlight(string searchStr, Color color, RichTextBox richTextBox)
        {
            int index = richTextBox.Text.IndexOf(searchStr);
            richTextBox.Invoke((Action)delegate
            {
                while (index != -1)
                {
                    int length = searchStr.Length;
                    richTextBox.Select(index, length);
                    richTextBox.SelectionColor = color;

                    index = richTextBox.Text.IndexOf(searchStr, index + length);
                }
            });
        }
    }
}