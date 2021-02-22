using Discord.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows;
using System.Windows.Input;

namespace Discord.ViewModels
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            ViewServerCommand = new RelayCommand<Server>(ViewServer);
        }

        #region Properties

        public string ServerViewTemplate
        {
            get
            {
                return _serverViewTemplate;
            }
            set
            {
                if (_serverViewTemplate == value) return;

                _serverViewTemplate = value;
                RaisePropertyChanged();
            }
        }
        private string _serverViewTemplate = "HomePage.xaml";

        public Server ServerViewSource
        {
            get { return _serverViewSource; }
            set
            {
                if (_serverViewSource == value) return;
                _serverViewSource = value;

                RaisePropertyChanged();
            }
        }
        private Server _serverViewSource;

        #endregion

        #region Commands

        public RelayCommand<Server> ViewServerCommand { get; }

        private void ViewServer(Server arg)
        {
            ServerViewTemplate = arg.Template;
            ServerViewSource = arg;
        }

        #endregion
    }
}