using Mvvm.Sandbox.ViewModels;
using System.Windows;

namespace Mvvm.Sandbox
{
    public partial class MainWindow : Window
    {
        public MainWindow(UserViewModel viewModel)
        {
            // DataContext is just an "Object".  WPF uses this to bind to.  At run time, WPF will
            // try to cast this to an INotifyPropertyChanged, and subscribe to its propertychanged event;
            // hooking the name of the changed property up to any of the binding expressions you've included
            // in your XAML.
            //
            // Ideally this is the extent of the code-behind for your views.  Instead of EventHandlers for
            // button-clicks, you'd use Command bindings instead (more on that later!)
            DataContext = viewModel;
            InitializeComponent();
        }
    }
}