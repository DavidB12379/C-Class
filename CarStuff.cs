using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

/*
Name: David Badrak
Date: 5/6/24
Program: class for car stuff
Description: class for car acceleration and braking
*/

namespace Car_Acceleration_and_Braking
{
    internal class CarStuff
    {
        //Variables
        private int _year;
        private string _make;
        private int _speed;

        public CarStuff(int year, string make)
        {
            _year = 2019;
            _make = "Tesla Model S";
            _speed = 0;
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        public string Make
        {
            get 
            { 
                return _make;
            }
            set
            {
                _make = value;
            }
            
        }

        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }

        public void Accel()
        {
            Speed += 5;
        }

        public void Brake()
        {
            Speed -= 5;
            if (Speed < 0)
            {
                Speed = 0;
            }
        }
    }
}
