using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace AcademyF_ATCIT.Week8.FirstMiniApp.ViewModels.SignIn2
{
    public class SignIn2ViewModel : ViewModelBase
    {
        private string _username;
        private string _password;
        private bool _isBusy = false;
        public string Username 
        { 
            get 
            { 
                return _username; 
            } 
            set 
            { 
                _username = value; 
                RaisePropertyChanged();
            } 
        }
        
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                RaisePropertyChanged();
            }
        }
        public bool IsBusy
        {
            get { return _isBusy; }
            set { _isBusy = value; RaisePropertyChanged(); }
        }
        public ICommand LoginCommand { get; set; }
        public SignIn2ViewModel()
        {
            LoginCommand = new RelayCommand(ExecuteLogin, CanExecuteLogin);
            Username = "Inserisci il tuo Username";
            Password = "Inserisci la tua Password";
            IsBusy = false;
        }

        private bool CanExecuteLogin()
        {
            return !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password) && !IsBusy;
        }

        private void ExecuteLogin()
        {
            IsBusy = !IsBusy;
            MessageBox.Show($"Sto effettuando il login per {Username}");
            IsBusy = !IsBusy;
        }
        

    }
}
