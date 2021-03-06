﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutor_App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PretragaPage : ContentPage
	{
		public PretragaPage ()
		{
           
            InitializeComponent ();
		}

        private void TutorBtn_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new TutoriPage());
        }

        private void UcionicaBtn_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new UcionicePage());
        }
    }
}