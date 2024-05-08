using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
Name: David Badrak
Date: 5/6/24
Program: Car acceleration and braking using classes
Program Description: Using classes, we can make the car classes accelerate or brake through buttons
*/

namespace Car_Acceleration_and_Braking
{

    public partial class Form1 : Form
    {
        private CarStuff carStuff;

        public Form1()
        {
            InitializeComponent();
            //pulls the class from the other file. 
            carStuff = new CarStuff(2019,"Tesla Model S");
        }

        

        private void btnAccel_Click(object sender, EventArgs e)
        {
            //calls for the acceleration to be incremented
            carStuff.Accel();
            //calls the method to update the label
            updateLabel();
        }

        private void btnBrake_Click(object sender, EventArgs e)
        {


            //calls for the acceleration to be incremented
            //has an if statement to stop the increment at 0
            carStuff.Brake();
            //calls the method to update the label
            updateLabel();
        }

        private void updateLabel()
        {
            //displays the text with the
            lblCarStuff.Text = "The speed of the " + carStuff.Year + " " + carStuff.Make + " is " + carStuff.Speed.ToString() + " MPH.";
            
            //The speed of the (year) (make) is (speed) mph.
        }

        private void lblCarStuff_Click(object sender, EventArgs e)
        {

        }
    }
}
