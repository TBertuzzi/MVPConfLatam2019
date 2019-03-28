using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PluginsControlesMVPConf
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void ffImageLoading_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PluginsControlesMVPConf.Views.FFImageLoading());
        }
    }
}
