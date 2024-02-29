using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerDemo.Core.Models
{
    public class Team:BaseModel
    {
        public string TeamName { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
