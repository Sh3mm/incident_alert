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
    public partial class NewApp : Form
    {
        private string _name ="";
        private string _version = "";
        private int _severity = -1;
        private int _category = -1;

        public NewApp()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (_name != "" && _severity != -1 && _category != -1 && _version == "")
            {
                App newApp = new App(_name, _category, _severity);
                MainMenu._dataBase.AddApp(newApp);
                Close();
            }
            else if (_name != "" && _severity != -1 && _category != -1 && _version != "")
            {
                App newApp = new App(_name, _category, _severity, _version);
                MainMenu._dataBase.AddApp(newApp);
                Close();
            }
            else if (_name == "")
                MessageBox.Show("The name you \nentered is invalid");
            else if (_category == -1 )
                MessageBox.Show("You did not chose \na category");
            else if (_severity == -1)
                MessageBox.Show("You did not chose \na severity");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _version = textBox1.Text;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _severity = comboBox1.SelectedIndex;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _category = comboBox2.SelectedIndex;
        }

        private void NewApp_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Constantes.SeverityType);
            comboBox2.Items.AddRange(Constantes.AppCategory);
        }

    }
}
