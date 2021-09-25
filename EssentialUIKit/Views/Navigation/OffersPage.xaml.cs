using EssentialUIKit.DataService;
using EssentialUIKit.ViewModels.Services;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace EssentialUIKit.Views.Navigation
{
    /// <summary>
    /// Page to show the catalog list. 
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OffersPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OffersPage" /> class.
        /// </summary>
        public OffersPage()
        {
            InitializeComponent();
            this.BindingContext = ShoppingDataService.Instance.CatalogPageViewModel;

            this.BindingContext = new ServicesViewModel();
        }
    }
}