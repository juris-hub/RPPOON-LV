using System;
using System.Collections.Generic;
using System.Text;

namespace Lv1_RPPOON
{
    class note
    {


        private string text;
        private string author;
        private int priority;

        private void setAuthor(String author)
        {
            this.author = author;
        }
        public void setPriority(int priority)
        {
            this.priority = priority;
        }
        public void setText(string text)
        {
            this.text = text;
        }

        public String getAuthor()
        {
            return author;
        }
        public int getPriority()
        {
            return priority;
        }
        public String getText()
        {
            return text;
        }
        
    }
}
