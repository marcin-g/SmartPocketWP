using SmartPocket.Intefaces.Model;
using System;
using System.ComponentModel;
using System.Data.Linq.Mapping;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace SmartPocket.ViewModels
{
    [Table]
    public class ChargeViewModel : INotifyPropertyChanged, ICharge
    {
        private int _id;
        /// <summary>
        /// Sample ViewModel property; this property is used to identify the object.
        /// </summary>
        /// <returns></returns>
        public ChargeViewModel()
        {
            CreatedAt = DateTime.Now;
        }
        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity", CanBeNull = false, AutoSync = AutoSync.OnInsert, UpdateCheck = UpdateCheck.Always)]
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value != _id)
                {
                    _id = value;
                    NotifyPropertyChanged("ID");
                }
            }
        }

        private int _externalID;

        [Column(UpdateCheck = UpdateCheck.Never, CanBeNull = true)]
        public int ExternalID
        {
            get
            {
                return _externalID;
            }
            set
            {
                if (value != _externalID)
                {
                    _externalID = value;
                    NotifyPropertyChanged("ExternalID");
                }
            }
        }
        private bool _isIncome;

        [Column(UpdateCheck = UpdateCheck.Never)]
        public bool IsIncome
        {
            get
            {
                return _isIncome;
            }
            set
            {
                if (value != _isIncome)
                {
                    _isIncome = value;
                    NotifyPropertyChanged("IsIncome");
                }
            }
        }

        private double _amount;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>

        [Column(UpdateCheck = UpdateCheck.Never)]
        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                if (value != _amount)
                {
                    _amount = value;
                    NotifyPropertyChanged("Amount");
                }
            }
        }

        private string _description;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>

        [Column(UpdateCheck = UpdateCheck.Never)]
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (value != _description)
                {
                    _description = value;
                    NotifyPropertyChanged("Description");
                }
            }
        }

        private DateTime _createdAt;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>

        [Column(UpdateCheck = UpdateCheck.Never)]
        public DateTime CreatedAt
        {
            get
            {
                return _createdAt;
            }
            set
            {
                if (value != _createdAt)
                {
                    _createdAt = value;
                    NotifyPropertyChanged("CreatedAt");
                }
            }
        }

        private DateTime _updatedAt;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>

        [Column(UpdateCheck = UpdateCheck.Never)]
        public DateTime UpdatedAt
        {
            get
            {
                return _updatedAt;
            }
            set
            {
                if (value != _updatedAt)
                {
                    _updatedAt = value;
                    NotifyPropertyChanged("UpdatedAt");
                }
            }
        }

        private System.Collections.Generic.ICollection<ITag> _tags;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public System.Collections.Generic.ICollection<ITag> Tags
        {
            get
            {
                return _tags;
            }
            set
            {
                if (value != _tags)
                {
                    _tags = value;
                    NotifyPropertyChanged("Tags");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            if (propertyName != "UpdatedAt")
            {
                this.UpdatedAt = DateTime.Now;
            }
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }



    }
}