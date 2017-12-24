using System;

namespace NotificationLibrary
{
    class Abonements
    {
        private Employee[] _employeeList;
        public Employee[] employeeList
        {
            get { return _employeeList;}
            set { _employeeList = value;}
        }

        private int[] _notificationTypes;
        public int[] notificationTypes
        {
            get { return _notificationTypes;}
            set { _notificationTypes = value;}
        }

        private int[][] _notifications;
        public int[][] notifications
        {
            get { return _notifications;}
            set { _notifications = value;}
        }


        public Abonements() {}

        public Abonements(Employee[] employeeList)
        {
            _employeeList = employeeList;
            _notifications = new int[employeeList.Length][];

            for (int i = 0; i < employeeList.Length; i++)
                _notifications[i] = new int[0];

            _notificationTypes = new int[employeeList.Length];
            for (int i = 0; i < employeeList.Length; i++)
                _notificationTypes[i] = (int) Constantes.NotificationTypes.Email;
        }

        public bool AddNotifcation(string email, int alertType, int notificationType)
        {
            for (int i = 0; i < _employeeList.Length; i++)
                if (email == _employeeList[i].Email)
                {
                    _notifications[i] = NewNotifcation(_notifications[i], alertType);
                    return true;
                }
            return false;
        }

        private int[] NewNotifcation(int[] notification, int alertType)
        {
            int[] newNotifcation = new int[notification.Length + 1];
            Array.Copy(notification, newNotifcation, notification.Length);
            newNotifcation[notification.Length] = alertType;

            return newNotifcation;
        }

        public bool ChangeNotificationType(string email, int type)
        {
            for (int i = 0; i < _employeeList.Length; i++)
                if (email == _employeeList[i].Email)
                {
                    _notificationTypes[i] = type;
                    return true;
                }
            return false;
        }

        ~Abonements() {}
    }
}
