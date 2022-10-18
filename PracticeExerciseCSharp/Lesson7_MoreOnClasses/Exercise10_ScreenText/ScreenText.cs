using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_ScreenText
{
    internal class ScreenText
    {
        protected int x, y;
        protected string text;

        public ScreenText(int x, int y, string text)
        {
            this.x = x;
            this.y = y;
            this.text = text;
        }

        public void SetX(int x)
        {
            this.x = x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public void SetText(string text)
        {
            this.text = text;
        }

        public void Display()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(text);
        }
    }
}
