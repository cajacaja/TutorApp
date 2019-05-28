using Newtonsoft.Json;
using PCL_tutor.Model;
using PCL_tutor.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Tutor_App.ViewModels
{
    public class OcjeneTutorViewModel : INotifyPropertyChanged
    {
        int page = 1;
        private const int PageSize = 3;
        int TutorId = 0;


        private WebApiHelper ocjenaTutorService = new WebApiHelper("http://192.168.0.102", "api/OcjenaTutor");        
        public ObservableCollection<OcjenaTutor> Items { get; set; }
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

        public OcjeneTutorViewModel(int tutorId)
        {
            Items = new ObservableCollection<OcjenaTutor>();
            TutorId = tutorId;           
           
            LoadFirst();

            LoadComand = new Command(IncreaseList);
        }

        private void checkList()
        {
            var response = ocjenaTutorService.GetActionResponse("TutorReview", TutorId.ToString());
            var jasonObject = response.Content.ReadAsStringAsync();
            var ocjene = JsonConvert.DeserializeObject<List<OcjenaTutor>>(jasonObject.Result);
            if (ocjene != null)
                nextPage = Items.Count < ocjene.Count;
            else
                nextPage = false;
        }

        private async void LoadFirst()
        {

            var parametar = TutorId.ToString()+ "/" + page.ToString() + "/" + PageSize.ToString();
            HttpResponseMessage responseMessage = await Task.Run(() => ocjenaTutorService.GetActionResponse("studetComments", parametar));
            var jasonObject = responseMessage.Content.ReadAsStringAsync();
            var items = JsonConvert.DeserializeObject<List<OcjenaTutor>>(jasonObject.Result);
            ObservableCollection<OcjenaTutor> tempList = new ObservableCollection<OcjenaTutor>(items);
            foreach (var item in tempList)
            {
               
                Items.Add(item);
            }
            checkList();
        }

        private void IncreaseList(object obj)
        {
            if (nextPage)
            {
                page += 1;
                LoadFirst();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
