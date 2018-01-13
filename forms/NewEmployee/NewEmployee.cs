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
    public partial class NewEmployee : Form


    {
        private string _email = "";
        private string _name = "";
        private string _phoneNumber = "";
        private int[] _notificationList;
        private int _title = -1;
        private int _notificationType = (int) Constantes.NotificationTypes.Email;

        public NewEmployee()
        {
            InitializeComponent();
        }

        private void update_email_name()
        {
            if (textBox2.Text != "" && textBox1.Text != "")
                _email = textBox1.Text.ToLower()[0] + textBox2.Text.ToLower() + "@company.com";
            else
                _email = "";

            textBox4.Text = _email;

            _name = textBox1.Text.ToLower() + ' ' + textBox2.Text.ToLower();
        }

        private void update_phone()
        {
            string phone = "";
            char[] numbers = {'0', '9', '8', '7', '6', '5', '4', '3', '2', '1'};

            foreach (char number in textBox3.Text)
                if (numbers.Contains(number))
                    phone += number;
            _phoneNumber = phone;
        }

        private void update_Abonements(Employee newEmployee)
        {
            MainMenu._dataBase.abonements.AddEmployee(newEmployee,_notificationList,_notificationType);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            update_email_name();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            update_email_name();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            update_phone();
            if (_phoneNumber.Length >= 7)
                checkBox1.Visible = true;
            else
            {
                checkBox1.Visible = false;
                checkBox1.CheckState = CheckState.Unchecked;
            }

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Unchecked)
                _notificationType = (int) Constantes.NotificationTypes.Email;
            if (checkBox1.CheckState == CheckState.Checked)
                _notificationType = (int)Constantes.NotificationTypes.Text;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _notificationList = new int[checkedListBox1.CheckedIndices.Count];

            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
                _notificationList[i] = checkedListBox1.CheckedIndices[i];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee;

            if ((_name != " ") && (_email != "") && (_title != -1) &&(_phoneNumber == ""))
            {
                employee = new Employee(_name, _email, _title);
                update_Abonements(employee);
                Close();
            }

            else if ((_name != " ") && (_email != "") && (_title != -1) && (_phoneNumber != "") && (_phoneNumber.Length >= 7))
            {
                employee = new Employee(_name, _email, _title, _phoneNumber);
                update_Abonements(employee);
                Close();
            }

            else if (_phoneNumber != "" && _phoneNumber.Length <= 7)
                MessageBox.Show("The phone number\n you entered is invalid");

            else if (_title == -1)
                MessageBox.Show("You didn't enter a Title");

            else
                MessageBox.Show("The name you entered is invalid");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.AddRange(Constantes.AlertType);
            comboBox1.Items.AddRange(Constantes.UserType);
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _title = comboBox1.SelectedIndex;
        }
    }
}
