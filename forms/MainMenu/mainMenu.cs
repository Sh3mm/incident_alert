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

        public MainMenu(Abonements abonements)
        {
            InitializeComponent();
            _abonements = abonements;
        }

        private void UpdateNumbers()
        {

            int ITPersonnel = DEFAULT_NUMBER;
            int CriticalUser = DEFAULT_NUMBER;
            int Subscribers = DEFAULT_NUMBER;

            foreach (Employee employee in _abonements.employeeList)
                switch (employee.Title)
                {
                    case 0:
                        ITPersonnel++ ; break;
                    case 1:
                        CriticalUser++; break;
                    case 2:
                        Subscribers++ ; break;
                }

            int Applications = DEFAULT_NUMBER;
            int Alerts = DEFAULT_NUMBER;

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
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
