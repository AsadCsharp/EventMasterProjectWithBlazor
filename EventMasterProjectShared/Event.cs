using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMasterProjectShared
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public string Organizer { get; set; }
        public string ImageUrl { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
