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
	public partial class Exercicio5 : ContentPage
	{
		public Exercicio5 ()
		{
			InitializeComponent ();

            images.Source = ImageSource.FromResource("ExerciciosImagens.Imagens.anterio64.jpg");
            
            
		}
	}
}