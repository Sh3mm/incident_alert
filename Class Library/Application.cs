using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationLibrary
{
    public class App
    {
        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _category;
        public int category
        {
            get { return _category; }
            set { _category = value; }
        }

        private string _version;
        public string version
        {
            get { return _version; }
            set { _version = value; }
        }

        private int _severity;
        public int severity
        {
            get { return _severity; }
            set { _severity = value; }
        }


        public App()
        {
            
        }

        public App(string name, int category, int severity)
        {
            _name = name;
            _category = category;
            _severity = severity;
        }

        public App(string name, int category, int severity, string version)
        {
            _name = name;
            _category = category;
            _severity = severity;
            _version = version;
        }

        ~ App() {}
    }
}
