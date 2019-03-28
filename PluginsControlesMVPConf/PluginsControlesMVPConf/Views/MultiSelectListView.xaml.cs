using System;
using System.Collections.Generic;
using PluginsControlesMVPConf.ViewModels;
using Xamarin.Forms;

namespace PluginsControlesMVPConf.Views
{
    public partial class MultiSelectListView : ContentPage
    {
        public MultiSelectListView()
        {
            InitializeComponent();

            this.BindingContext = new MultiSelectListViewViewModel();
        }
    }
}
