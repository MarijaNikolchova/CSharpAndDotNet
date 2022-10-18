using System;

namespace Exercise09_TextToHTML
{
    internal class TextToHTML
    {
        protected string[] myHTML;
        protected int maxLines = 1000;
        private int counter = 0;

        public TextToHTML()
        {
            myHTML = new string[maxLines];
        }


        public void Add(string newSentence)
        {
            if (counter < maxLines)
            {
                myHTML[counter] = newSentence;
                counter++;
            }
        }


        public string ToString()
        {
            string allHTML = "\n\n";

            for (int i = 0; i < counter; i++)
                allHTML += $"<p>{myHTML[i]}</p>\n";

            allHTML += "\n";
            allHTML += "\n";

            return allHTML;
        }


        public void Display()
        {
            Console.Write(ToString());
        }
    }
}