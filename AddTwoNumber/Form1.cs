using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AddTwoNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            float first;
            float second;

          
            if (!float.TryParse(firstTextBox.Text, out first))
            {
                MessageBox.Show("Please enter only number \n in the First box!");
                return;
            }
            if (!float.TryParse(secondTextBox.Text, out second))
            {
                MessageBox.Show("Please enter only number \n in the Second box!");
                return;
            }
            answerLabel.Text = (first + second).ToString();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            float first;
            float second;

            if (!float.TryParse(firstTextBox.Text, out first))
            {
                MessageBox.Show("Please enter only number \n in the First box!");
                return;
            }
            if (!float.TryParse(secondTextBox.Text, out second))
            {
                MessageBox.Show("Please enter only number \n in the Second box!");
                return;
            }
            answerLabel.Text = (first - second).ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            float first;
            float second;

            if (!float.TryParse(firstTextBox.Text, out first))
            {
                MessageBox.Show("Please enter only number \n in the First box!");
                return;
            }
            if (!float.TryParse(secondTextBox.Text, out second))
            {
                MessageBox.Show("Please enter only number \n in the Second box!");
                return;
            }
            answerLabel.Text = (first / second).ToString();
        }

        private void mul_Click(object sender, EventArgs e)
        {
            float first;
            float second;

            if (!float.TryParse(firstTextBox.Text, out first))
            {
                MessageBox.Show("Please enter only number \n in the First box!");
                return;
            }
            if (!float.TryParse(secondTextBox.Text, out second))
            {
                MessageBox.Show("Please enter only number \n in the Second box!");
                return;
            }
            answerLabel.Text = (first * second).ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstTextBox.Text = "";
            secondTextBox.Text = "";
            answerLabel.Text = "";
        }
    }
}
