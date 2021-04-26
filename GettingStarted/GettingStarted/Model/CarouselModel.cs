using System;
using System.Collections.Generic;
using System.Text;

namespace GettingStarted
{
    public class CarouselModel
    {
        public CarouselModel(string imagestr)
        {
            Image = imagestr;
        }
        private string _image;

        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}
