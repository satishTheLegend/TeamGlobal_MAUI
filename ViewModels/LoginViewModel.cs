using Acr.UserDialogs;
using SkiaSharp.Extended.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TeamGlobal.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        #region Properties
        public event PropertyChangedEventHandler PropertyChanged;
        string _email = "";
        public string Email
        {
            get { return _email; }
            set { _email = value;
                OnPropertyChanged("Email"); }
        }

        bool _emailHasError = false;
        public bool EmailHasError
        {
            get { return _emailHasError; }
            set { _emailHasError = value; OnPropertyChanged("EmailHasError"); }
        }

        string password = "";
        public string Password
        {
            get { return password; }
            set { password = value;
                OnPropertyChanged("Password"); }
        }

        bool passwordHasError = false;
        public bool PasswordHasError
        {
            get { return passwordHasError; }
            set { passwordHasError = value; OnPropertyChanged("PasswordHasError"); }
        }
        #endregion

        #region Constructor
        public LoginViewModel()
        {

        }
        #endregion

        #region Commands
        public ICommand LoginCommand => new Command(() => LoginClicked());

        #endregion

        #region Event Handlers

        private void LoginClicked()
        {
            if(Validate())
            {
                //UserDialogs.Instance.Toast($"welcome {Email}");
                App.Current.MainPage.DisplayAlert("Login", $"welcome {Email}", "Ok");
            }
        }
        protected void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Public Methods
        public bool Validate()
        {
            PasswordHasError = !Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{5,}$");
            EmailHasError = !Regex.IsMatch(Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            return !PasswordHasError && !EmailHasError;
        }
        #endregion


    }
}
