using System.Reflection;
using System.Runtime.Serialization.Json;
using EssentialUIKit.ViewModels.Catalog;

namespace EssentialUIKit.DataService
{
    public class HomeDataService
    {
        #region fields

        private static HomeDataService instance;

        private HomePageViewModel homePageViewModel;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates an instance for the <see cref="HomeDataService"/> class.
        /// </summary>
        private HomeDataService()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets an instance of the <see cref="HomeDataService"/>.
        /// </summary>
        public static HomeDataService Instance => instance ?? (instance = new HomeDataService());

        /// <summary>
        /// Gets or sets the value of home page view model.
        /// </summary>
        public HomePageViewModel HomePageViewModel =>
            (this.homePageViewModel = PopulateData<HomePageViewModel>("medicalServices.json"));

        #endregion

        #region Methods

        /// <summary>
        /// Populates the data for view model from json file.
        /// </summary>
        /// <typeparam name="T">Type of view model.</typeparam>
        /// <param name="fileName">Json file to fetch data.</param>
        /// <returns>Returns the view model object.</returns>
        private static T PopulateData<T>(string fileName)
        {
            var file = "EssentialUIKit.Data." + fileName;

            var assembly = typeof(App).GetTypeInfo().Assembly;

            T obj;

            using (var stream = assembly.GetManifestResourceStream(file))
            {
                var serializer = new DataContractJsonSerializer(typeof(T));
                obj = (T)serializer.ReadObject(stream);
            }

            return obj;
        }

        #endregion
    }
}