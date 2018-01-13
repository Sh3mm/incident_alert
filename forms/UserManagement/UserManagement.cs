using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using NotificationLibrary;

namespace AlertManagement
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void Updateboard()
        {
            listView1.Items.Clear();

            //Add items in the listview
            string[] arr = new string[5];
            ListViewItem itm;
            for (int i = 0; i < MainMenu._dataBase.abonements.employeeList.Length; i++)
            {
                //Add first item
                arr[0] = MainMenu._dataBase.abonements.employeeList[i].Email;
                arr[1] = MainMenu._dataBase.abonements.employeeList[i].EmployeeName;
                arr[2] = MainMenu._dataBase.abonements.employeeList[i].Email;
                arr[3] = Constantes.UserType[MainMenu._dataBase.abonements.employeeList[i].Title];
                arr[4] = MainMenu._dataBase.abonements.employeeList[i].Cellphone;
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);


            }
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //Add column header
            listView1.Columns.Add("UserID", 152);
            listView1.Columns.Add("Name", 150);
            listView1.Columns.Add("Email", 152);
            listView1.Columns.Add("Title", 70);
            listView1.Columns.Add("Mobile", 90);

            Updateboard();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewEmployee newEmployee = new NewEmployee();


            newEmployee.ShowDialog();
            Updateboard();

        }
    }
}
