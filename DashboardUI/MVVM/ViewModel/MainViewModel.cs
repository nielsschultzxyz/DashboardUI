using System.Windows;
using DashboardUI.Core;

namespace DashboardUI.MVVM.ViewModel;

public class MainViewModel : Core.ViewModel
{
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
    
    // ViewModels
    public DashboardViewModel DashboardVM { get; set; }
    public HelpViewModel HelpVM { get; set; }
    public HomeViewModel HomeVM { get; set; }
    public NotificationViewModel NotificationVM { get; set; }
    public SendMessageViewModel SendMessageVM { get; set; }
    public SettingsViewModel SettingsVM { get; set; }
    
    // ShowViewsRelayCommands
    public RelayCommand ShowDashboardViewCommand { get; set; }
    public RelayCommand ShowHelpViewCommand { get; set; }
    public RelayCommand ShowHomeViewCommand { get; set; }
    public RelayCommand ShowNotificationViewCommand { get; set; }
    public RelayCommand ShowSendMessageViewCommand { get; set; }
    public RelayCommand ShowSettingsViewCommand { get; set; }
    
    // Titelbar Command
    public RelayCommand MoveWindowCommand { get; set; }
    public RelayCommand MinimizeWindowCommand { get; set; }
    public RelayCommand MaximizeWindowCommand { get; set; }
    public RelayCommand ShutDownWindowCommand { get; set; }
    
    // ctor
    public MainViewModel()
    {
        // VMs
        DashboardVM = new DashboardViewModel();
        HelpVM = new HelpViewModel();
        HomeVM = new HomeViewModel();
        NotificationVM = new NotificationViewModel();
        SendMessageVM = new SendMessageViewModel();
        SettingsVM = new SettingsViewModel();
        
        //default View
        CurrentView = DashboardVM;
        
        // Set CurrentView
        ShowDashboardViewCommand = new RelayCommand(o => { CurrentView = DashboardVM; });
        ShowHelpViewCommand = new RelayCommand(o => { CurrentView = HelpVM; });
        ShowHomeViewCommand = new RelayCommand(o => { CurrentView = HomeVM; });
        ShowNotificationViewCommand = new RelayCommand(o => { CurrentView = NotificationVM; });
        ShowSendMessageViewCommand = new RelayCommand(o => { CurrentView = SendMessageVM; });
        ShowSettingsViewCommand = new RelayCommand(o => { CurrentView = SettingsVM; });
        
        // WindowCommands
        Application.Current.MainWindow.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        
        MoveWindowCommand = new RelayCommand(o => { Application.Current.MainWindow.DragMove(); });
        MinimizeWindowCommand = new RelayCommand(o =>
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
            
        });
        MaximizeWindowCommand = new RelayCommand(o =>
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
        });
        ShutDownWindowCommand = new RelayCommand(o => { Application.Current.Shutdown(); });

    }
}