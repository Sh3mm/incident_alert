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
    public partial class NewAlert : Form
    {
        private string _name = "";
        private string _startDate = "";
        private string _endDate = "";
        private int _status = 0;
        public NewAlert()
        {
            InitializeComponent();
        }
        private void NewAlert_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Constantes.AlertState);
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                maskedTextBox2.Enabled = false;
                maskedTextBox2.Text = "";
                _endDate = "";
            }
            if (comboBox1.SelectedIndex == 1)
                maskedTextBox2.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _name = textBox1.Text;
        }

        private void maskedTextBox1_Validated(object sender, EventArgs e)
        {
            _startDate = maskedTextBox1.Text;
        }
        private void maskedTextBox2_Validated(object sender, EventArgs e)
        {
            _endDate = maskedTextBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_status == 0 && _name != "" && _startDate != "")
            {
                Alert newAlert = new Alert(_name);
                MainMenu._dataBase.AddAlert(newAlert);
            }
        }
    }
}
