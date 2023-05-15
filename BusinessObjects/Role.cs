using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelDesk.BusinessObjects
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool IsActive { get; set; }

    }
}
