﻿using Xamarin.Forms;
using XamlFormsGallery.ViewModels;

namespace XamlFormsGallery.Views
{
    public partial class MapDemoView : ContentPage
    {
        public MapDemoView()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var viewModel = (MapDemoViewModel)BindingContext;
            viewModel.InitializeMap(Map);
        }
    }
}
