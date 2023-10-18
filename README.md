# Xamarin Carousel View (SfCarousel) 

The Essential Xamarin Carousel control allows navigating through image data in an interactive way so that they can be viewed or selected. Also, provides various customization options for its item arrangements.

For know more details about Carousel: https://www.syncfusion.com/xamarin-ui-controls/xamarin-carousel-view

Carousel user guide documentation: https://help.syncfusion.com/xamarin/carousel-view/getting-started
# Getting Started with Xamarin Carousel View (SfCarousel)

This section explains how to showcase a Gallery of photos along with a Title using Xamarin Carousel View (SfCarousel) Control.

# Create a Simple SfCarousel
The Xamarin Carousel View (SfCarousel) control is configured entirely in C# code or by using XAML markup. The following steps explain on how to create a SfCarousel and configure its elements,

*   Adding namespace for the added assemblies.
**[XAML]**

```
xmlns:carousel="clr-namespace:Syncfusion.SfCarousel.XForms;assembly=Syncfusion.SfCarousel.XForms"
```
*   Now add the SfCarousel control with a required optimal name by using the included namespace.
**[XAML]**
```
    <carousel:SfCarousel x:Name="carousel" />
```

# Add Carousel Items
We can populate the carousel’s items by using any one of the following ways,

*   Through SfCarouselItem

*   Through ItemTemplate

##  Through SfCarouselItem
By passing the list of SfCarouselItem , we can get the view of SfCarousel control. In that we can pass Images as well as Item content.

The following code example illustrates to add list of Images in Carousel ,

**[C#]**
```
using Syncfusion.SfCarousel.XForms;
using System.Collections.ObjectModel;
using Xamarin.Forms;
namespace CarouselSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfCarousel carousel = new SfCarousel()
            {
                ItemWidth = 170,
                ItemHeight = 250
            };
            ObservableCollection<SfCarouselItem> carouselItems = new ObservableCollection<SfCarouselItem>();
            carouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person1.png" });
            carouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person2.png" });
            carouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person3.png" });
            carouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person4.png" });
            carouselItems.Add(new SfCarouselItem() { ImageName = "carousel_person5.png" });
            carousel.ItemsSource = carouselItems;
            this.Content = carousel;
        }
    }
}
```
The following code example illustrates to add list of Item in Carousel ,

**[C#]**
```
using Syncfusion.SfCarousel.XForms;
using System.Collections.ObjectModel;
using Xamarin.Forms;
namespace CarouselSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfCarousel carousel = new SfCarousel()
            {
                ItemWidth = 170,
                ItemHeight = 250
            };
            ObservableCollection<SfCarouselItem> carouselItems = new ObservableCollection<SfCarouselItem>();
            carouselItems.Add(new SfCarouselItem()
            {
                ItemContent = new Button()
                {
                    Text = "ItemContent1",
                    TextColor = Color.White,
                    BackgroundColor = Color.FromHex("#7E6E6B"),
                    FontSize = 12
                }
            });
            carouselItems.Add(new SfCarouselItem()
            {
                ItemContent = new Label()
                {
                    Text = "ItemContent2",
                    BackgroundColor = Color.FromHex("#7E6E6B"),
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center,
                    FontSize = 12
                }
            });
            carouselItems.Add(new SfCarouselItem()
            {
                ItemContent = new Image()
                {
                    Source = "carousel_person1.png",
                    Aspect = Aspect.AspectFit
                }
            });
            carousel.ItemsSource = carouselItems;
            this.Content = carousel;
        }
    }
}
```
## Through ItemTemplate
ItemTemplate property of Xamarin Carousel View (SfCarousel) control is used to customize the contents of SfCarousel items.

*   Create a model view which holds image data

```
namespace CarouselSample
{
    public class CarouselModel
    {
        public CarouselModel(string imageString)
        {
            Image = imageString;
        }
        private string _image;
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }
}
```
*   Populate carousel items collection in View model with the image data.
```
using System.Collections.Generic;
namespace CarouselSample
{
    public class CarouselViewModel
    {
        public CarouselViewModel()
        {
            ImageCollection.Add(new CarouselModel("carousel_person1.png"));
            ImageCollection.Add(new CarouselModel("carousel_person2.png"));
            ImageCollection.Add(new CarouselModel("carousel_person3.png"));
            ImageCollection.Add(new CarouselModel("carousel_person4.png"));
            ImageCollection.Add(new CarouselModel("carousel_person5.png"));
        }
        private List<CarouselModel> imageCollection = new List<CarouselModel>();
        public List<CarouselModel> ImageCollection
        {
            get { return imageCollection; }
            set { imageCollection = value; }
        }
    }
}
```
The following code illustrates the way to use ItemTemplate in both XAML as well as C#

**[C#]**
```
<ContentPage.BindingContext>
        <local:CarouselViewModel/>
    </ContentPage.BindingContext>
    <ContentPage.Resources>
        <ResourceDictionary>
            <DataTemplate x:Key="itemTemplate">
                <Image Source="{Binding Image}" 
                       Aspect="AspectFit"/>
            </DataTemplate>
        </ResourceDictionary>
    </ContentPage.Resources>
    <ContentPage.Content>
        <carousel:SfCarousel x:Name="carousel"  
                             ItemTemplate="{StaticResource itemTemplate}" 
                             ItemsSource="{Binding ImageCollection}" 
                             HeightRequest="400" 
                             WidthRequest="800" />
</ContentPage.Content>
```