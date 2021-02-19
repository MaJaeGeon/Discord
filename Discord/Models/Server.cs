using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord.Models
{
    public class Server
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }

    public class ServerList : List<Server>
    {

    }
}
