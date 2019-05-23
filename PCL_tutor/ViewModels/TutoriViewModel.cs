using Newtonsoft.Json;
using PCL_tutor.Model;
using PCL_tutor.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PCL_tutor.ViewModels
{
    public class TutoriViewModel : INotifyPropertyChanged
    {

        private bool _isBusy;
        private const int PageSize = 10;

        private WebApiHelper tutorService = new WebApiHelper("http://192.168.0.102", "api/Tutor");
        public InfiniteScrollCollection<Tutori> Items { get; }

        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        public TutoriViewModel(int oblastId)
        {
            Items = new InfiniteScrollCollection<Tutori>
            {
                OnLoadMore = async () =>
                {
                    IsBusy = true;

                    // load the next page
                    var page = Items.Count / PageSize;

                    var items = await _dataService.GetItemsAsync(page, PageSize);

                    IsBusy = false;

                    // return the items that need to be added
                    return items;
                },
                OnCanLoadMore = () =>
                {
                    return Items.Count < 44;
                }
            };

            DownloadDataAsync(oblastId);
        }

        private async Task DownloadDataAsync(int oblasdtId)
        {
            HttpResponseMessage response = tutorService.GetActionResponse("SelectByOblast", oblasdtId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jasonObject = response.Content.ReadAsStringAsync();
                var items = JsonConvert.DeserializeObject<List<Tutori>>(jasonObject.Result);
                Items.AddRange(items);

            }
           
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
       
    }
}
