using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExerciciosScroll
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            StackLayout stack = new StackLayout();
            List<Button> buttons = new List<Button>();

            stack.Padding = 20;

            for (int i = 0; i <= 25; i++)
            {
             
                buttons.Add(new Button { Text = " " + i, BackgroundColor = Color.Yellow });
                stack.Children.Add(buttons[i]);//ADICIONANDO OS BUTÕES NA LISTA DE BOTÕES DA STACK

            }

            var scrollview = new ScrollView
            {
                Content = stack
            };

            Content = scrollview;

        }
    }
}
