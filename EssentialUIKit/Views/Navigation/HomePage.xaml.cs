using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EssentialUIKit.DataService;
using EssentialUIKit.Views.Detail;
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

        public void OnImageNameTapped(object sender, EventArgs args)
        {
            try 
            {
                this.Navigation.PushAsync(new ServiceDetailPage(((TappedEventArgs)args).Parameter.ToString()));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}