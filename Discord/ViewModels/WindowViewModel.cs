using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows;
using System.Windows.Input;

namespace Discord.ViewModels
{
    public class WindowViewModel : ViewModelBase
    {
        public ICommand MinimizeCommand { get; set; }
        public ICommand MaximizeCommand { get; set; }
        public ICommand CloseCommand    { get; set; }
        public ICommand DragCommand     { get; set; }

        public Window mWindow { get; set; }

        public WindowViewModel()
        {
            MinimizeCommand = new RelayCommand(() => mWindow.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => mWindow.WindowState ^= WindowState.Maximized);
            CloseCommand    = new RelayCommand(() => mWindow.Close());
            DragCommand     = new RelayCommand(() => mWindow.DragMove());
        }
    }
}