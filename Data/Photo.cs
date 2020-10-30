using MyPhotoshop.Data;
using System;

namespace MyPhotoshop
{
	public class Photo
	{
        public readonly int width;
        public readonly int height;
		public readonly Pixel [,] data;

        public Photo(int width, int height)
        {
            this.width = width;
            this.height = height;
            data = new Pixel[width, height];
        }
        public Pixel this[int x, int y]
        {
            get { return this.data[x, y]; }
        }
    }
}

