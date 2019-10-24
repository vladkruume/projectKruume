﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectKruume
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Zavtrak : ContentPage
    {
        Label lbll;
        StackLayout stackLayout;
        public Zavtrak()
        {
            lbll = new Label()
            {
                Margin = new Thickness(50, 20, 50, 0),
                Text = "Рецепты",
                Opacity = 0.9,
                TextColor = Color.FromHex("#560d0d"),
                FontSize = 90,
                BackgroundColor = Color.FromHex("#76a21e"),
                HeightRequest = 100,
                FontAttributes = FontAttributes.Bold,
                TextDecorations = TextDecorations.Underline,


            };
            stackLayout = new StackLayout()
            {
                Children = { lbll}
            };
            stackLayout.Spacing = 15;
            this.Content = stackLayout;
        }
    }
}