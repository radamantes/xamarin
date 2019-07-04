using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XM_Images.Models;

namespace XM_Images
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPageCode : ContentPage
    {
        public ListViewPageCode()
        {
            InitializeComponent();

            var listview = new Xamarin.Forms.ListView();

            listview.ItemsSource = new List<Time>
            {
                 new Time{
                    Nome = "Palmeiras",
                    Pontos =60 ,
                    ImagemUrl ="http://macoratti.net/Imagens/times/palmeiras64.png"
                },
                new Time
                {
                    Nome = "Flamengo",
                    Pontos =60 ,
                    ImagemUrl ="http://macoratti.net/Imagens/times/flamengo64.jpg"
                },
                new Time{
                    Nome = "Santos",
                    Pontos =60 ,
                    ImagemUrl ="http://macoratti.net/Imagens/times/santos64.jpg"
                },
                 new Time{
                    Nome = "Botafogo",
                    Pontos =60 ,
                    ImagemUrl ="http://macoratti.net/Imagens/times/botafogo64.jpg"
                }
            };

            listview.ItemTemplate = new DataTemplate(typeof(ImageCell));
            listview.ItemTemplate.SetBinding(ImageCell.ImageSourceProperty, "ImagemUrl");
            listview.ItemTemplate.SetBinding(ImageCell.TextProperty, "Nome");
            listview.ItemTemplate.SetBinding(ImageCell.DetailProperty, "Pontos");

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    this.Padding = new Thickness(20, 0, 0, 0);
                    break;

                default:
                    Padding = new Thickness(5, 5, 5, 0);
                    break;
            }

            Content = listview;
        }

    }
}