using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz1
{
    public partial class Form1 : Form
    {
        int remainingTime = 60;
        bool q1Correct = false;
        bool q2Correct = false;
        bool q3Correct = false;
        
        public Form1()
        {
            InitializeComponent();        
            labelQandA.Visible = false;
            groupBoxQ1.Visible = false;
            groupBoxQ2.Visible = false;
            groupBoxQ3.Visible = false;
            buttonClose.Enabled = false;
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            buttonstart.Enabled = false;

            labelQandA.Visible = true;
            groupBoxQ1.Visible = true;
            groupBoxQ2.Visible = true;
            groupBoxQ3.Visible = true;
            buttonClose.Enabled = true;
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(q1Correct && q2Correct && q3Correct)
            {
                timer1.Stop();
                MessageBox.Show("Congratulations! You have answered all the questions correctly before the timer had finished. Click 'Exit' to close.");
            }
            else if (remainingTime > 0)
            {
                // update and display remaining time
                remainingTime--;
                labelRemainingTime.Text = remainingTime + " seconds";
            }

            else
            {
                // if the user is out of time
                timer1.Stop();
                labelRemainingTime.Text = "0 seconds";
                MessageBox.Show("Sorry! You have run out of time.");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ1A1.Checked)
            {
                labelQ1feedback.ForeColor = Color.Red;
                labelQ1feedback.Text = "\u00fb"; //incorrect
                q1Correct = false;
            }
            else
            {
                labelQ1feedback.Text = "";
            }
        }

        private void radioButtonQ1A2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonQ1A2.Checked)
            {
                labelQ1feedback.ForeColor = Color.Green;
                labelQ1feedback.Text = "\u00fc"; //Correct
                q1Correct = true;
            }

            else
            {
                labelQ1feedback.Text = "";
            }
            
        }

        private void radioButtonQ1A3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonQ1A3.Checked)
            {
                labelQ1feedback.ForeColor = Color.Red;
                labelQ1feedback.Text = "\u00fb";
                q1Correct = false;
            }

            else
            {
                labelQ1feedback.Text = "";
            }
        }

        private void radioButtonQ2A1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A1.Checked)
            {
                labelQ2Feedback.ForeColor = Color.Green;
                labelQ2Feedback.Text = "\u00fc"; //Correct
                q2Correct = true;
            }

            else
            {
                labelQ2Feedback.Text = "";
            }
        }

        private void radioButtonQ2A2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ2A2.Checked)
            {
                labelQ2Feedback.ForeColor = Color.Red;
                labelQ2Feedback.Text = "\u00fb";
                q2Correct = false;
            }

            else
            {
                labelQ2Feedback.Text = "";
            }
        }

        private void radioButtonQ2A3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonQ2A3.Checked)
            {
                labelQ2Feedback.ForeColor = Color.Red;
                labelQ2Feedback.Text = "\u00fb";
                q2Correct = false;
            }

            else
            {
                labelQ2Feedback.Text = "";
            }
        }

        private void radioButtonQ3A1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonQ3A1.Checked)
            {
                labelQ3Feedback.ForeColor = Color.Red;
                labelQ3Feedback.Text = "\u00fb";
                q3Correct = false;
            }

            else
            {
                labelQ3Feedback.Text = "";
            }
        }

        private void radioButtonQ3A2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonQ3A2.Checked)
            {
                labelQ3Feedback.ForeColor = Color.Red;
                labelQ3Feedback.Text = "\u00fb";
                q3Correct = false;
            }

            else
            {
                labelQ3Feedback.Text = "";
            }
        }

        private void radioButtonQ3A3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQ3A3.Checked)
            {
                labelQ3Feedback.ForeColor = Color.Green;
                labelQ3Feedback.Text = "\u00fc"; //Correct
                q3Correct = true;
            }

            else
            {
                labelQ3Feedback.Text = "";
            }
        }
    }
}
