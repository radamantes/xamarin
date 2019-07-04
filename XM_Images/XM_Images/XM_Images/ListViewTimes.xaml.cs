using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XM_Images.Models;
using System.Collections.ObjectModel;

namespace XM_Images
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewTimes : ContentPage
    {
        public ListViewTimes()
        {
            InitializeComponent();

            
            lView.ItemsSource = new List<Time>
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
        }
    }
}