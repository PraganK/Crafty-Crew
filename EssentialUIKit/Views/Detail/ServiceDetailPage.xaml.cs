using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using EssentialUIKit.ViewModels.Detail;
namespace EssentialUIKit.Views.Detail
{
    /// <summary>
    /// Article detail page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServiceDetailPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:EssentialUIKit.Views.Detail.ServiceDetailPage"/> class.
        /// </summary>
        public ServiceDetailPage(string key)
        {

            this.BindingContext =new  ServiceDetailPageViewModel(key);


            InitializeComponent();

         //   this.BindingContext = HomeDataService.Instance.HomePageViewModel;


        }
    }
}