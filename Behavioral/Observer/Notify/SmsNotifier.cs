using ObserverPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Notify
{
    internal class SmsNotifier : Observer
    {
        public SmsNotifier(Subject _subject)
        {
            this.subject = _subject;
            subject.Attach(this);
        }
        public override void Notify()
        {
            if (subject is VideoData videoData)
            {
                Console.WriteLine("Notify all subscribers via SMS with new data" +
                                  "\n\tName: {0}" +
                                  "\n\tDescription: {1}" +
                                  "\n\tNote: {2}", videoData.Title, videoData.Description, videoData.Note);
            }
        }
    }
}
