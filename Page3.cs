using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App3.Droid.Resources.layout
{
    public class Page3 : ContentPage
    {
        public Page3 ()
        {
            this.Title = "About The Developer";
            Content = new Label
            {
                Text = "Developed by Oloyede Oluwadarasimi Promise"
                + " 17CJ022535"
                + " Computer Engineering" + "  © 2021 ",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.Black,
                BackgroundColor = Color.LightCyan
            };
            Padding = new Thickness(5, 20, 0, 8);
        }
    }
}