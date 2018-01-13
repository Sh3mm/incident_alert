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
    public partial class AppManagement : Form
    {
        public AppManagement()
        {
            InitializeComponent();
        }

        private void Updateboard()
        {
            listView1.Items.Clear();

            //Add items in the listview
            string[] arr = new string[5];
            ListViewItem itm;
            for (int i = 0; i < MainMenu._dataBase.applications.Length; i++)
            {
                //Add first item
                arr[0] = MainMenu._dataBase.applications[i].name;
                arr[1] = Constantes.AppCategory[MainMenu._dataBase.applications[i].category];
                arr[2] = MainMenu._dataBase.applications[i].version;
                arr[3] = Constantes.SeverityType[MainMenu._dataBase.applications[i].severity];
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);


            }
        }

        private void AppManagement_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //Add column header
            listView1.Columns.Add("Name"    , 217);
            listView1.Columns.Add("Category", 217);
            listView1.Columns.Add("Version" , 95);
            listView1.Columns.Add("Severity", 95);

            Updateboard();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewApp newApp = new NewApp();

            newApp.ShowDialog();
            Updateboard();
        }
    }
}
