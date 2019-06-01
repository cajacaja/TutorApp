using Newtonsoft.Json;
using PCL_tutor.Model;
using PCL_tutor.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
//using System;
using System.ComponentModel;
using System.Linq;

using System.Net.Http;
using System.Runtime.CompilerServices;

using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;

namespace Tutor_App.ViewModels
{
    public class TutoriViewModel : INotifyPropertyChanged
    {

        
        int page = 1;
        private const int PageSize =3;
        int OblastId = 0;
        int GradId = 0;
        int TipStudentaId = 0;
        
        
        
        private WebApiHelper tutorService = new WebApiHelper("Tutor");

        public ObservableCollection<Tutori> Items { get; set; }
        public ICommand LoadComand { get; set; }

        private bool _nextPage;       

        public bool nextPage
        {
            get
            {
                return _nextPage;
            }
            set
            {
                _nextPage = value;
                OnPropertyChanged(nameof(nextPage));
            }
        }


        public TutoriViewModel(int oblastId,int gradId,int tipStudentaId)
        {
            Items = new ObservableCollection<Tutori>();
            OblastId = oblastId;
            GradId = gradId;
            TipStudentaId = tipStudentaId;
            LoadFirst();

            LoadComand = new Command(IncreaseList);
           
            
        }

        private void IncreaseList(object obj)
        {
            if (nextPage)
            {
                page += 1;
                LoadFirst();
            }
        }

        private void checkList()
        {
            var parametar = OblastId.ToString() + "/" + GradId.ToString() + "/" + TipStudentaId.ToString();
            var response = tutorService.GetActionResponse("TutorCount",parametar);
            var jasonObject = response.Content.ReadAsStringAsync();
            var tutori = JsonConvert.DeserializeObject<int>(jasonObject.Result);
           
            nextPage= Items.Count < tutori;            
        }

        private async void LoadFirst()
        {
            
            var parametar = OblastId.ToString() + "/" + GradId.ToString() + "/" + TipStudentaId.ToString() + "/" + page.ToString() + "/" + PageSize.ToString();
            HttpResponseMessage responseMessage = await Task.Run(()=> tutorService.GetActionResponse("SelectByOblast", parametar));
            var jasonObject = responseMessage.Content.ReadAsStringAsync();
            var items = JsonConvert.DeserializeObject<List<Tutori>>(jasonObject.Result);
            ObservableCollection<Tutori> tempList = new ObservableCollection<Tutori>(items);
            foreach (var item in tempList)
            {
               
                Items.Add(item);
            }
            checkList();
        }

        

        

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
       
    }
}
