using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExerciciosImagens
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercicio10 : ContentPage
    {

        //inicia variável com 1 para pegar a primeira foto
        int _Id = 1;

        public Exercicio10()
        {
            InitializeComponent();

            LoadImage(); //carrega a imagem com o id 1


            //images.Source = new UriImageSource
            //{
            //    Uri = new Uri(str),
            //    CachingEnabled = false,
            //};
        }

        private void LoadImage()
        {
            string str = String.Format("http://lorempixel.com/1920/1080/city/{0}", _Id);//irá passar o parâmetro 1 para o variável str assim pegará a primeira foto

            images.Source = new UriImageSource
            {
                Uri = new Uri(str),
                CachingEnabled = false,
            };
        }

        private void proximo_Tapped(object sender, EventArgs e)
        {
            _Id++;
            if (_Id == 11)
                _Id = 1; //SE O CONTADO FOR IGUAL A 11 ELE DEFINI O CONTATO NOVAMENTE PARA 1 E LOGO CARREGA A IMAGEM AI A IMAGEM VOLTA PRA NÚMERO 1
           
            LoadImage();


            //string str = String.Format("http://lorempixel.com/1920/1080/city/{0}", _Id);

            //images.Source = new UriImageSource
            //{
            //    Uri = new Uri(str),
            //    CachingEnabled = false,
            //};
        }

        private async void anterior_Tapped(object sender, EventArgs e)
        {
            _Id--;
            if (_Id == 0) //SE O CONTADOR FOR IGUAL A 0 ELE DEFINI O CONTATO NOVAMENTE PARA 10 E LOGO CARREGA A IMAGEM AI A IMAGEM VOLTA PRA NÚMERO 10
                _Id = 10;
            LoadImage();

            //string str = String.Format("http://lorempixel.com/1920/1080/city/{0}", _Id);

            //images.Source = new UriImageSource
            //{
            //    Uri = new Uri(str),
            //    CachingEnabled = false,
            //};
        }
    }
}