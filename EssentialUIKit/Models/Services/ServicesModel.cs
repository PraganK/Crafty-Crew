﻿using System.ComponentModel;
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

        private string _price;

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
        public string price
        {
            get
            {
                return this._price;
            }

            set
            {
                this._price = value;
                this.OnPropertyChanged("price");
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