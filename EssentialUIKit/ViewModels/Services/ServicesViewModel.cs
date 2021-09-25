using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using EssentialUIKit.Models.Services;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Internals;


namespace EssentialUIKit.ViewModels.Services
{

    [Preserve(AllMembers = true)]
    public class ServicesViewModel : INotifyPropertyChanged
    {
        private string _profileImage;

        private List<ServicesModel> _lstServices;


        public string ProfileImage
        {
            get
            {
                return this._profileImage;
            }

            set
            {
                this._profileImage = value;
                this.OnPropertyChanged("ProfileImage");
            }
        }

        public List<ServicesModel> lstServices
        {
            get
            {
                return this._lstServices;
            }

            set
            {
                this._lstServices = value;
                this.OnPropertyChanged("lstServices");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public Command ItemSelectedCommand { get; set; }

        public ServicesViewModel()
        {
            this.ProfileImage = "http://devathondemo.appspot.com/images/pragan.png";

            string json = (new WebClient()).DownloadString("https://devathondemo.appspot.com/listOfServices/");
            var services  = JsonConvert.DeserializeObject<ServicesModel[]>(json);

            _lstServices = new List<ServicesModel>();

            this.ServiceDetails = new ObservableCollection<ServicesModel>();

            foreach (var item in services)
            {
                this.lstServices.Add(
                     new ServicesModel
                     {
                         serviceId = item.serviceId,
                         title = item.title,
                         subTitle = item.subTitle,
                         shortDesc = item.shortDesc,
                         longDesc = item.longDesc,
                         category = item.category,
                         imagePath = item.imagePath,

                         cost = item.cost, 
                         discount = ((Convert.ToDecimal(item.cost) - Convert.ToDecimal(item.cost) * Convert.ToDecimal("0.10"))).ToString()
                     }); 
            }

            this.ItemSelectedCommand = new Command(this.ItemSelected);
        }

        public ServicesViewModel(string cat)
        {
            
            string json = (new WebClient()).DownloadString("https://devathondemo.appspot.com/listOfServices/");
            var services = JsonConvert.DeserializeObject<ServicesModel[]>(json);

            _lstServices = new List<ServicesModel>();

            this.ServiceDetails = new ObservableCollection<ServicesModel>();

            foreach (var item in services.Where(x => x.category == cat))
            {
                this.lstServices.Add(
                     new ServicesModel
                     {
                         serviceId = item.serviceId,
                         title = item.title,
                         subTitle = item.subTitle,
                         shortDesc = item.shortDesc,
                         longDesc = item.longDesc,
                         category = item.category,
                         imagePath = item.imagePath,

                         cost = item.cost,
                         discount = ((Convert.ToDecimal(item.cost) - Convert.ToDecimal(item.cost) * Convert.ToDecimal("0.10"))).ToString()
                     });
            }

            this.ItemSelectedCommand = new Command(this.ItemSelected);
        }

        public ObservableCollection<ServicesModel> ServiceDetails { get; set; }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Invoked when an item is selected.
        /// </summary>
        private void ItemSelected(object selectedItem)
        {
            // Do something
        }

    }
}
