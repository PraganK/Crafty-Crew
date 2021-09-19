using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EssentialUIKit.DataService;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
 
namespace EssentialUIKit.Views.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

          

            //this.BindingContext = HomeDataService.Instance.HomePageViewModel;
        }
    }
}