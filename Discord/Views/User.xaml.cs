using Discord.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Discord.Views
{
    /// <summary>
    /// User.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class User : UserControl
    {
        public string ImageUrl { get; set; }
        public string UserName { get; set; }
        public UserState UserState { get; set; }

        public static readonly DependencyProperty ImageUrlProperty = DependencyProperty.Register("ImageUrl", typeof(string), typeof(User), new PropertyMetadata(string.Empty));
        public static readonly DependencyProperty UserNameProperty = DependencyProperty.Register("UserName", typeof(string), typeof(User), new PropertyMetadata(string.Empty));
        public static readonly DependencyProperty UserStateProperty = DependencyProperty.Register("UserState", typeof(string), typeof(User), new PropertyMetadata(string.Empty));
        
        public User()
        {
            InitializeComponent();
        }
    }
}
