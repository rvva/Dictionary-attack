﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BruteForceAttack
{
    class Highlighter
    {
        public static async void highlightHTMLText(RichTextBox richTextBox)
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
                await findAndHighlight("<" + s, Color.Green, richTextBox);
                await findAndHighlight("</" + s, Color.Green, richTextBox);
                await findAndHighlight(">", Color.Green, richTextBox);
            }

            string[] attributes =
            {
            "href", "src", "height", "width", "rowspan", "colspan", "target", "style", "onclick", "id", "name",
            "class"
        };

            foreach (string s in attributes)
            {
                await findAndHighlight(s + "=", Color.Blue, richTextBox);
            }
        }

        private static Task findAndHighlight(string searchStr, Color color, RichTextBox richTextBox)
        {
            return Task.Run(() =>
            {
                int index = richTextBox.Text.IndexOf(searchStr);
                while (index != -1)
                {
                    richTextBox.Invoke((Action)delegate
                    {
                        int length = searchStr.Length;
                        richTextBox.Select(index, length);
                        richTextBox.SelectionColor = color;

                        index = richTextBox.Text.IndexOf(searchStr, index + length);
                    });
                }
            });
        }
    }
}