using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExerciciosScroll
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaisagensScroll : ContentPage
    {
        public PaisagensScroll()
        {
            InitializeComponent();

            StackLayout stack = new StackLayout();
            List<string> imagens = GetImages(); //CRIA LISTA DE STRING DE IMAGENS E ADICIONA EM UMA LISTA IMAGENS

            stack.Padding = 15;

            for (int i = 0; i<imagens.Count; i++)
            {
                stack.Children.Add(new Image
                {
                    Source = imagens[i], //adicionando na proprieda source de cada imagem o endereçõ web de cada uma
                    HeightRequest = 250,
                    WidthRequest = 250,
                    Aspect = Aspect.AspectFill
                });
            }

            var scroll = new ScrollView
            {
                Content = stack
            };

            Content = scroll; //adicionando o scroll ao Content da pagina

        }

        //ADICIONAS STRINGS NA LISTA
        public List<string> GetImages()
        {
            List<string> listaImagens = new List<string>();

            listaImagens.Add("http://www.macoratti.net/Imagens/cidades/cidade1.jpg");
            listaImagens.Add("http://www.macoratti.net/Imagens/cidades/cidade2.jpg");
            listaImagens.Add("http://www.macoratti.net/Imagens/cidades/cidade3.jpg");
            listaImagens.Add("http://www.macoratti.net/Imagens/cidades/cidade4.jpg");

            return listaImagens;

        }
    }
}