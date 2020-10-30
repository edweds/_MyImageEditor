

namespace MyPhotoshop.Data
{
    public struct Pixel
    {
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
        public static double CorrectingValue (double value)
        {
            if (value < 0)
                return 0;
            if (value > 1)
                return 1;
            return value;
        }
        public static Pixel operator*(Pixel pixel,double x)
        {
            var result = new Pixel();
            result.Red = pixel.Red * x;
            result.Green = pixel.Green * x;
            result.Blue = pixel.Blue * x;
            return result;
        }

        public static Pixel operator*( double x, Pixel pixel)
        {
            return pixel*x;
        }

    }
}
