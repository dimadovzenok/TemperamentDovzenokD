using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TemperamentDovzenokD
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();

            tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped;


            ContentPage content = new ContentPage();
            StackLayout stack = new StackLayout();
            Image image = new Image 
            {
                Source = "holerik.jpg",
                WidthRequest = 400,
                HeightRequest = 400,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            image.GestureRecognizers.Add(tapGestureRecognizer);

            stack.Children.Add(image);
            content.Content = stack;


            var holerikContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {   Text="Холерик",
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center},
                    }
                }
            };
            var sangvinikContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {   Text="Сангвиник",
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center},
                    new Image
                    {   Source = "sangvinik.jpg",
                        WidthRequest = 400,
                        HeightRequest = 400,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand}
                    }
                }
            };
            var flegmatikContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {   Text="Флегматик",
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center},

                    new Image
                    {   Source = "flegmatik.jpg",
                        WidthRequest = 400,
                        HeightRequest = 400,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand }
                    }
                }
            };
            var melanholikContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {   Text="Меланхолик",
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center},

                    new Image
                    {   Source = "melanholik.jpg",
                        WidthRequest = 400,
                        HeightRequest = 400,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand}
                    }
                }
            };
            Children.Add(holerikContentPage);
            Children.Add(sangvinikContentPage);
            Children.Add(flegmatikContentPage);
            Children.Add(melanholikContentPage);
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            await Browser.OpenAsync(uri);
        }
    }
}