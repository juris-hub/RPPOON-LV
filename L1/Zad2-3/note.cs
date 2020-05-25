using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lv1_RPPOON
{
    class note
    {
        private string text;
        private string author;
        private int priority;

        public note()
        {
            this.text = "tekstic";
            this.author = "Ivan";
            this.priority = 1;
        }

        public note(string text, string author)
        {
            this.text = text;
            this.author = author;
        }

        public note(string text, int priority)
        {
            this.text = text;
            this.priority = priority;
            this.author = "Nema autora";
        }

        private void SetAuthor(string author)
        {
            this.author = author;
        }
        public void SetPriority(int priority)
        {
            this.priority = priority;
        }
        public void SetText(string text)
        {
            this.text = text;
        }

        public string GetAuthor()
        {
            return author;
        }
        public int GetPriority()
        {
            return priority;
        }
        public string GetText()
        {
            return text;
        }

        static void Main(string[] args)
        {
            note zabiljeska1 = new note();
            note zabiljeska2 = new note("Tekst", "Ivan");
            note zabiljeska3 = new note("Neki tekst", 8);

            Console.WriteLine("Tekst je: {0}, Autor je: {1}", zabiljeska1.GetText(), zabiljeska1.GetAuthor());
            Console.WriteLine("Tekst je: {0}, Autor je: {1}", zabiljeska2.GetText(), zabiljeska2.GetAuthor());
            Console.WriteLine("Tekst je: {0}, Autor je: {1}", zabiljeska3.GetText(), zabiljeska3.GetAuthor());
        }
    }
}
