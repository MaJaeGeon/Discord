using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Discord.Views
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : WindowBase
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void ServerButton_Checked(object sender, RoutedEventArgs e)
        //{
        //    ServerView.Source = new Uri("ServerPage.xaml", UriKind.Relative);
        //}

        //private void HomeButton_Checked(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        ServerView.Source = new Uri("HomePage.xaml", UriKind.Relative);
        //    }
        //    catch
        //    {
        //        return;
        //    }
        //}
    }
}
