using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Eventos
{
    public partial class MainPage : ContentPage
    {
        int i = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnClick_Clicked(object sender, EventArgs e)
        {            
            btnClick.Text = string.Format("Foi clicado " + i);
            i++;
        }
    }
}
