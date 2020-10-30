using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace MyPhotoshop.Data
{
    public class Pixel
    {
        public Pixel(double red, double green, double blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }

        //Red,Green and blue means saturation of each channel from 0 to 1 (converted from 0 to 255 format)
        //
        double red;
        double green;
        double blue;
        public double Red 
        { 
            get { return red; } 
            set 
            {
                red= CorrectingValue(value);
            } 
        }
        public double Green
        {
            get { return green; }
            set
            {
               green= CorrectingValue(value);
            }
        }
        public double Blue
        {
            get { return blue; }
            set
            {
               blue= CorrectingValue(value);
            }
        }
    
        public double CorrectingValue (double value)
        {
            if (value < 0)
                return 0;
            if (value > 1)
                return 1;
            return value;
        }
    }
}
