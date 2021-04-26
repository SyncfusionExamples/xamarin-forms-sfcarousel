using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GettingStarted
{
    public class CarouselViewModel
    {
        public CarouselViewModel()
        {
            ImageCollection.Add(new CarouselModel("image1.png"));
            ImageCollection.Add(new CarouselModel("image2.png"));
            ImageCollection.Add(new CarouselModel("image3.png"));
            ImageCollection.Add(new CarouselModel("image4.png"));
            ImageCollection.Add(new CarouselModel("image5.png"));
        }
        private List<CarouselModel> imageCollection = new List<CarouselModel>();
        public List<CarouselModel> ImageCollection
        {
            get { return imageCollection; }
            set { imageCollection = value; }
        }
    }
}