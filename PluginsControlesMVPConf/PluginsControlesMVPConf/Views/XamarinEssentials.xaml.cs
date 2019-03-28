using System;
using System.Collections.Generic;
using PluginsControlesMVPConf.ViewModels;
using Xamarin.Forms;

namespace PluginsControlesMVPConf.Views
{
    public partial class XamarinEssentials : ContentPage
    {
        public XamarinEssentials()
        {
            InitializeComponent();

            this.BindingContext = new XamarinEssentialsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            SetupBinding(BindingContext);
        }

        protected override void OnDisappearing()
        {
            TearDownBinding(BindingContext);

            base.OnDisappearing();
        }

        protected void SetupBinding(object bindingContext)
        {
            if (bindingContext is XamarinEssentialsViewModel vm)
            {
                vm.OnAppearing();
            }
        }

        protected void TearDownBinding(object bindingContext)
        {
            if (bindingContext is XamarinEssentialsViewModel vm)
            {
                vm.OnDisappearing();
            }
        }

    }
}
