using System;
using System.Collections.Generic;
using System.Xml;

namespace NotepadApp
{
    class Notepad
    {
        public static List<Note> NotesList = new List<Note>();

        public static void Add(Note note)
        {
            NotesList.Add(note);
        }

        public static void Show()
        {
            foreach (Note note in NotesList)
            {
                note.PrintToConsole();
            }
        }
    }

    class Note
    {
        public string Id { get; private set; }
        public string Date { get; private set; }
        public string Time { get; private set; }
        public string Subject { get; private set; }
        public string Importance { get; private set; }
        public string Text { get; private set; }

        public Note(string id, string date, string time, string subject, string importance, string text)
        {
            Id = id;
            Date = date;
            Time = time;
            Subject = subject;
            Importance = importance;
            Text = text;
        }

        public void PrintToConsole()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Date: {Date}");
            Console.WriteLine($"Time: {Time}");
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"Importance: {Importance}");
            Console.WriteLine($"Text: {Text}");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(@"C:\Users\User\OneDrive\Рабочий стол\XMLFile1.xml");

            foreach (XmlNode node in xml.DocumentElement)
            {
                if (node.Name == "note")
                {
                    var id = node.Attributes["id"]?.InnerText;
                    var date = node.Attributes["date"]?.InnerText;
                    var time = node.Attributes["time"]?.InnerText;
                    var subject = node["subject"]?.InnerText;
                    var importance = node["importance"]?.InnerText ?? string.Empty;
                    var text = node["text"]?.InnerXml;

                    if (id != null && date != null && time != null)
                    {
                        Note note = new Note(id, date, time, subject, importance, text);
                        Notepad.Add(note);
                    }
                }
            }

            Notepad.Show();
        }
    }
}