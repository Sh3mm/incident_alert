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
    public partial class Alert_management : Form
    {
        public Alert_management()
        {
            InitializeComponent();
        }

        private void Alert_management_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //Add column header
            listView1.Columns.Add("Name", 217);
            listView1.Columns.Add("Status", 217);
            listView1.Columns.Add("Start Date", 95);
            listView1.Columns.Add("End Date", 95);

            Updateboard();
        }

        private void Updateboard()
        {
            listView1.Items.Clear();

            //Add items in the listview
            string[] arr = new string[5];
            ListViewItem itm;
            for (int i = 0; i < MainMenu._dataBase.alerts.Length; i++)
            {
                //Add first item
                arr[0] = MainMenu._dataBase.alerts[i].name;
                arr[1] = Constantes.AlertState[MainMenu._dataBase.alerts[i].status];
                arr[2] = MainMenu._dataBase.alerts[i].startDate;
                arr[3] = MainMenu._dataBase.alerts[i].endDate;
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewAlert newAlert = new NewAlert();

            newAlert.ShowDialog();
            Updateboard();
        }
    }
}
