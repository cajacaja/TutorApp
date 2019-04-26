using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Tutor_App
{
	public class Login : ContentPage
	{
		public Login ()
		{
            StackLayout stek = new StackLayout();
            stek.Margin = 25;
            stek.VerticalOptions = LayoutOptions.CenterAndExpand;

            Label label = new Label()
            {
                Text = "Prijava na aplikaciju",
                FontSize = 30,
                HorizontalTextAlignment = TextAlignment.Center
            };

            Entry korisnickoIme = new Entry()
            {
                Placeholder="Koricniko ime"
            };

            Entry Lozinka = new Entry()
            {
                Placeholder = "*******",
                IsPassword=true
                
            };

            Button prijavaButton = new Button() {Text="Prijava" };
            prijavaButton.Clicked += (sender, args) =>
            {
                DisplayAlert("Info", "Prijva na sistem ce uskoro biti omogucena!", "OK");
            };

            Button regButton = new Button() { Text = "Registracija" };
            regButton.Clicked += async (sender, args) =>
            {
              await  Navigation.PushAsync(new Registracija ());
            };


            stek.Children.Add(label);
            stek.Children.Add(korisnickoIme);
            stek.Children.Add(Lozinka);
            

            StackLayout stackButton = new StackLayout();

            stackButton.Children.Add(prijavaButton);
            stackButton.Children.Add(regButton);

            stackButton.Orientation = StackOrientation.Horizontal;
            stackButton.HorizontalOptions = LayoutOptions.End;

            stek.Children.Add(stackButton);

            Content = stek;

		}
	}
}