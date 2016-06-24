using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayFinder1
{
    public partial class Form1 : Form
    {
        string findName = "";
        int years = 0;
        int day = 0;
        string month = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // First name from textbox.
            findName = textBoxName.Text;

            // Getting the difference in days between today's date and the date in the time picker.
            DateTime today = DateTime.Now.Date;
            TimeSpan ageDays = today - dateTimePicker1.Value;

            // identifying the age in years.
            years = ((int)ageDays.TotalDays) / 365;

            day = dateTimePicker1.Value.Day;
            month = dateTimePicker1.Value.ToString("MMMM");

            labelResult.Text = "Hello " + findName + "! You are going to be " + years + " years old on " + day + " " + month + ".";
        }
    }
}
