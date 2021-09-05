using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace EssentialUIKit.Views.Navigation
{
    /// <summary>
    /// About us with parallax scroll page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutUsPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:EssentialUIKit.Views.AboutUs.AboutUsWithParallaxScrollPage"/> class.
        /// </summary>
        public AboutUsPage()
        {
            InitializeComponent();
            //this.BindingContext = AlbumDataService.Instance.AlbumViewModel;
        }
    }
}