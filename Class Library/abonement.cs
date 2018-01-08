using System;

namespace NotificationLibrary
{
    public class Abonements
    {
        private Employee[] _employeeList = {};
        public Employee[] employeeList
        {
            get { return _employeeList;}
            set { _employeeList = value;}
        }

        private int[] _notificationTypes = {};
        public int[] notificationTypes
        {
            get { return _notificationTypes;}
            set { _notificationTypes = value;}
        }

        private int[][] _notifications = {};
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

        public void AddEmployee(Employee newEmployee)
        {
            Employee[] newEmployeeList = new Employee[_employeeList.Length+1];
            for (int i = 0; i < _employeeList.Length; i++)
                newEmployeeList[i] = _employeeList[i];
            newEmployeeList[_employeeList.Length] = newEmployee;
            _employeeList = newEmployeeList;

            int[] newNotificationTypes = new int[_notificationTypes.Length];
            for (int i = 0; i < _notificationTypes.Length; i++)
                newNotificationTypes[i] = _notificationTypes[i];
            newNotificationTypes[_notificationTypes.Length] = (int) Constantes.NotificationTypes.Email;

            int[][] newNotifications = new int[_notifications.Length][];
            for (int i = 0; i < _notifications.Length; i++)
                newNotifications[i] = _notifications[i];
            newNotifications[_notifications.Length] = new int[0]; 


        }

        public void AddEmployee(Employee newEmployee, int[] newNotificationList)
        {
            Employee[] newEmployeeList = new Employee[_employeeList.Length + 1];
            for (int i = 0; i < _employeeList.Length; i++)
                newEmployeeList[i] = _employeeList[i];
            newEmployeeList[_employeeList.Length] = newEmployee;
            _employeeList = newEmployeeList;

            int[] newNotificationTypes = new int[_notificationTypes.Length];
            for (int i = 0; i < _notificationTypes.Length; i++)
                newNotificationTypes[i] = _notificationTypes[i];
            newNotificationTypes[_notificationTypes.Length] = (int)Constantes.NotificationTypes.Email;

            int[][] newNotifications = new int[_notifications.Length][];
            for (int i = 0; i < _notifications.Length; i++)
                newNotifications[i] = _notifications[i];
            newNotifications[_notifications.Length] = newNotificationList;


        }

        public void AddEmployee(Employee newEmployee, int[] newNotificationList, int notificationTypes)
        {
            Employee[] newEmployeeList = new Employee[_employeeList.Length + 1];
            for (int i = 0; i < _employeeList.Length; i++)
                newEmployeeList[i] = _employeeList[i];
            newEmployeeList[_employeeList.Length] = newEmployee;
            _employeeList = newEmployeeList;

            int[] newNotificationTypes = new int[_notificationTypes.Length + 1];
            for (int i = 0; i < _notificationTypes.Length; i++)
                newNotificationTypes[i] = _notificationTypes[i];
            newNotificationTypes[_notificationTypes.Length] = notificationTypes;

            int[][] newNotifications = new int[_notifications.Length + 1][];
            for (int i = 0; i < _notifications.Length; i++)
                newNotifications[i] = _notifications[i];
            newNotifications[_notifications.Length] = newNotificationList;


        }

        ~Abonements() {}
    }
}
