using System.ComponentModel;

namespace Mvvm.Sandbox.ViewModels
{
    // Whenever any of the properties change, just make sure to raise the PropertyChangedEvent.
    // This is the sticky boilerplate code which you kinda have to dupe for every ViewModel.  There
    // are some nice frameworks that do this stuff fairly elegantly using generics, and you CAN roll your own
    public class UserViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Username 
        {
            get { return _username; }
            
            set 
            {
                _username = value;
                OnPropertyChanged("Username");
            }
        }

        public string FirstName
        {
            get { return _firstName; }

            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return _lastName; }

            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                var args = new PropertyChangedEventArgs(propertyName);
                PropertyChanged(this, args);
            }
        }

        private string _username;
        private string _firstName;
        private string _lastName;
    }
}