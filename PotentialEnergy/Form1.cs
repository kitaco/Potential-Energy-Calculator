using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotentialEnergy
{
    public partial class Form1 : Form
    {   
        // declare constant gravity value
        const decimal gravity = 9.8m;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // declare variables
            decimal mass;
            decimal height;
            decimal potentialenergy;
            // get values from textboxes
            mass = decimal.Parse(massTextbox.Text);
            height = decimal.Parse(heightTextbox.Text);
            // calculate potential energy
            potentialenergy = mass * height * gravity;
            // output to outputLabel 
            outputLabel.Text = potentialenergy.ToString("n3");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear all textboxes
            massTextbox.Text = String.Empty;
            heightTextbox.Text = String.Empty;
            outputLabel.Text = String.Empty;
            // set focus on massTextBox
            massTextbox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // exit the program
            this.Close();
        }
    }
}
