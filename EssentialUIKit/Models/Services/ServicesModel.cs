using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Xamarin.Forms.Internals;

namespace EssentialUIKit.Models.Services
{
    /// <summary>
    /// Model for About us templates.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class ServicesModel : INotifyPropertyChanged
    {
        #region Fields
        private string _serviceId;
        private string _title;
        private string _subTitle;
        private string _shortDesc;
        private string _longDesc;
        private string _category;
        private string _imagePath;

        private string _cost;
        private string _discount;

        private List<string> _packages;
        #endregion

        #region EventHandler

        /// <summary>
        /// EventHandler of property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the name of seq.
        /// </summary>
        /// <value>The service Id.</value>
        public string serviceId
        {
            get
            {
                return this._serviceId;
            }

            set
            {
                this._serviceId = value;
                this.OnPropertyChanged("serviceId");
            }
        }
        /// <summary>
        /// Gets or sets the name of seq.
        /// </summary>
        /// <value>The name.</value>
        public string title
        {
            get
            {
                return this._title;
            }

            set
            {
                this._title = value;
                this.OnPropertyChanged("title");
            }
        }
        public string cost
        {
            get
            {
                return this._cost;
            }

            set
            {
                this._cost = value;
                this.OnPropertyChanged("cost");
            }
        }

        public string discount
        {
            get
            {
                return this._discount;
            }

            set
            {
                this._discount = value;
                this.OnPropertyChanged("discount");
            }
        }

        /// <summary>
        /// Gets or sets the name of an employee.
        /// </summary>
        /// <value>The name.</value>
        public string subTitle
        {
            get
            {
                return this._subTitle;
            }

            set
            {
                this._subTitle = value;
                this.OnPropertyChanged("subTitle");
            }
        }

        /// <summary>
        /// Gets or sets the designation of an employee.
        /// </summary>
        /// <value>The designation.</value>
        public string shortDesc
        {
            get
            {
                return this._shortDesc;
            }

            set
            {
                this._shortDesc = value;
                this.OnPropertyChanged("shortDesc");
            }
        }

        public string longDesc
        {
            get
            {
                return this._longDesc;
            }

            set
            {
                this._longDesc = value;
                this.OnPropertyChanged("longDesc");
            }
        }

        public string category
        {
            get
            {
                return this._category;
            }

            set
            {
                this._category = value;
                this.OnPropertyChanged("category");
            }
        }


        /// <summary>
        /// Gets or sets the image of an employee.
        /// </summary>
        /// <value>The image.</value>
        public string imagePath
        {
            get
            {
                return this._imagePath;
            }

            set
            {
                this._imagePath = value;
                this.OnPropertyChanged("imagePath");
            }
        }

        [DataMember(Name = "period")]
        public List<string> Period { get; set; } = new List<string> { "One-time", "1 Week", "1 Month", "6 Months", " 1 Year" };


        /// <summary>
        /// Gets or sets the image of an employee.
        /// </summary>
        /// <value>The image.</value>
        public List<string> packages
        {
            get
            {
                return this._packages;
            }

            set
            {
                this._packages = value;
                this.OnPropertyChanged("packages");
            }
        }
        #endregion

        #region Methods

        /// <summary>
        /// The PropertyChanged event occurs when changing the value of property.
        /// </summary>
        /// <param name="propertyName">The PropertyName</param>
        protected void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
