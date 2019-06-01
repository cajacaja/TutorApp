using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tutor_App.Nav
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuMaster : ContentPage
    {
        public ListView ListView;
        

        public MenuMaster()
        {
            InitializeComponent();

            BindingContext = new MenuMasterViewModel();
            ListView = MenuItemsListView;
           
           
        }

        protected override void OnAppearing()
        {
            studentIme.Text = Global.prijavljeniStudent.Ime + " " + Global.prijavljeniStudent.Prezime;
            studentPicture.Source = ImageSource.FromStream(() => new MemoryStream(Global.prijavljeniStudent.StudentskaSlika));
            base.OnAppearing();
        }

        class MenuMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MenuMenuItem> MenuItems { get; set; }
            
            public MenuMasterViewModel()
            {
                MenuItems = new ObservableCollection<MenuMenuItem>(new[]
                {
                    new MenuMenuItem { Id = 0,imageSource="profil.png", Title = "Profil",TargetType=typeof(StudentProfil) },
                    new MenuMenuItem { Id = 1,imageSource="search.png",Title = "Pretraga", TargetType=typeof(PretragaPage) },
                    new MenuMenuItem { Id = 2,imageSource="tutoricon.png" ,Title = "Moji casovi", TargetType=typeof(StudentCasovi)},
                    new MenuMenuItem { Id = 3, imageSource="ucioniaicon.png",Title = "Moje ucionice",TargetType=typeof(StudentUcionice) },
                   

                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }

        private void Logout_Clicked(object sender, EventArgs e)
        {
            Global.prijavljeniStudent = null;
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}