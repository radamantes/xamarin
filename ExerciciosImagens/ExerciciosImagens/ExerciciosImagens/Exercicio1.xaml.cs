using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExerciciosImagens
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Exercicio1 : ContentPage
	{
		public Exercicio1 ()
		{
			InitializeComponent ();

            Image image1 = new Image();
            image1.Aspect = Aspect.AspectFill;



            // 1º FORMA DE FAZER
            //image1.Source = new UriImageSource
            //{
            //    Uri = new Uri("https://developer.xamarin.com/demo/IMG_2313.JPG")
            //};
            //************************************************************************************************

            // 2º FORMA DE FAZER
            image1.Source = ImageSource.FromUri(new Uri("https://developer.xamarin.com/demo/IMG_2313.JPG"));

            Content = image1;
		}
	}
}