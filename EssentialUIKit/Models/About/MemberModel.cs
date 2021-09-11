using System.ComponentModel;
using Xamarin.Forms.Internals;

namespace EssentialUIKit.Models.About
{
    /// <summary>
    /// Model for About us templates.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class MemberModel : INotifyPropertyChanged
    {
        #region Fields

        private string empNo;
        private string empName;
        private string empDescription;
        private string image;

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
        /// <value>The name.</value>
        public string seqNo
        {
            get
            {
                return this.empNo;
            }

            set
            {
                this.empNo = value;
                this.OnPropertyChanged("seqNo");
            }
        }

        /// <summary>
        /// Gets or sets the name of an employee.
        /// </summary>
        /// <value>The name.</value>
        public string name
        {
            get
            {
                return this.empName;
            }

            set
            {
                this.empName = value;
                this.OnPropertyChanged("name");
            }
        }

        /// <summary>
        /// Gets or sets the designation of an employee.
        /// </summary>
        /// <value>The designation.</value>
        public string description
        {
            get
            {
                return this.empDescription;
            }

            set
            {
                this.empDescription = value;
                this.OnPropertyChanged("description");
            }
        }

        /// <summary>
        /// Gets or sets the image of an employee.
        /// </summary>
        /// <value>The image.</value>
        public string imageUrl
        {
            get
            {
                return this.image;
            }

            set
            {
                this.image = value;
                this.OnPropertyChanged("imageUrl");
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
