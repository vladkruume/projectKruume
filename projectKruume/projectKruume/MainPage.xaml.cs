using Habanero.Faces.Base;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace projectKruume
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        StackLayout stackLayout;
        Button btnz, btno, btnu, btnd;
        Label lbl1;




        public MainPage()
        {
            BackgroundImageSource = ("z.jpg");
            
            lbl1 = new Label()
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
            btnz = new Button()
            {
                BackgroundColor = Color.FromHex("#76a21e"),
                TextColor = Color.FromHex("#560d0d"),
                HeightRequest = 70,
                Opacity = 0.8,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                Margin = new Thickness(70, 50, 70, 0),
                Text = "Завтрак"
            };
            btno = new Button()
            {
                BackgroundColor = Color.FromHex("#76a21e"),
                TextColor = Color.FromHex("#560d0d"),
                HeightRequest = 70,
                Opacity = 0.8,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                Margin = new Thickness(70, 37, 70, 0),
                Text = "Обед"
            };
            btnu = new Button()
            {
                BackgroundColor = Color.FromHex("#76a21e"),
                TextColor = Color.FromHex("#560d0d"),
                HeightRequest = 70,
                Opacity = 0.8,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                Margin = new Thickness(70, 37, 70, 0),
                Text = "Ужин"
            };
            btnd = new Button()
            {
                BackgroundColor = Color.FromHex("#76a21e"),
                TextColor = Color.FromHex("#560d0d"),
                HeightRequest = 70,
                Opacity = 0.8,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                Margin = new Thickness(70, 37, 70, 0),
                Text = "Десерт"
                
            };



            btnz.Clicked += Btne_ClickedAsync;
            btno.Clicked += Btnt_ClickedAsync;
            btnu.Clicked += Btnk_ClickedAsync;
            btnd.Clicked += Btnn_ClickedAsync;


            stackLayout = new StackLayout()
            {
                Children = { lbl1,btnz, btno, btnu, btnd}
            };
            stackLayout.Spacing = 15;
            this.Content = stackLayout;


        }

        private async void Btne_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Zavtrak());
        }

        private async void Btnt_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Obed());
        }

        private async void Btnk_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Uzin());
        }
        private async void Btnn_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Desert());
        }
    }
}