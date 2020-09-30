using MyMvvmTemplate.Helpers;
using MyMvvmTemplate.ViewModel;

namespace MyMvvmTemplate
{
    class MainWidowViewModel : ObservableObject
    {
        #region Members
        private FirstViewModel _firstViewModel = new FirstViewModel();
        private SecondViewModel _secondViewModel = new SecondViewModel();
        private IViewModel _CurrentViewModel;
        #endregion

        #region Properties & Delegates
        public RelayCommand<string> NavCommand { get; private set; }
        public IViewModel CurrentViewModel
        {
            get => _CurrentViewModel;
            set { SetProperty(ref _CurrentViewModel, value); }
        }
        #endregion


        public MainWidowViewModel()
        {
            NavCommand = new RelayCommand<string>(OnNav);
            _CurrentViewModel = _firstViewModel;
        }

        #region Methods
        private void OnNav(string destination)
        {
            switch (destination)
            {
                case "FirstViewModel":
                    CurrentViewModel = _firstViewModel;
                    break;
                case "SecondViewModel":
                    CurrentViewModel = _secondViewModel;
                    break;
                default:
                    CurrentViewModel = _firstViewModel;
                    break;
            }
        }

        #endregion

    }

}
