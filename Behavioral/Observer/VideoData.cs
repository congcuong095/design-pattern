using ObserverPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class VideoData : Subject
    {
        private string _tiltle;
        private string _description;
        private string _note;
        public string Title
        {
            get { return _tiltle; }
            set
            {
                _tiltle = value;
                NotifyObserver();
            }
        }
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                NotifyObserver();
            }
        }
        public string Note
        {
            get { return _note; }
            set
            {
                _note = value;
                NotifyObserver();
            }
        }


    }
}
