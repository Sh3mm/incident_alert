namespace NotificationLibrary
{
    public class Employee
    {
        private string _employeeName;

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

        public Employee() {}

        public Employee (string name, string email)
        {
            _employeeName = name;
            _email = email;
        }

        public Employee (string name,string email, string cellphone)
        {
            _employeeName = name;

            _cellphone = cellphone;
            _email = email;
        }

        ~Employee() {}
    }
}
