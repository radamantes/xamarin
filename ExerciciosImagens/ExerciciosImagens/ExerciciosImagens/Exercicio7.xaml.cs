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
    public partial class Exercicio7 : ContentPage
    {
        public Exercicio7()
        {
            InitializeComponent();

            var image = new Image
            {
                Source = "https://developer.xamarin.com/demo/IMG_2188.JPG",
                Aspect = Aspect.AspectFit
            };

            var tapGestureRecognizer = new TapGestureRecognizer();

            image.GestureRecognizers.Add(tapGestureRecognizer);

            //SÓ EXECUTANDO O tapGestureRecognizer.Tapped += async (sender, e) => SE FOR CLICADO 2 X
            tapGestureRecognizer.NumberOfTapsRequired = 2;

            tapGestureRecognizer.Tapped += async (sender, e) =>
            {
                

                await DisplayAlert("Aviso", "Você clicou na imagem", "OK");
                image.Opacity = .5;
                await Task.Delay(2000);//DELAY PARA DÁ PARA VISUALIZAR A IMAGEM SENDO CLICADA
                image.Opacity = 1;
            };

            Content = image; //ATRIBUINDO O A IMAGEM AO CONTET DA PÁGINA
        }
    }
}