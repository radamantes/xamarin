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
    public partial class Exercicio8 : ContentPage
    {
        public Exercicio8()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            image.Opacity = 0.5;
            await Task.Delay(1000);
            image.Opacity = 1;
        }
    }
}