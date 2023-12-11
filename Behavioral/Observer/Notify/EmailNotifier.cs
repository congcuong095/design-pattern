using ObserverPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Notify
{
    internal class EmailNotifier : Observer
    {
        public EmailNotifier(Subject _subject)
        {
            this.subject = _subject;
            subject.Attach(this);
        }
        public override void Notify()
        {
            if (subject is VideoData videoData)
            {
                Console.WriteLine("Notify all subscribers via EMAIL with new data" +
                                  "\n\tName: {0}" +
                                  "\n\tDescription: {1}" +
                                  "\n\tNote: {2}", videoData.Title, videoData.Description, videoData.Note);
            }
        }
    }
}
