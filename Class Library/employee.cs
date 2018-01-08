namespace NotificationLibrary
{
    public class Employee
    {
        private string _employeeName;
        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }

        private string _cellphone;
        public string Cellphone
        {
            get { return _cellphone;}
            set { _cellphone = value;}
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private int _title;
        public int Title
        {
            get { return _title; }
            set { _title = value; }
        }


        public Employee() {}

        public Employee (string name, string email, int title)
        {
            _employeeName = name;
            _email = email;
            _title = title;
        }

        public Employee (string name, string email, int title, string cellphone)
        {
            _employeeName = name;
            _cellphone = cellphone;
            _email = email;
            _title = title;
        }

        ~Employee() {}
    }
}
