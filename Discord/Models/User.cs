using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Discord.Models
{
    public class User
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public UserState UserState { get; set; }
    }

    public enum UserState
    {
        Online,
        Offline,
        Idle,
        DoNotDisturb
        //public static string Online = "#43B581";
        //public const string Offline = "#747F8D";
        //public const string Idle = "#FAA61A";
        //public const string DoNotDisturb = "#F04747";
    }

    public class UserList : List<User>
    {
        
    }
}
