using System;
using System.Collections.Generic;
using System.Text;

namespace NotificationLibrary
{
    public class DataBase
    {
        private Abonements _abonements;
        public Abonements abonements
        {
            get { return _abonements; }
            set { _abonements = value; }
        }

        private App[] _applications = {};
        public App[] applications
        {
            get { return _applications; }
            set { _applications = value; }
        }

        private Alert[] _alerts = {};
        public Alert[] alerts
        {
            get { return _alerts; }
            set { _alerts = value; }
        }


        public DataBase()
        {
            _abonements = new Abonements();
        }

        public void AddApp(App newApplication)
        {
            App[] newapplications = new App[_applications.Length + 1];
            for (int i = 0; i < _applications.Length; i++)
                newapplications[i] = _applications[i];

            newapplications[_applications.Length] = newApplication;
            _applications = newapplications;
        }

        public void AddAlert(Alert newAlert)
        {
            Alert[] newAlerts = new Alert[_alerts.Length + 1];
            for (int i = 0; i < _alerts.Length; i++)
                newAlerts[i] = _alerts[i];

            newAlerts[_alerts.Length] = newAlert;
            _alerts = newAlerts;
        }
        ~ DataBase() {}
    }
}
