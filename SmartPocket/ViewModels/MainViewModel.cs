using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using SmartPocket.Resources;

namespace SmartPocket.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        /// <summary>
        /// Sample property that returns a localized string
        /// </summary>
        public string LocalizedSampleProperty
        {
            get
            {
                return AppResources.SampleProperty;
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            // Sample data; replace with real data
            this.Items.Add(new ItemViewModel() { ID = 0, Amount = 100, CreatedAt = new DateTime(2014, 1, 15), UpdatedAt = new DateTime(2014, 1, 15), Description = "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu" });
            this.Items.Add(new ItemViewModel() { ID = 1, Amount = 1001, CreatedAt = new DateTime(2014, 1, 15), UpdatedAt = new DateTime(2014, 1, 15), Description = "Suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus" });
            this.Items.Add(new ItemViewModel() { ID = 2, Amount = 1002, CreatedAt = new DateTime(2014, 1, 15), UpdatedAt = new DateTime(2014, 1, 15), Description = "Habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent" });
            this.Items.Add(new ItemViewModel() { ID = 3, Amount = 1003, CreatedAt = new DateTime(2014, 1, 15), UpdatedAt = new DateTime(2014, 1, 15), Description = "Ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos" });
            this.Items.Add(new ItemViewModel() { ID = 4, Amount = 1004, CreatedAt = new DateTime(2014, 1, 15), UpdatedAt = new DateTime(2014, 1, 15), Description = "Maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur" });
            this.Items.Add(new ItemViewModel() { ID = 5, Amount = 1005, CreatedAt = new DateTime(2014, 1, 15), UpdatedAt = new DateTime(2014, 1, 15), Description = "Pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent" });
            this.Items.Add(new ItemViewModel() { ID = 6, Amount = 1006, CreatedAt = new DateTime(2014, 1, 15), UpdatedAt = new DateTime(2014, 1, 15), Description = "Accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat" });
            this.Items.Add(new ItemViewModel() { ID = 7, Amount = 1007, CreatedAt = new DateTime(2014, 1, 15), UpdatedAt = new DateTime(2014, 1, 15), Description = "Pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum" });
            this.Items.Add(new ItemViewModel() { ID = 8, Amount = 1008, CreatedAt = new DateTime(2014, 1, 15), UpdatedAt = new DateTime(2014, 1, 15), Description = "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu" });
            this.Items.Add(new ItemViewModel() { ID = 9, Amount = 1009, CreatedAt = new DateTime(2014, 1, 15), UpdatedAt = new DateTime(2014, 1, 15), Description = "Suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus" });
            this.Items.Add(new ItemViewModel() { ID = 10, Amount = 10022, CreatedAt = new DateTime(2014, 1, 15), UpdatedAt = new DateTime(2014, 1, 15), Description = "Habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent" });
            this.Items.Add(new ItemViewModel() { ID = 11, Amount = 100123, CreatedAt = new DateTime(2014, 1, 15), UpdatedAt = new DateTime(2014, 1, 15), Description = "Ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos" });
            this.Items.Add(new ItemViewModel() { ID = 12, Amount = 10032, CreatedAt = new DateTime(2014, 1, 15), UpdatedAt = new DateTime(2014, 1, 15), Description = "Maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur" });
            this.Items.Add(new ItemViewModel() { ID = 13, Amount = 10210, CreatedAt = new DateTime(2014, 1, 15), UpdatedAt = new DateTime(2014, 1, 15), Description = "Pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent" });
            this.Items.Add(new ItemViewModel() { ID = 14, Amount = 103210, CreatedAt = new DateTime(2014, 1, 15), UpdatedAt = new DateTime(2014, 1, 15), Description = "Accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat" });
            this.Items.Add(new ItemViewModel() { ID = 15, Amount = 1040, CreatedAt = new DateTime(2014, 1, 15), UpdatedAt = new DateTime(2014, 1, 15), Description = "Pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum" });

            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}