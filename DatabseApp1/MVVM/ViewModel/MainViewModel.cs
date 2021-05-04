using DatabaseApplication.Core;

namespace DatabaseApplication.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public HomeViewModel HomeViewModel { get; set; }
        public OrdersViewModel OrdersViewModel { get; set; }
        public CustomersViewModel CustomerViewModel { get; set; }
        public AddCustomerViewModel AddCustomerViewModel { get; set; }
        public AddOrderViewModel AddOrderViewModel { get; set; }

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand OrdersViewCommand { get; set; }
        public RelayCommand CustomerViewCommand { get; set; }
        public RelayCommand AddCustomerViewCommand { get; set; }
        public RelayCommand AddOrderViewCommand { get; set; }

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            HomeViewModel = new HomeViewModel();
            OrdersViewModel = new OrdersViewModel();
            CustomerViewModel = new CustomersViewModel();
            AddCustomerViewModel = new AddCustomerViewModel();
            AddOrderViewModel = new AddOrderViewModel();

            CurrentView = HomeViewModel;

            HomeViewCommand = new RelayCommand(o => { CurrentView = HomeViewModel; });
            OrdersViewCommand = new RelayCommand(o => { CurrentView = OrdersViewModel; });
            CustomerViewCommand = new RelayCommand(o => { CurrentView = CustomerViewModel; });
            AddCustomerViewCommand = new RelayCommand(o => { CurrentView = AddCustomerViewModel; });
            AddOrderViewCommand = new RelayCommand(o => { CurrentView = AddOrderViewModel; });
        }
    }
}
