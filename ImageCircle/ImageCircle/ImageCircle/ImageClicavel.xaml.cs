using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImageCircle
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImageClicavel : ContentPage
	{
		public ImageClicavel ()
		{
			InitializeComponent ();

            //var image = new Image
            //{
            //    Source = "https://suateca.com/wp-content/uploads/2017/10/Curso-Desenvolvedor-Web-Completo.png",
            //    Aspect = Aspect.AspectFit
            //};

            //var tapGestureRecognizer = new TapGestureRecognizer();

            //tapGestureRecognizer.NumberOfTapsRequired = 2;

            //image.GestureRecognizers.Add(tapGestureRecognizer);

            //tapGestureRecognizer.Tapped += async (sender, e) =>
            //{
            //    image.Opacity = .5;
            //    await Task.Delay(1500);
            //    image.Opacity = 1;
            //};

            //Content = image;
         

        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            image.Opacity = .5;
            await Task.Delay(1500);
            image.Opacity = 1;
        }
    }
}