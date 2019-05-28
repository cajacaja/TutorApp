using Newtonsoft.Json;
using PCL_tutor.Model;
using PCL_tutor.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Tutor_App.ViewModels
{
    public class UcionicaViewModel: INotifyPropertyChanged
    {
        int page = 1;
        private const int PageSize = 3;
        int OblastId = 0;
        int GradId = 0;
        int TipStudentaId = 0;



        private WebApiHelper ucionicaService = new WebApiHelper("http://192.168.0.102", "api/Ucionica");

        public ObservableCollection<Ucionica> Items { get; set; }
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


        public UcionicaViewModel(int oblastId, int gradId, int tipStudentaId)
        {
            Items = new ObservableCollection<Ucionica>();
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
            var response = ucionicaService.GetActionResponse("selectMobileNum", parametar);
            var jasonObject = response.Content.ReadAsStringAsync();
            var ucionice = JsonConvert.DeserializeObject<int>(jasonObject.Result);

            nextPage = Items.Count < ucionice;
        }

        private async void LoadFirst()
        {

            var parametar = OblastId.ToString() + "/" + GradId.ToString() + "/" + TipStudentaId.ToString() + "/" + page.ToString() + "/" + PageSize.ToString();
            HttpResponseMessage responseMessage = await Task.Run(() => ucionicaService.GetActionResponse("selectMobile", parametar));
            var jasonObject = responseMessage.Content.ReadAsStringAsync();
            var items = JsonConvert.DeserializeObject<List<Ucionica>>(jasonObject.Result);
            ObservableCollection<Ucionica> tempList = new ObservableCollection<Ucionica>(items);
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
