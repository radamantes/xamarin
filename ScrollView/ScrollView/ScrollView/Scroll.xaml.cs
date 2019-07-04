using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScrollView
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Scroll : ContentPage
	{
		public Scroll ()
		{
			InitializeComponent ();

            var box1 = new BoxView
            {
                Color = Color.Blue,
                HeightRequest = 500,
                WidthRequest = 200
            };
            var box2 = new BoxView
            {
                Color = Color.Yellow,
                HeightRequest = 500,
                WidthRequest = 200
            };
            var box3 = new BoxView
            {
                Color = Color.Aqua,
                HeightRequest = 500,
                WidthRequest = 200
            };

            var stackLayout = new StackLayout
            {
                Spacing = 10,
                Children =
                {
                    box1,box2,box3
                }
            };

            var scrollview = new Xamarin.Forms.ScrollView
            {
                Content = stackLayout
            };
            Content = scrollview;
        }
	}
}