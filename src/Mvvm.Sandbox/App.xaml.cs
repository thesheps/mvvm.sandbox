using Mvvm.Sandbox.ViewModels;
using System.Windows;

namespace Mvvm.Sandbox
{
    // Here's where you'd set up your IoC container and any dependencies.  You'd inject your
    // view model straight into your View.
    public partial class App : Application
    {
        public App()
        {
            var viewModel = new UserViewModel();
            var window = new MainWindow(viewModel);
            window.Show();
        }
    }
}
