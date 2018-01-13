using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace NotificationLibrary
{
    public class Alert
    {
        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _status;
        public int status
        {
            get { return _status; }
            set { _status = value; }
        }

        private string _startDate;
        public string startDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        private string _endDate;
        public string endDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public Alert()
        {

        }

        public Alert(string name)
        {
            _name = name;
            _status = 1;
            _startDate = DateTime.Today.Date.ToString().Substring(0,10);
        }

        public void SetEndDate(DateTime date)
        {
            _endDate = date.ToString().Substring(0, 10);
            _status = 0;
        }

        public void EndDateNow()
        {
            _endDate = DateTime.Today.ToString().Substring(0, 10);
            _status = 0;
        }

        ~ Alert() {}
    }
}