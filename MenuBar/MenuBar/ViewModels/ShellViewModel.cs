using System;
using System.Windows;
using System.Windows.Input;

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

using MenuBar.Contracts.Services;
using MenuBar.Strings;

namespace MenuBar.ViewModels
{
    public class ShellViewModel : ViewModelBase, IDisposable
    {
        private readonly INavigationService _navigationService;
        private readonly IRightPaneService _rightPaneService;

        private RelayCommand _goBackCommand;
        private ICommand _menuFileSettingsCommand;

        private ICommand _menuViewsWebViewCommand;

        private ICommand _menuViewsMasterDetailCommand;

        private ICommand _menuViewsMainCommand;

        private ICommand _menuFileExitCommand;

        public RelayCommand GoBackCommand => _goBackCommand ?? (_goBackCommand = new RelayCommand(OnGoBack, CanGoBack));

        public ICommand MenuFileSettingsCommand => _menuFileSettingsCommand ?? (_menuFileSettingsCommand = new RelayCommand(OnMenuFileSettings));

        public ICommand MenuFileExitCommand => _menuFileExitCommand ?? (_menuFileExitCommand = new RelayCommand(OnMenuFileExit));

        public ShellViewModel(INavigationService navigationService, IRightPaneService rightPaneService)
        {
            _navigationService = navigationService;
            _navigationService.Navigated += OnNavigated;
            _rightPaneService = rightPaneService;
        }

        public void Dispose()
        {
            _navigationService.Navigated -= OnNavigated;
        }

        private bool CanGoBack()
            => _navigationService.CanGoBack;

        private void OnGoBack()
            => _navigationService.GoBack();

        private void OnNavigated(object sender, string e)
            => GoBackCommand.RaiseCanExecuteChanged();

        private void OnMenuFileExit()
            => Application.Current.Shutdown();

        public ICommand MenuViewsMainCommand => _menuViewsMainCommand ?? (_menuViewsMainCommand = new RelayCommand(OnMenuViewsMain));

        private void OnMenuViewsMain()
            => _navigationService.NavigateTo(typeof(MainViewModel).FullName, null, true);

        public ICommand MenuViewsMasterDetailCommand => _menuViewsMasterDetailCommand ?? (_menuViewsMasterDetailCommand = new RelayCommand(OnMenuViewsMasterDetail));

        private void OnMenuViewsMasterDetail()
            => _navigationService.NavigateTo(typeof(MasterDetailViewModel).FullName, null, true);

        public ICommand MenuViewsWebViewCommand => _menuViewsWebViewCommand ?? (_menuViewsWebViewCommand = new RelayCommand(OnMenuViewsWebView));

        private void OnMenuViewsWebView()
            => _navigationService.NavigateTo(typeof(WebViewViewModel).FullName, null, true);

        private void OnMenuFileSettings()
            => _rightPaneService.OpenInRightPane(typeof(SettingsViewModel).FullName);
    }
}
