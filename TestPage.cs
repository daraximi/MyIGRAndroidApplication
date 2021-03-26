using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App3.Droid.Resources.layout
{
    public class TestPage : ContentPage
    {
        private Button _button;
        private Label label;
       
        public TestPage ()
        {
            this.Title = "IGR 2019";

            StackLayout stackLayout = new StackLayout();

            label = new Label();
            label.Text = "Internally Generated Revenue in Nigeria for the year 2019";
            label.BackgroundColor = Color.PaleVioletRed;
            stackLayout.Children.Add(label);

            _button = new Button();
            _button.Text = "View Database Information";
            _button.Clicked += _button_Clicked;
            stackLayout.Children.Add(_button);

            _button = new Button();
            _button.Text = "Database Infographics";
            _button.Clicked += _button_ClickedTwo;
            stackLayout.Children.Add(_button);

            _button = new Button();
            _button.Text = "View Student Developer Information";
            _button.Clicked += _button_ClickedThree;
            stackLayout.Children.Add(_button);

            stackLayout.BackgroundColor = Color.Gray;
            Padding = new Thickness(5, 30, 0, 8);
            Content = stackLayout;
        }

        private async void _button_Clicked (Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
        private async void _button_ClickedTwo(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
        private async void _button_ClickedThree(Object sender, EventArgs e )
        {
            await Navigation.PushAsync(new Page3());
        }

    }
}