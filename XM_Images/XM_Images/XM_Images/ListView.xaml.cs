using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XM_Images
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListView : ContentPage
	{
		public ListView ()
		{
			InitializeComponent ();

            List<String> itens = new List<String>()
            {
                "Palmeiras",
                "Cruzeiro",
                "Flamengo",
                "Barcelona",
                "Fluminense"
            };

            lView.ItemsSource = itens;
        }

        private void LView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Item selecionado; ", e.SelectedItem.ToString(), "Ok");
        }
    }
}