using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotificationLibrary;

namespace AlertManagement
{
    public partial class MainMenu : Form
    {
        private const int DEFAULT_NUMBER = 0;
        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(DataBase dataBase)
        {
            InitializeComponent();
            _dataBase = dataBase;
        }

        private void UpdateNumbers()
        {

            int ITPersonnel = DEFAULT_NUMBER;
            int CriticalUser = DEFAULT_NUMBER;
            int Subscribers = DEFAULT_NUMBER;

            foreach (Employee employee in _dataBase.abonements.employeeList)
                switch (employee.Title)
                {
                    case 0:
                        ITPersonnel++ ; break;
                    case 1:
                        CriticalUser++; break;
                    case 2:
                        Subscribers++ ; break;
                }

            int Applications = _dataBase.applications.Length;
            int Alerts = _dataBase.alerts.Length;

            button1.Text = ("           " + ITPersonnel + " IT personel\n\n" +
                            "           " + CriticalUser + " Critical Users\n\n" +
                            "           " + Subscribers + " Subscribed Users");
            button2.Text = Applications + " Applications";
            button3.Text = Alerts + " Current alerts";
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            UpdateNumbers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserManagement userManagement = new UserManagement();

            userManagement.Show();
            UpdateNumbers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppManagement appManagement = new AppManagement();

            appManagement.Show();
            UpdateNumbers();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateNumbers();
        }
    }
}
